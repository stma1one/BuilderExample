using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Models.Interfaces
{
    //מכיון שנשק הוא מושג אבסטרקטי - נגדיר לו ממשק המציין מה היכולות של נשק...
    public interface IWeapon
    {
        public int AttackPoints { get; }
        public void Hit(Warrior w);
    }
}
