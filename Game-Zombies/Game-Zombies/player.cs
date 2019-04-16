using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Zombies
{
  public class player
    {
        public string name;
        public int health, healthMax;
        public int power, powerMax;
        public int damage;
        public int Armor;
        public inventory invetory; 

        public player()
        {
          var inventory = new inventory();


            healthMax = 20;
            powerMax = 10;
            health = healthMax;
            power = powerMax;
            damage = 4;
            Armor = 0;
        }
    }
    public class inventory
    {
        public List<item> items = new List<item>();

        public void AddItem(item item)
        {

        }
    }
}
