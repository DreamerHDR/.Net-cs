using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace Lab9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Попросить пользователя указать путь к файлу
            Console.WriteLine("Введите путь к файлу:");
            string filePath = Console.ReadLine();

            if (File.Exists(filePath))
            {
                try
                {
                    // Чтение содержимого файла с кодировкой UTF-8
                    string content = File.ReadAllText(filePath, Encoding.UTF8);

                    // Регулярное выражение для поиска циклов while
                    string pattern = @"while\s*\(.*?\)\s*\{(?:[^{}]*|\{.*?\})*\}";
                    MatchCollection matches = Regex.Matches(content, pattern);

                    if (matches.Count > 0)
                    {
                        Console.WriteLine("Найдены следующие циклы while:");
                        foreach (Match match in matches)
                        {
                            // Вывод каждого найденного цикла while
                            Console.WriteLine(match.Value);
                            Console.WriteLine(); // Пустая строка между циклами
                        }
                    }
                    else
                    {
                        Console.WriteLine("Циклы while не найдены.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Файл не найден.");
            }

            // Ожидание завершения работы программы
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
