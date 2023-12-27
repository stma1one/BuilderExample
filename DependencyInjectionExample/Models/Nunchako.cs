using DependencyInjectionExample.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Models
{
    //נונצ'קו ממשק את היכולות של כלי נשק
    public class Nunchako:IWeapon
    {
        public int AttackPoints { get; set; }

        public Nunchako() {
            AttackPoints = 10;
        }
        public void Hit(Warrior target)
        {
            Console.WriteLine($"Hit {target.Name} On the Head. ENEMY LOST {AttackPoints} POINTS");
            target.Vitallity -= AttackPoints;
        }

    }
}
