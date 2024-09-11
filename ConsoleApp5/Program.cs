
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> listOfStrings = new List<string> { "яблоко", "киви", "банан", "груша", "автомеханик", "петух", "кристалл", "икра", "крыша", "кирпич", "мадам", "платформа", "керасин", "пешка", "известь", "пятно", "победа", "трактор", "солянка", "рыба", "заповедник", "растение", "фломастер", "капкан", "август"};
        Console.WriteLine("Список строк:");
        foreach (string str in listOfStrings)
        {
            Console.WriteLine(str);
        }

        bool repeatSearch = true;

        while (repeatSearch)
        {
            Console.Write("\nВведите поисковый запрос: ");
            string searchQuery = Console.ReadLine();

            List<string> results = SearchStrings(listOfStrings, searchQuery);

            if (results.Count > 0)
            {
                Console.WriteLine("\nНайденные результаты:");
                foreach (string result in results)
                {
                    Console.WriteLine(result);
                }
            }
            else
            {
                Console.WriteLine("Никаких результатов найдено не было.");
            }

            Console.Write("\nВы хотите продолжить поиск? (Д/Н): ");
            string input = Console.ReadLine();
            if (input.ToUpper() != "Д")
            {
                repeatSearch = false;
            }
        }
    }

    static List<string> SearchStrings(List<string> listOfStrings, string searchQuery)
    {
        List<string> results = new List<string>();

        foreach (string str in listOfStrings)
        {
            if (str.IndexOf(searchQuery, StringComparison.OrdinalIgnoreCase) != -1)
            {
                results.Add(str);
            }
        }
        return results;
    }
}

