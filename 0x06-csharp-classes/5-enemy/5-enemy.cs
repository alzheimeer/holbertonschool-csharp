using System;

namespace Enemies
{
    class Zombie
    {
        private int health;
        private string name = "(No name)";
        public Zombie()
        {
            health = 0;
        }
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name=value;
            }
        }
        public int GetHealth()
        {
            return health;
        }
        public override string ToString()
        {
            return String.Format("Zombie name: {0} / Total Health: {1}",name,health);
        }

    }    
}