using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
     abstract class Tile
    {
        protected Tile()
        {
        }
        protected int x;
        protected int y;



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
        public enum TyleType
        {
            Character,
            Hero,
            Enemy,
            Gold, 
            Weapon 


        }
        public void Obstacle(int X, int Y)
        {

        }
    }
}
