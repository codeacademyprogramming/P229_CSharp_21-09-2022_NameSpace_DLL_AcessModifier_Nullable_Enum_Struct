using System;

namespace NullableEnumStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            //int? a = null;
            //string b = "";

            //float? test = null;
            //char? symbol = null;

            //string day = "monday";

            //Console.WriteLine("");
            //Console.WriteLine($"{(int)WeekDay.Monday} {WeekDay.Monday}");

            //foreach (var item in Enum.GetValues(typeof(WeekDay)))
            //{
            //    Console.WriteLine($"{(byte)item} {item}");
            //}

            //string[] arr = Enum.GetNames(typeof(WeekDay));

            //foreach (string item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //int a = 10;
            //Console.WriteLine((WeekDay)a);

            //WeekDay weekDay = (WeekDay)a;

            //if (weekDay == WeekDay.Monday)
            //{
            //    Console.WriteLine("Bazar Ertese");
            //}

            //switch (weekDay)
            //{
            //    case WeekDay.Monday:
            //        break;
            //    case WeekDay.Tuesday:
            //        break;
            //    case WeekDay.Wednesday:
            //        break;
            //    default:
            //        break;
            //}


            Area area = new Area();
            area.A = 10;
            area.B = 3;

            Console.WriteLine(area.CalculateArea());

            //Area area1;
            //area1.A = 36;
            //Console.WriteLine(area1.A);
        }
    }
}
