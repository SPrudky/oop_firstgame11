using System;
using System.Collections.Generic;
using System.Text;

namespace oop_firstgame11
{
    class Character
    {
        private int shield;
        private int health;
        private int damage;
        public string Name { get; }
        public int Health { get => health; }
        public int Shield { get => shield;}
        public int Damage { get => damage;}

        public Character(string name)
        {
            Name = name;
            health = 100;
            shield = 50;
            damage = 20;

        }

        public void GetHit(int damage)
        {
            shield -= damage;
            if(shield < 0)
            {
                health += shield;
                shield = 0;


            }

        }
        public void Heal()
        {
            health += 15;
        }
        public override string ToString()
        {
            string text = "Name" + Name + "\n";
            text += "Shield" + shield + "\n";
            text += "Health" + health + "\n";
            text += "Damage" + damage + "\n";

            return text;
        }
    }
}
