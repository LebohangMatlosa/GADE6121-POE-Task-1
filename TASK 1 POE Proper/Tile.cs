using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    public class Map
    {
        private Hero playercharacter;

        public Hero PLAYERCHARACTER
        {
            get { return myVar; }
            set { myVar = value; }
        }

    }

    public enum TileType
    {
        Character,
        Hero,
        Enemy,
        Gold,
        Weapon


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
        protected Tile(int posX, int posY)
        {
            posX = x;
            posY = y;
            
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
       
        
        public void emptyTile()
        {

        }

    }
}
