using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class Map : Tile
    {
        char[,] gameMap = new char[8,14];
        string[] enemy = new string[4];

        int mapWidth = 14;
        int mapHeight = 8;

        Random r = new Random(); 


        public Map(int widthMax,  int widthMin, int heightMIn, int heightMax, int gobAmount )
        {
            string[,] mapSize = new string[8, 14];
            heightMax = 10;
            heightMIn = 5;
            widthMax = 14;
            widthMin = 7;
            mapHeight = r.Next(5, 9);
            mapWidth = r.Next(7, 15);

            

            gobAmount = 4;

        }
        
        private Tile Create(int tileEnumType)
        {
           for(int x = 0; x < 15; x++)
            {
                for(int y = 0; y < 9; y++)
                {
                    gameMap[x, y].ToString(); 
                }
            }
        }

        static void UpdateVision()
        {

        }
    }
    
}
