using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class Game_Engine
    {
        private Map gamemap;

        public Map GAMEMAP
        {
            get { return gamemap; }
            set { gamemap = value; }
        }

        public Game_Engine()
        {
            GAMEMAP = new Map(10, 10, 10, 10, 5);
        }

        public bool MovePlayer(MovementDirection Direction)
        {
            if(GAMEMAP.PLAYERCHARACTER.ReturnMove(Direction) == Direction)
            {
                GAMEMAP.Create(TileType.Empty, GAMEMAP.PLAYERCHARACTER.X, GAMEMAP.PLAYERCHARACTER.Y);

                GAMEMAP.PLAYERCHARACTER.Move(Direction);
                GAMEMAP.MAPCONTAINER[GAMEMAP.PLAYERCHARACTER.X, GAMEMAP.PLAYERCHARACTER.Y] = GAMEMAP.PLAYERCHARACTER;

                return true;
            }
            return false;
        }

        public string PlayerAttack(int EnemyIndex)
        {
            bool EnemyInRange = false;

            foreach(Tile T in GAMEMAP.PLAYERCHARACTER.VISION)
            {

            }
        }
    }
    
}
