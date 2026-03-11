using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Visitor
    {
        public string name;

        // Статическое поле — общее для всех посетителей
        private static int totalVisitors = 0;

        // Конструктор
        public Visitor(string name)
        {
            this.name = name;
            totalVisitors++; // увеличиваем счётчик при создании объекта
        }

        // Возвращает строку с именем посетителя
        public string PrintInfo()
        {
            return $"Посетитель: {name}";
        }

        // Статический метод для получения общего числа посетителей
        public static string ShowTotalVisitors()
        {
            return $"Всего посетителей: {totalVisitors}";
        }
    }
}
