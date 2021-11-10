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
        protected String Symbol;
        protected int damage;
        protected int maxHp;
        protected Movement movement;
        public int up = 1;
        public int right = 2;
        public int down = 3;
        public int left = 4;
        public int X, Y;
        int goldPurse = 0;

        public Character(int _CharacterX , int _CharacterY, TileType _TOT, string _Symbol, int _Hp, int _MAXHP, int _DAMAGE) : base(_CharacterX, _CharacterY, _TOT)
        {
            HP = _Hp;
            MAX_HP = _MAXHP;
            DAMAGE = _DAMAGE;
            Vision = new Tile[4];
        }
           
             
        public int HP 
        {
            get { return hp; }
            set { hp = value; }
        }
        public int MAX_HP
        {
            get { return maxHp; }
            set { maxHp = value; }
        }
        public int DAMAGE
        {
            get { return damage; }
            set { damage = value; }
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
            target.HP -= damage;
        }

        public Boolean isDead()
        {
            Boolean isDead = false;
            if(HP <= 0)
            {
                return isDead;
            }
            else
            {
                return true;
            }
            
        }

        public virtual bool CheckRange(Character target)
        {
            int Range = 1;
            Boolean inRange = false;
            if(DistanceTo(target) < Range)
            {
                return true;
            }
            else
            {
                return inRange;
            }
            return inRange;
        }

        private int DistanceTo(Character target)
        {
            int _XSPACES = X - target.X;
            int _YSPACES = Y - target.Y;

            int DISTANCE_TO_TARGET = Math.Abs(_XSPACES + _YSPACES);

            return DISTANCE_TO_TARGET;
        }
        public void Move(Movement move)
        {
            switch (move)
            {
                case Movement.Up: Y--;
                    break;
                case Movement.Down: Y++;
                    break;
                case Movement.Left: X--;
                    break;
                case Movement.Right: X++;
                    break;
            }

            movement = move;

        }

        public override string ToString()
        {
            return base.ToString();
        }

        public abstract int ReturnMove();

        public void PickUp(Items i)
        {
            if(i is Gold)
            {
                Gold gold = i as Gold;
                goldPurse = goldPurse + gold.GOLD;
            }
        }
    }

}
