using System;
using System.Collections;

namespace GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            NPC npc1 = new NPC();

            Console.WriteLine(npc1.Health); // Getter

            npc1.Health -= 150; // Setter
            Console.WriteLine(npc1.Health);
        }
    }


    // Properties

    class NPC
    {
        private int health = 100;
        public int Health
        {
            get { return health; }
            set 
            {
                if (value < 0) { health = 0; }
                else if (value > 100) { health = 100; }
                else { health = value; }
            }
        }
    }






    class Player // Simple Gets and Sets (Not recommended)
    {
        private int _health = 100; // field

        public int GetHealth()
        {
            return _health;
        }

        public void SetHealth(int health)
        {
            if (_health + health > 100)  {
                _health = 100;
            }
            else if (_health + health < 0) {
                _health = 0;
                GameOver();
            }
            else {
                _health += health;
            }
        }

        void GameOver()
        {
            Console.WriteLine("You died!");
            // Gameover stuff
        }
    }






}
