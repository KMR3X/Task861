using System;
using System.Collections.Generic;

namespace Task861
{
    class Program
    {
        static void Main()
        {
            List<int> list = new List<int>();

            Fill(list);
            Print(list);

            Console.WriteLine("Нажмите Enter...");
            Console.ReadLine();

            Remove(list, 25, 50);
            Print(list);

            Console.WriteLine("Нажмите Enter...");
            Console.ReadLine();
        }

        /// <summary>
        /// Метод для заполнения коллекции 100 случайными числами от 0 до 100.
        /// </summary>
        /// <param name="list"></param>
        static void Fill(List<int> list)
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                list.Add(random.Next(0, 101));
            }
        }

        /// <summary>
        /// Метод для удаления из коллекции элементов в указанном диапазоне.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        static void Remove(List<int> list, int x, int y)
        {
            int pointer = 0;

            foreach (int l in list.ToList())
            {
                if (l > x && l < y)
                {
                    pointer = list.IndexOf(l);
                    list.RemoveAt(pointer);
                }
            }
        }

        /// <summary>
        /// Метод для вывода коллекции в консоль.
        /// </summary>
        /// <param name="list"></param>
        static void Print(List<int> list)
        {
            int counter = list.Count;

            for (int i = 0; i < counter; i++)
            {
                    Console.Write($"\t{list[i]}");
            }

            Console.WriteLine($"\nКоличество элементов коллекции: {counter}.\n");
        }
    }
}