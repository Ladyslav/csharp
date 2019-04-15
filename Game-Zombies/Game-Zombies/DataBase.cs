using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Zombies
{
  public static class DataBase
    {
        public static List<item> items;
        private static List<enemy> enemies;

        internal static List<enemy> Enemies { get => enemies; set => enemies = value; }

        public static void Load()
        {
            items = new List<item>();
            enemies = new List<enemy>();

            items.Add(new item("stick", 1, true));
            
        }


        public static item GetItem(int ID, int count=1)
        {
            item item =)tems.Find(I => I.Id == ID).Clone();
            if (item != null)
            {
                if (item.isStack)
                    item.count = count;
                else
                    item.count = 1;
                return item;
            }
            else
            {
                return null;
            }
        }

        public static  enemy GetEnemy(int ID)
        {
            enemy enemy = enemies.Find(E => E.ID == ID);

            if (enemy != null)
            {
                return enemy;
            }
            else
            {
                return null;
            }
        } 


    }
}
