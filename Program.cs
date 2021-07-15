using System;
using System.IO;
using System.Text;


namespace Homework__8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows\SaveText.txt";

            if (!File.Exists(path))
            {

                Console.Write("Введите своё имя: ");
                string UserName = Console.ReadLine();

                Console.Write("Введите свой возраст: ");
                int UserAge = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите свою профессию: ");
                string UserProfession = Console.ReadLine();

                string Save = $"Твоё имя: {UserName}\nТвой возраст: {UserAge}\nТвоя профессия: {UserProfession}" + Environment.NewLine;
                File.WriteAllText(path, Save);
            }

            string Greeting = File.ReadAllText(path);
            Console.WriteLine($"{Greeting}");
        }
    }
}
