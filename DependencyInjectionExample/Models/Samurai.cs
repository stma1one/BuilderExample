using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Models
{
    public class Samurai:Warrior
    {
        //but what if we want to change to a different Weapon?
        public Sword Sword { get;}
       

        public Samurai()
        {
            Sword = new Sword();
            Vitallity = 20;
           
        }

        //What if we want to attack someone who is not a samurai but a ninja warrior?
        public void Attack(Samurai w)
        {
            //but what if we want to attack with a different weapon?
            Sword.Hit(w);
        }

    }
}
