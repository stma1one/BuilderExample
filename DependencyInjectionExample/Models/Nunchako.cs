using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Models
{
    public class Nunchako
    {
        public int AttackPoints { get; set; }
        public void Hit(Warrior target)
        {
            Console.WriteLine($"Hit {target.Name} On the Head. ENEMY LOST {AttackPoints} POINTS");
            target.Vitallity -= AttackPoints;
        }

    }
}
