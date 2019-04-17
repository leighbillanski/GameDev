using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Game_Dev_
{
    public abstract class Unit
    {
        private int x;
        private int y;
        private int health;
        private int speed;
        private bool attack;
        private int attackRange;
        private string faction;
        private string symbol;
        

        public Unit() {
        }

        public Unit(int x, int y, int health, int speed, bool attack, int attackRange, string faction, string symbol)
       {
            this.x = x;
            this.y = y;
            this.symbol = symbol;
            this.speed = speed;
            this.health = health;
            this.faction = faction;
            this.attackRange = attackRange;
            this.attack = attack;

        }

        ~Unit()
        {

        }

        //Accessers
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public int getHealth()
        {
            return health;
        }
        public int getSpeed()
        {
            return speed;
        }
        public bool getAttack()
        {
            return attack;
        }
        public int getAttackRange()
        {
            return attackRange;
        }
        public string getFaction()
        {
            return faction;
        }
        public string getSymbol()
        {
            return symbol;
        }

        
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public void setHealth(int health)
        {
            this.health = health;            
        }
        public void setSpeed(int speed)
        {
            this.speed = speed;
        }
        public void setAttack(bool attack)
        {
            this.attack = attack;
        }
        public void setAttackRange(int attackRange)
        {
            this.attackRange = attackRange;
        }
        public void setFaction(string faction)
        {
            this.faction = faction;
        }
        public void setSymbol(string symbol)
        {
            this.symbol = symbol;
        }

        //Abstract methods
        public abstract void move(int x, int y);
        public abstract void combat(Unit enemy);
        public abstract bool isWithinAttackRange(Unit enemy);
        public abstract Unit nearestUnit(List<Unit> u);
        public abstract bool isAlive();
        public abstract string toString();


    }

}
