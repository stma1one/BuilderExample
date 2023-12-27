using DependencyInjectionExample.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Models
{
    //taken from ninject
    //חרב מממשת את היכולות של כלי נשק
      public class Sword:IWeapon
        {
        public int AttackPoints { get;  }

        public Sword()
        {
            AttackPoints = 5;
        }
       public  void Hit(Warrior w)
       {
                Console.WriteLine($"Chopped {w.Name} clean in half. ENEMY LOST {AttackPoints} POINTS");
                w.Vitallity -= AttackPoints;
       }
      
    }
}
