using System;
using BookStore;
using VisitorCounter;

namespace CombinedTasks
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите задачу:");
                Console.WriteLine("1. Книжная полка");
                Console.WriteLine("2. Умный счетчик");
                Console.WriteLine("0. Выход");
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        RunBookTask();
                        break;
                    case "2":
                        RunVisitorTask();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный ввод. Нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void RunBookTask()
        {
            Console.Clear();
            Console.WriteLine("=== Книжная полка ===\n");

            // Первая книга
            Book myBook = new Book();
            myBook.title = "Война и мир";
            myBook.author = "Лев Толстой";
            myBook.year = 1869;
            Console.Write("Информация о первой книге: ");
            myBook.GetInfo();

            // Вторая книга с полями по умолчанию
            Book unknownBook = new Book();
            Console.Write("Информация о второй книге: ");
            unknownBook.GetInfo();

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }

        static void RunVisitorTask()
        {
            Console.Clear();
            Console.WriteLine("=== Умный счетчик ===\n");

            Visitor visitor1 = new Visitor("Анна");
            Visitor visitor2 = new Visitor("Борис");
            Visitor visitor3 = new Visitor("Виктор");

            visitor1.PrintInfo();
            visitor2.PrintInfo();
            visitor3.PrintInfo();

            Console.WriteLine(); // пустая строка
            Visitor.ShowTotalVisitors();

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
        }
    }
}