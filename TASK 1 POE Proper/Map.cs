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

        protected Random Random_Number_Generator = new Random();
        public Map(int widthMax,  int widthMin, int heightMIn, int heightMax, int gobAmount )
        {
            string[,] mapSize = new string[8, 14];
            heightMax = 10;
            heightMIn = 5;
            widthMax = 14;
            widthMin = 7;
            mapHeight = Random_Number_Generator.Next(heightMIn, heightMax);

            mapWidth = Random_Number_Generator.Next(widthMin, widthMax);

            MAPCONTAINER = new Tile[mapWidth, mapHeight];
            enemies = new List<Enemy>();


            

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
        public void Create(TileType typeOfTile, int x = 0, int y = 0)
        {
            switch (typeOfTile)
            {
                case TileType
            }
        }
        

        static void UpdateVision()
        {
            foreach (Enemy E in 
        }
        private List<Enemy> enemies;
    }
    
}
