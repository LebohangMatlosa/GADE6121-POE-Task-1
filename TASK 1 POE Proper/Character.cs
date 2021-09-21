using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
        abstract class Character : Tile
    {
        Tile[] Vision;
        protected int hp;
        protected int damage;
        protected int maxHp;

        public Character(int posX , int posY, TileType tileType) : base(posX , posY, tileType)
        {
            posX = X;
            posY = Y;
            tileType = typeOfTile;
        }

        public int MAX_HP
        {
            get { return maxHp; }
            set { maxHp = value; }
        }


        public int Damage
        {
            get { return damage; }
            set { damage = value; }
        }

        public int HP 
        {
            get { return hp; }
            set { hp = value; }
        }
        public enum Movement
        {
            noMovement,
            Up,
            Down,
            Left,
            Right,
        }

        public virtual void Attack(Character target)
        {
            HP = MAX_HP - Damage;
        }

        public bool isDead()
        {
            return true;
        }

        public virtual bool CheckRange(Character target)
        {
            return true;
        }

        private int DistanceTo(Character target)
        {
            
        }
    }

}
