using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class Shop
    {
        weapon[] weapons = new weapon[3];
        Random ob = new Random();
        object buyer;

        public Shop(weapon[] weapons, Random ob, object buyer)
        {
            this.weapons = weapons;
            this.ob = ob;
            this.buyer = buyer;


        }
        private weapon RandomWeapon()
        {
            ob.Next()
        }
    }
}
