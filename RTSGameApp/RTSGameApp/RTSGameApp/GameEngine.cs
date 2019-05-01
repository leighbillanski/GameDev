using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace RTSGameApp
{
    class GameEngine
    {
        private static System.Timers.Timer aTimer;
        private Map Map = new Map();

        public List<Unit> UnitsOnMap { get { return Map.UnitsOnMap; } }

        public object map { get { return Map.Grid; } }

        public void start()
        {
            Map.attack();

        }

        public void game()
        {
            aTimer = new Timer(1000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            
        }
    }
}
