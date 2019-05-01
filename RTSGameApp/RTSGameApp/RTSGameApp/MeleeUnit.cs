using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSGameApp
{
    class MeleeUnit : Unit
    {
        public static int DAMAGE = 2;
        public MeleeUnit() { }
        public MeleeUnit(int x, int y, int health, int speed, bool attack, int attackRange, string faction, string symbol) :
            base(x, y, health, speed, attack, attackRange, faction, symbol)
        {
        }

        public override void move(int x, int y)
        {
            if (x >= 0 && x < 20)
                X = x;

            if (y >= 0 && y < 20)
                Y = y;
        }

        public override void combat(Unit enemy)
        {
            if (this.isWithinAttackRange(enemy))
            {
                enemy.Health -= DAMAGE;
            }
        }

        public override bool isWithinAttackRange(Unit enemy)
        {
            if ((Math.Abs(this.X - enemy.X) <= this.AttckRange) || (Math.Abs(this.X - enemy.X) < this.AttckRange))
            {
                return true;
            }else
                return false;
        }

        public override Unit nearestUnit(List<Unit> list)
        {
            Unit closest = null;
            int attackRangeX, attackRangeY;
            double sortestRange = 10;

            foreach (Unit un in list)
            {
                attackRangeX = Math.Abs(this.X - un.X);
                attackRangeY = Math.Abs(this.Y - un.Y);

                double range = Math.Sqrt(Math.Pow(attackRangeX, 2) + Math.Pow(attackRangeY, 2));
                if (attackRangeX < sortestRange)
                {
                    sortestRange = range;
                    closest = un;
                }
            }
            return closest;
        }

        public override bool isAlive()
        {
            bool result = (this.Health > 0) ? true : false;
            return result;
        }


        public override string toString()
        {
            string output = "x : " + X + Environment.NewLine
                + "y : " + Y + Environment.NewLine
                + "Health : " + Health + Environment.NewLine
                + "Speed : " + Speed + Environment.NewLine
                + "Attack : " + (Attack ? "Yes" : "No") + Environment.NewLine
                + "Attack Range : " + AttckRange + Environment.NewLine
                + "Faction/Team : " + Faction + Environment.NewLine
                + "Symbol : " + Symbol + Environment.NewLine;
            return output;
        }
    }
}
