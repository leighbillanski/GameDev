using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Game_Dev_
{
    class MeleeUnit : Unit
    {
        private static int DAMAGE = 2;
        private Unit near;

        public MeleeUnit()
        {

        }
        public MeleeUnit(int x, int y, int health, int speed, bool attack, int attackRange, string faction, string symbol):
            base( x,  y,  health,  speed,  attack,attackRange,faction,symbol)
        {
            
        }

        public override void combat(Unit enemy)
        {
            int helath = enemy.getHealth();

            if(getAttack() == true)
            {
                helath -= DAMAGE;
            }
        }

        public override bool isAlive()
        {
            if (getHealth() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool isWithinAttackRange(Unit enemy)
        {
            double distance;
            double minRange = 1;
            
                distance = Math.Sqrt(Math.Pow((this.getX() - enemy.getX()), 2) + Math.Pow((this.getY() - enemy.getY()), 2));

            if (distance <= minRange)
            {
                base.setAttack(true);
                combat(enemy);
                return true;

            }
            else
                base.setAttack(false);
                return false;
        }

        public override void move(int x, int y)
        {
            if (x >= 0 && x < 20)
                this.setX(x);
            if (y >= 0 && y < 20)
                this.setY(y);
        }

        public override Unit nearestUnit(List<Unit> u)
        {
            near = null;
            double distance;
            double minRange = 10;

            foreach(Unit unit in u)
            {
                distance = Math.Sqrt(Math.Pow((this.getX() - unit.getX()), 2) + Math.Pow((this.getY() - unit.getY()), 2));

                if (distance < minRange)
                {
                    minRange = distance;
                    near = unit;
                }
            }
            return near;
        }

        public override string toString()
        {
            throw new NotImplementedException();
        }
    }
}
