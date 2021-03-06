using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1_POE_Proper
{
    class MeleeWeaponClass : Weapon_Class
    {
        public enum MELEEWEAPONS
        {
            LongSword, Dagger
        }
        
        public MeleeWeaponClass(MELEEWEAPONS typeOfWeapon, int k, int l, TileType Type = TileType.Weapon, char sybolconstruc = ','): base(sybolconstruc,l, k, Type) 
        {
            if(MELEEWEAPONS.LongSword == typeOfWeapon)
            {
                base.symbol = 'L';
                base.DAMAGE = 6;
                base.COST = 5;
                base.DURABILITY = 6;
                
            }
            if (MELEEWEAPONS.Dagger == typeOfWeapon)
            {
                base.symbol = 'D';
                base.DAMAGE = 3;
                base.COST = 3;
                base.DURABILITY = 10;

            }
        }
    }
}
