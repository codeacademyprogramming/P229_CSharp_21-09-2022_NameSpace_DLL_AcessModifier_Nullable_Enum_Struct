using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Vehicle
    {
        public string Color;
        private int _year;
        public int Year
        {
            get => _year;
            set
            {
                while (value < 1970)
                {
                    Console.WriteLine("Duzgun Daxil Buraxilis Ili 1970-den Kicik Ola Bilmez");
                    int.TryParse(Console.ReadLine(), out value);
                }
                _year = value;
            }
        }

        public Vehicle(int year)
        {
            Year = year;
        }

        public virtual string ShowInfo()
        {
            return $"Color: {Color}\nYear: {_year}";
        }
    }
}
