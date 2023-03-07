using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Створюємо масив словників
        Dictionary<int, string>[] dictionaries = new Dictionary<int, string>[]
        {
            new Dictionary<int, string>()
            {
                {0, "Jotaro"},
                {2, "Dio"},
                {4, "Kakyoin"},
                {7, "Polnareff"},
                {8, "Iggy"},
                {10, "Joseph"}
            },
            new Dictionary<int, string>()
            {
                {1, "Josuke"},
                {3, "Okyasu"},
                {5, "Koichi"},
                {6, "Kira"},
                {7, "Rohan"},
                {8, "Shigechi"}
            },
            new Dictionary<int, string>()
            {
                {1, "Giorno"},
                {3, "Mista"},
                {4, "Narancha"},
                {6, "Bruno"},
                {9, "Abaccio"},
                {11, "Fugo"}
            }
        };

        Console.WriteLine("Ваш ключ:");
        int Key = Convert.ToInt32(Console.ReadLine());        
        int Count = 0;
        foreach (Dictionary<int, string> dict in dictionaries)
        {            
            if (dict.ContainsKey(Key))
            {
                Count++;
            }
        }
        Console.WriteLine("Знайдено результатiв: " + Count);
    }
}
