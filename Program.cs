using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //Task 1
            //Console.Write("Номер дня недели: ");
            //int day = int.Parse(Console.ReadLine());
            //switch(day )
            //{
            //    case 1: Console.WriteLine("Понедельник");
            //        break;
            //    case 2:
            //        Console.WriteLine("Вторник");
            //        break;
            //    case 3:
            //        Console.WriteLine("Среда");
            //        break;
            //    case 4:
            //        Console.WriteLine("Четверг");
            //        break;
            //    case 5:
            //        Console.WriteLine("Пятница");
            //        break;
            //    case 6:
            //        Console.WriteLine("Суббота");
            //        break;
            //    case 7:
            //        Console.WriteLine("Воскресенье");
            //        break;
            //    default: Console.WriteLine("Такого дня в неделе нет");
            //        break;




            //Task 2
            //Console.Write("Введите номер месяца: ");
            //int month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 1:
            //        Console.WriteLine("Январь");
            //        break;
            //    case 2:
            //        Console.WriteLine("Февраль");
            //        break;
            //    case 3:
            //        Console.WriteLine("Март");
            //        break;
            //    case 4:
            //        Console.WriteLine("Апрель");
            //        break;
            //    case 5:
            //        Console.WriteLine("Май");
            //        break;
            //    case 6:
            //        Console.WriteLine("Июнь");
            //        break;
            //    case 7:
            //        Console.WriteLine("Июль");
            //        break;
            //    case 8:
            //        Console.WriteLine("Август");
            //        break;
            //    case 9:
            //        Console.WriteLine("Сентябрь");
            //        break;
            //    case 10:
            //        Console.WriteLine("Октябрь");
            //        break;
            //    case 11:
            //        Console.WriteLine("Ноябрь");
            //        break;
            //    case 12:
            //        Console.WriteLine("Декабрь");
            //        break;
            //    default: Console.WriteLine("Такого месяца года не существует");
            //        break;

            //Task 3
            //try
            //{


            //    Console.Write("Введите транспортное стредство: ");
            //    char transport = char.Parse(Console.ReadLine());
            //    switch (transport)
            //    {
            //        case 'а': Console.WriteLine("У автомобиля 250 км/час");
            //            break;
            //        case 'в': Console.WriteLine("У велосипеда 50 км/час");
            //            break;
            //        case 'м': Console.WriteLine("У мотоцикла 120 км/час");
            //            break;
            //        case 'с': Console.WriteLine("У самолета 500 км/час");
            //            break;
            //        case 'п': Console.WriteLine("У поезда 150 км/час");
            //            break;
            //    }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Исключение: {ex.Message}");
            //    Console.WriteLine($"Метод: {ex.TargetSite}");
            //    Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            //}

            //Task 4 
            try
            {
                Console.Write("Введите предмет: ");
                char predmet = char.Parse(Console.ReadLine());
                switch (predmet)
                {
                    case 'ф': Console.WriteLine("Физика");
                        break;
                    case 'м':
                        Console.WriteLine("Математика");
                        break;

                }
            }


            Console.ReadKey();


        }
    }
}
