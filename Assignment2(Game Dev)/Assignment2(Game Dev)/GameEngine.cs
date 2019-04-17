using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Assignment2_Game_Dev_
{
    class GameEngine
    {
        private static System.Timers.Timer aTimer;
        private Map map = new Map();
        Unit mun = new MeleeUnit();
        Unit run = new RangeUnit();

        public void load()
        {
            map.generateBattlefieldUnit();
            mun.isWithinAttackRange(run);
        }

        public void game() {        
            
            aTimer = new Timer(1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;  
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            

            if (mun.getAttack() == false)
            {
                map.move(mun);
            }
            while (mun.getAttack() == true)
            {
                mun.combat(run);
            }
            if (mun.isWithinAttackRange(run))
            {
                mun.combat(run);
            }
            if (mun.getHealth() < 25)
            {
                mun.setX(mun.getX() - 1);
                mun.setY(mun.getY() - 1);
            }


            if (run.getAttack() == false)
            {
                map.move(run);
            }
            while (run.getAttack() == true)
            {
                run.combat(mun);
            }
            if (run.isWithinAttackRange(mun))
            {
                run.combat(mun);
            }
            if (run.getHealth() < 25)
            {
                run.setX(run.getX() - 1);
                run.setY(run.getY() - 1);
            }
            map.updatePosition();
        }
    }
}
