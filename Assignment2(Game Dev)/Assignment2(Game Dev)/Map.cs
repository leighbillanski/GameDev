using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment2_Game_Dev_
{
    class Map
    {
        object[,] map = new object[19,19];
        Random random = new Random();

        private int x, y;
        public void generateBattlefieldUnit()
        {
            for (int i = 0; i < 19; i++)
                {
                for (int j = 0; j < 19; j++)
                    {
                        map[i,j] = ".";
                    }
                }
            x = random.Next(19);
            y = random.Next(19);

            map[x, y] = "x";
        }

        public void move(Unit unit)
        {

            unit.move(x, y);
            x = unit.getX();
            y = unit.getY();
        } 

        public void updatePosition()
        {
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    map[i, j] = ".";
                }
            }
            map[x, y] = "x";

        }
    }
}
