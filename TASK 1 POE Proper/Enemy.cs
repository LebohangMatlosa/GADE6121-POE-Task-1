using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    abstract class Enemy : Character
    {
        protected Random r = new Random();
        private string enemyType;


        protected Enemy(int posX, int posY, int damage, int hp, int maxHp, string type) : base(posX, posY, damage, hp, maxHp)
        {
            posX = X;
            posY = Y;
            damage = Damage;
            hp = HP;


        }

      

        public string EnemyType
        {
            get { return enemyType; }
            set { enemyType = value; }
        }


        override public String ToString()
        {
            return enemyType + "at" + "["+ X +","+ Y+"]"+"(Amount "+ Damage + " )" ;
        }
       
    }
}
