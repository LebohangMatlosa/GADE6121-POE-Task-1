using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    
    public enum TileType
    {
        Character,
        Hero,
        Enemy,
        Gold,
        Weapon,
        Barrier,
        Empty

    }
    public enum MovementDirection
    {
        noMovement,
        Up,
        Down,
        Left,
        Right,
    }
    abstract class Tile
    {
        
        protected int x;
        protected int y;
        protected TileType typeOfTile;
        protected Tile(int posX, int posY, TileType TILETYPE)
        {
            posX = X;
            posY = Y;
            TILETYPE = TYPEOFTILE;
            
        }


        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y= value; }
        }
        
        public TileType TYPEOFTILE
        {
            get { return typeOfTile; }
            set { typeOfTile = value; }
        }
        public void emptyTile()
        {

        }

    }
}
