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
        protected int distance;
        private GOLD gold;
        

        public GOLD Gold
        {
            get { return gold; }
            set { gold = value; }
        }
        private weapon Weapon;

        public weapon WEAPON
        {
            get { return Weapon; }
            set { Weapon = value; }
        }


        public int Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        public Character(int posX , int posY, TileType tileType) : base(posX , posY, tileType)
        {

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
            return Distance; 
        }
        public void Move(Movement e)
        {

        }
        public void Loot()
        {
            if(HP==0 && Weapon == false)
            {
                
                Pickup(gold, 3);
            }
            else 
            {

            }
        }
        public void Pickup(Items i, int gold)
        {
            for(int p = 0; p <gold; p++)
            {
                for (int N = 0; N > gold; N++)
                {
                    if (TileType.Hero != TileType.Gold)
                    {
                        i = Gold;
                    }
                    else if (TileType.Hero == TileType.Weapon)
                    {
                        private void Equip(weapon w)
                        {
                            w = WEAPON;
                        }
                    }
                }

            }

        }
        
    }

}
