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
        public static List<enemy> enemies;

     

        public static void Load()
        {
            items = new List<item>();
            enemies = new List<enemy>();

            items.Add(new item("stick", 1, true));

            enemies.Add(new enemy("Zombi", 0, 20, 2, 0));
            
        }


        public static item GetItem(int ID, int count=1)
        {
            item item = (item)items.Find(I => I.Id == ID).Clone();
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
            enemy enemy =(enemy)enemies.Find(E => E.ID == ID).Clone();

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
 