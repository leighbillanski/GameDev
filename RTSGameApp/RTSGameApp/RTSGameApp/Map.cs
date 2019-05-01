using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTSGameApp
{
    class Map
    {
        private const int MAX_RANDOM_UNITS = 50;
        public const string FIELD_SYMBOL = ".";
        private string[,] grid = new string[20, 20];
        private List<Unit> unitsOnMap = new List<Unit>();
        private int numberOfUnitsOnMap = 0;
        Random rnd = new Random();

        public string[,] Grid
        {
            get { return grid; }
        }

        public List<Unit> UnitsOnMap
        {
            get { return unitsOnMap; }
        }

        private void moveOnMap(Unit u, int newX, int newY)
        {
            grid[u.X, u.Y] = FIELD_SYMBOL;
            grid[newX, newY] = u.Symbol;
        }

        public void attack()
        {
            int x, y, randomAttackRange;
            bool attackOption;
            
            string team, symbol;

            while (numberOfUnitsOnMap < 50)
            {
            x = rnd.Next(20);
            y = rnd.Next(20);
            symbol = rnd.Next(0,2) ==1? "M" : "R";

                if (symbol.Equals("M"))
                {
                    attackOption = rnd.Next(0, 2) == 1 ? true : false;
                    team = rnd.Next(0, 2) == 1 ? "RED" : "GREEN";
                    Unit temp = new MeleeUnit(x, y, 100, -1, attackOption, 1 , team, symbol);
                    UnitsOnMap.Add(temp);

                    grid[x, y] = unitsOnMap[numberOfUnitsOnMap].Symbol;

                    numberOfUnitsOnMap++;
                    
                }
                else
                {

                    attackOption = rnd.Next(0, 2) == 1 ? true : false;
                    randomAttackRange = rnd.Next(1, 20);
                    team = rnd.Next(0, 2) == 1 ? "RED" : "GREEN";
                    Unit tmp = new RangeUnit(x, y, 100, -1, attackOption, randomAttackRange, team, symbol);
                    UnitsOnMap.Add(tmp);

                    grid[x, y] = unitsOnMap[numberOfUnitsOnMap].Symbol;
                    numberOfUnitsOnMap++;
                }
            }
        }

        public void checkHealth()
        {
            for (int i = 0; i < numberOfUnitsOnMap; i++)
            {
                if (!UnitsOnMap[i].isAlive())
                {
                    grid[unitsOnMap[i].X, unitsOnMap[i].Y] = FIELD_SYMBOL;
                    unitsOnMap.RemoveAt(i);
                    numberOfUnitsOnMap--;
                }
            }
        }//End of CheckHealth Method

        public void update(List<Unit> unit,int newX,int newY)
        {
            foreach(Unit u in unit)
            {               
                moveOnMap(u, newX, newY);
                u.move(newX, newY);
            }
        }

    }

}