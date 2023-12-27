namespace DependencyInjectionExample.Models
{
    //מחלקת בסיס של לוחם
    public class Warrior
    {
        private bool isAlive;
        public string Name { get;  set; }
        public int Vitallity { get;  set; }

        public Warrior()
        {
           
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