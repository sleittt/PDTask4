using System;

namespace BookStore
{
    public class Book
    {
        public string title = "Неизвестно";
        public string author = "Неизвестен";
        public int year;

        public void GetInfo()
        {
            Console.WriteLine($"«{title}», {author} ({year})");
        }
    }
}
