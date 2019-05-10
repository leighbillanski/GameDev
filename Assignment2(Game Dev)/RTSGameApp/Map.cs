using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSGameApp
{
    class Map
    {
        private static int numberOfUnits = 50;
        private string[,] mapArray = new string[20, 20];
        private List<Unit> unitList = new List<Unit>();
        private int unitNum;

        public string[,] getMapArray
        {
            get
            {
                return mapArray;
            }
        }

        public List<Unit> UnitsOnMap
        {
            get
            {
                return unitList;
            }
        }

        public void generateMap()
        {
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    mapArray[i, j] = ".";
                }
            }
        }
        public void generateUnits()
        {
            Random r = new Random();
            int x, y, randomAttackRange;
            bool attackOption;

            string team, symbol;

            while (unitNum < numberOfUnits)
            {
                x = r.Next(20);
                y = r.Next(20);
                symbol = r.Next(0, 2) == 1 ? "M" : "R";
                if(symbol == "M")
                {
                    attackOption = r.Next(0, 2) == 1 ? true : false;
                    team = r.Next(0, 2) == 1 ? "RED" : "GREEN";
                    Unit temp = new MeleeUnit(x, y, 100, -1, attackOption, 1, team, symbol);
                    unitList.Add(temp);
                    mapArray[x, y].Remove(x, y);
                    mapArray[x,y] = unitList[unitNum].Symbol;
                    unitNum++;
                }
                else
                {
                    attackOption = r.Next(0, 2) == 1 ? true : false;
                    randomAttackRange = r.Next(1, 20);
                    team = r.Next(0, 2) == 1 ? "RED" : "GREEN";
                    Unit temp = new MeleeUnit(x, y, 100, -1, attackOption, randomAttackRange, team, symbol);
                    unitList.Add(temp);
                    mapArray[x, y].Remove(x, y);
                    mapArray[x, y] = unitList[unitNum].Symbol;
                    unitNum++;
                }
            }

        }
    }
}
