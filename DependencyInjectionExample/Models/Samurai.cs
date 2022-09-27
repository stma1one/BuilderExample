using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Models
{
    public class Samurai : Warrior
    {
        #region ?
        //but what if we want to change to a different Weapon?
        #endregion
        #region answer
        //public IWeapon weapon {get;}
        #endregion
        public Sword Sword { get; }


        #region DI
        /*public Samurai(Weapon weapon)
         * { 
         *      this.weapon=weapon;
         *      Vitality=20;
         * }
        */
        #endregion
        public Samurai()
        {
            Sword = new Sword();
            Vitallity = 20;
           
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
                                
            Sword.Hit(w);
        }

    }
}
