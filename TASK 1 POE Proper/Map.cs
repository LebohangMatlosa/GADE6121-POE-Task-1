using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    public class Map 
    {

        private Tile[,] mapcontainer;

        public Tile[,] MAPCONTAINER
        {
            get { return mapcontainer; }
            set { mapcontainer = value; }
        }
        private Hero playerharacter;

        public Hero PLAYERCHARACTER
        {
            get { return playerharacter; }
            set { playerharacter = value; }
        }

        private List<Enemy> enemies;

        public List<Enemy> ENEMIES
        {
            get { return enemies; }
            set { enemies = value; }
        }


        private int mapwidth;
        public int MAPWIDTH
        {
            get { return mapwidth; }
            set { mapwidth = value; }
        }
        private int mapheight;
        public int MAPHEIGHT
        {
            get { return mapheight; }
            set { mapheight = value; }
        }


        Random r = new Random();

        protected Random Random_Number_Generator = new Random();
        public Map(int _MINWIDTH,int _MAXWIDTH, int _MINHEIGHT, int _MAXHEIGHT, int _NUMBEROFENEMIES)
        {
            MAPWIDTH = Random_Number_Generator.Next(_MINWIDTH, _MAXWIDTH);
            MAPHEIGHT = Random_Number_Generator.Next(_MINHEIGHT, _MAXHEIGHT);

            MAPCONTAINER = new Tile[MAPWIDTH,MAPHEIGHT];

            ENEMIES = new List<Enemy>();

            GenerateInitialMap(_NUMBEROFENEMIES);

            UpdateVision();
        }

        public void UpdateVision()
        {
            foreach(Enemy E in ENEMIES)
            {
                E.VISION.Clear();

                if(E.X > 0)
                {
                    E.VISION.Add(MAPCONTAINER[E.X - 1, E.Y]);
                }

                if (E.X < MAPWIDTH)
                {
                    E.VISION.Add(MAPCONTAINER[E.X + 1, E.Y]);
                }

                if (E.Y > 0)
                {
                    E.VISION.Add(MAPCONTAINER[E.X, E.Y - 1]);
                }

                if (E.Y < 0)
                {
                    E.VISION.Add(MAPCONTAINER[E.X, E.Y + 1]);
                }
            }
            PLAYERCHARACTER.VISION.Clear();

            if (PLAYERCHARACTER.X > 0)
            {
                PLAYERCHARACTER.VISION.Add(MAPCONTAINER[PLAYERCHARACTER.X - 1, PLAYERCHARACTER.Y]);
            }
            
            if (PLAYERCHARACTER.X < MAPWIDTH)
            {
                PLAYERCHARACTER.VISION.Add(MAPCONTAINER[PLAYERCHARACTER.X + 1, PLAYERCHARACTER.Y]);
            }

            if (PLAYERCHARACTER.Y > 0)
            {
                PLAYERCHARACTER.VISION.Add(MAPCONTAINER[PLAYERCHARACTER.X, PLAYERCHARACTER.Y - 1]);
            }

            if (PLAYERCHARACTER.Y < 0)
            {
                PLAYERCHARACTER.VISION.Add(MAPCONTAINER[PLAYERCHARACTER.X, PLAYERCHARACTER.Y + 1]);
            }

            int t = 0;
        }
        
        void GenerateInitialMap(int _NUMBEROFENEMIES)
        {
            for (int y = 0; y < MAPWIDTH; y++)
            {
                for (int x = 0; x < MAPHEIGHT; x++)
                {
                    if (x == 0 || x == MAPWIDTH - 1 || y == 0 || y == MAPHEIGHT - 1)
                    {
                        Create(TileType.Barrier, x, y);
                    }
                    else
                    {
                        Create(TileType.Empty, x, y);
                    }
                }
            }

            Create(TileType.Hero);

            for(int e = 0; e < _NUMBEROFENEMIES; e++)
            {
                Create(TileType.Enemy);
            }
        }

        public void Create(TileType TypeOfTile, int X = 0, int Y = 0)
        {
            switch (TypeOfTile)
            {
                case TileType.Barrier:
                    Obstacle NewBarrier = new Obstacle(X, Y, "", TypeOfTile);
                    MAPCONTAINER[X, Y] = NewBarrier;
                    break;
                case TileType.Empty:
                    emptyTile NewEmptyTile = new emptyTile(X , Y , "" , TypeOfTile);
                    MAPCONTAINER[X, Y] = NewEmptyTile;
                    break;
                case TileType.Hero:
                    int HeroX = Random_Number_Generator.Next(0, MAPWIDTH);
                    int HeroY = Random_Number_Generator.Next(0, MAPHEIGHT);

                    while(MAPCONTAINER[HeroX, HeroY].TYPEOFTILE != TileType.Empty)
                    {
                        HeroX = Random_Number_Generator.Next(0, MAPWIDTH);
                        HeroY = Random_Number_Generator.Next(0, MAPHEIGHT);
                    }

                    Hero NewHero = new Hero(HeroX, HeroY, TypeOfTile, "H", 100, 100, 10);
                    PLAYERCHARACTER = NewHero;
                    MAPCONTAINER[HeroX, HeroY] = NewHero;
                    break;
                case TileType.Enemy:
                    int EnemyX = Random_Number_Generator.Next(0, MAPWIDTH);
                    int EnemyY = Random_Number_Generator.Next(0, MAPHEIGHT);

                    while(MAPCONTAINER[EnemyX, EnemyY].TYPEOFTILE != TileType.Empty)
                    {
                        EnemyX = Random_Number_Generator.Next(0, MAPWIDTH);
                        EnemyY = Random_Number_Generator.Next(0, MAPHEIGHT);
                    }

                    Goblin NewEnemy = new Goblin(EnemyX, EnemyY, TypeOfTile , "G" , 100, 100, 10);
                    ENEMIES.Add(NewEnemy);
                    MAPCONTAINER(EnemyX, EnemyY) = NewEnemy;
                    break;
                case TileType.Gold:
                    break;
            }
        }

        public override string ToString()
        {
            string MapString = "";

            for(int y = 0; y < MAPHEIGHT; y++)
            {
                for(int x = 0; x < MAPWIDTH; x++)
                {
                    MapString += MAPCONTAINER[x, y].SYMBOL;
                }
                MapString += "\n";
            }

            return MapString;
        }

    }
    
}
