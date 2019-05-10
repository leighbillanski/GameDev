using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSGameApp
{
    class GameEngine
    {
        Map map = new Map();

        public Map Map { get { return map; } }

        public void start()
        {
            map.generateMap();
            map.generateUnits();
            
        }
    }
}
