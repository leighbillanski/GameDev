using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Game_Dev_
{
    class RangeUnit : Unit
    {
        public static int DAMAGE = 2;
        private int distance;
        private Unit near;

        public RangeUnit() { }
        public RangeUnit(int x, int y, int health, int speed, bool attack, int attackRange, string faction, string symbol) :
            base(x, y, health, speed, attack, attackRange, faction, symbol)
        {
            
        }

        public override void combat(Unit enemy)
        {
            int helath = enemy.getHealth();

            if (getAttack() == true)
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
            double range;
            distance = 5;
            base.setAttackRange(distance);

            range = Math.Sqrt(Math.Pow((this.getX() - enemy.getX()), 2) + Math.Pow((this.getY() - enemy.getY()), 2));

            if (range <= base.getAttackRange())
            {
                combat(enemy);
                return true;

            }
            return false;
        }

        public override void move(int x, int y)
        {
            if ((near.getX() > x) && (near.getY() > y))
            {
                this.setX(x + 1);
                this.setY(y + 1);
            }
            else if ((near.getX() > x) && (near.getY() < y))
            {
                this.setX(x + 1);
                this.setY(y - 1);
            }
            else if ((near.getX() < x) && (near.getY() > y))
            {
                this.setX(x - 1);
                this.setY(y + 1);
            }
            else if ((near.getX() < x) && (near.getY() < y))
            {
                this.setX(x - 1);
                this.setY(y - 1);
            }
        }

        public override Unit nearestUnit(List<Unit> u)
        {
            near = null;
            double distance;
            double minRange = 10;

            foreach (Unit unit in u)
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
