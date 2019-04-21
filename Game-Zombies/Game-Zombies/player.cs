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

            //inventory.AddItem(new item("Stick", 0, true, 6));
            
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
            if (items.Count > 0)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (item.Id == items[i].Id && items[i].isStack)
                    {
                        items[i].count += item.count;
                        break;
                    }
                    else if (i == items.Count - 1)
                    {
                        items.Add(item);
                        break;
                    }
                }
            }
            else
                items.Add(item);

        }

        public void GetAllItems()
        {
            for(int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{i}: {items[i].name}, количество: {items[i].count}");
            }
        }
    }
}
