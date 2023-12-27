using DependencyInjectionExample.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Models
{
    //סמוראי סוג של לוחם
    public class Samurai : Warrior
    {
        #region ?
        //but what if we want to change to a different Weapon?
        #endregion
        #region answer
        //public IWeapon weapon {get;}
        #endregion
        public IWeapon Weapon { get; }


        #region DI
        /*public Samurai(Weapon weapon)
         * { 
         *      this.weapon=weapon;
         *      Vitality=20;
         * }
        */
        #endregion
        public Samurai(IWeapon weapon)
        {
            this.Weapon = weapon;
           
           
        }

        #region ?
        //What if we want to attack someone who is not a samurai but a ninja warrior?
        #endregion
        #region answer
        /*
         * public void Attack(Warrior w)
         * {
         */ 
             #region answer
          //    weapon.Hit(w);  
             #endregion
         // }
         
         
        #endregion       
        public void Attack(Samurai w)
        {
            #region?
            //but what if we want to attack with a different weapon?
            #endregion
                                
            Weapon.Hit(w);
        }

    }
}
