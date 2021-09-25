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
        Weapon


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
