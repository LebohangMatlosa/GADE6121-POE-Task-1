using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class Character : Tile
    {
        Tile[] Vision = new Tile[4];
        protected int health;
        protected int attack;
        protected int maxHp;

        public Character(int X, int Y)
        {
            X
        }

        public int MAX_HP
        {
            get { return maxHp; }
            set { maxHp = value; }
        }


        public int Attack
        {
            get { return attack; }
            set { attack = value; }
        }

        public int Health 
        {
            get { return health; }
            set { health = value; }
        }
        public enum Movement
        {
            noMovement,
            Up,
            Down,
            Left,
            Right,
        }


    }

}
