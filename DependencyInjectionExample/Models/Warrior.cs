namespace DependencyInjectionExample.Models
{
    public class Warrior
    {
        private bool isAlive;
        public string Name { get;  set; }
        public int Vitallity { get;  set; }

        public Warrior()
        {
            Vitallity = 20;
            IsAlive = true; 
        }

        
        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
            set
            {
                if (Vitallity <= 0) isAlive = false; else isAlive = true;
            }
        }
    }
}