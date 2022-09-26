using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Models
{
    //taken from ninject
      public class Sword
        {
        public int AttackPoints { get;  }

        public Sword()
        {
            AttackPoints = 5;
        }
       public void Hit(Warrior target)
       {
                Console.WriteLine($"Chopped {target.Name} clean in half. ENEMY LOST {AttackPoints} POINTS");
                target.Vitallity -= AttackPoints;
       }
      
    }
}
