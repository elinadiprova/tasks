using System;
using System.Collections.Generic;
using System.Linq;

namespace Items
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();
            items = Generator(100);
            //foreach (var t in items)
            //{
            //    Console.Write($"{t.ItemCode} {t.Description} {t.Quantity} \n");
            //}

            //Console.Write($"___________________________\n");
            foreach (var t in GroupItems(items))
            {
                Console.Write($"{t.ItemCode} {t.Description} {t.Quantity} \n");
            }
        }

        static List<Item> Generator(int count)
        {
            List<Item> items = new List<Item>();
            Random rnd = new Random();
            int code = 0; 
            for (int i = 0; i<count; i++)
            {
                items.Add(new Item(code = rnd.Next(1, 6), $"test test {code}", rnd.Next(1, 10)));
            }
            return items;
        }

        static List<Item> GroupItems(List<Item> items)
        {
            List<Item> result = new List<Item>();
            //Рабочий тоже
            for (int i = 0; i < items.Count; i++)
            {
                var create = true;
                for (int j = 0; j < result.Count; j++)
                {
                    create = false;
                    if (result[j].ItemCode == items[i].ItemCode)
                    {
                        result[j].Quantity += items[i].Quantity;
                        break;
                    }
                    create = true;
                }
                if (create) result.Add(items[i]);
            }

            // РАБОЧИЙ
            for (int i = 0; i < items.Count; i++)
            {
                if (result.FirstOrDefault(w => w.ItemCode == items[i].ItemCode) != null)
                {
                    result.FirstOrDefault(w => w.ItemCode == items[i].ItemCode).Quantity += items[i].Quantity;
                }
                else
                {
                    result.Add(items[i]);
                }
            }
            return result;

        }
    }
}
