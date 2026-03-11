using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Book
    {
        // Поля (по условию public)
        public string title ;
        public string author ;
        public int year;

        // Метод, возвращающий информацию о книге (в консольном варианте был бы Console.WriteLine)
        public string GetInfo()
        {
            return $"«{title}», {author} ({year})";
        }
    }
}
