using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSGameApp
{
    abstract class Unit
    {
        protected int x,y,health,speed,attackRange;
        protected bool attack;
        protected string faction, symbol;

        public Unit() { }

        public Unit(int x, int y, int health, int speed, bool attack, int attackRange, string faction, string symbol)
        {
            this.x = x;
            this.y = y;
            this.health = health;
            this.speed = speed;
            this.attack = attack;
            this.attackRange = attackRange;
            this.faction = faction;
            this.symbol = symbol;
        }

        ~Unit() { }

        //Accessers
        public int X { get; set; }
        public int Y { get; set;}
        public int Health { get; set; }
        public int Speed { get; set; }
        public bool Attack { get; set; }
        public int AttckRange { get; set; }
        public string Faction { get; set; }
        public string Symbol { get; set; }

        //Abstract methods
        public abstract void move(int x, int y);
        public abstract void combat(Unit enemy);
        public abstract bool isWithinAttackRange(Unit enemy);
        public abstract Unit nearestUnit(List<Unit> u);
        public abstract bool isAlive();
        public abstract string toString();
    }
}
