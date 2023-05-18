using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_R_practice_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задания от 1 до 9");
            Console.WriteLine("Задание_1:Пользователь вводит чисто пол-отр");
            Console.WriteLine("Задание_2:Пользователь вводит 3 разных числа");
            Console.WriteLine("Задание_3:Вывод положительных чисел");
            Console.WriteLine("Задание_4:Удвоить значение х если х > 10");
            Console.WriteLine("Задание_5:Вывести день недели");
            Console.WriteLine("Задание_6:Число которое делится нацело на 17");
            Console.WriteLine("Задание_7:Увеличивает пробег на 5%");
            Console.WriteLine("Задание_8:Нужно найти число факториала");
            Console.WriteLine("Задание_9:Натуральное число, найти наименьший");

            double practice = double.Parse(Console.ReadLine());
            switch (practice)
            {
                //Задание_1
                case 1:
                    Console.Write("Введите любое число: ");
                    double num = double.Parse(Console.ReadLine());
                    if (num > 0)
                        num += 5;
                    else
                        num -= 5;

                    Console.WriteLine($"Итог: {num}");
                    break;

                //Задание_2
                case 2:
                    Console.Write("Введите первое число: ");
                    double a= double.Parse(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double aa = double.Parse(Console.ReadLine());
                    Console.Write("Введите третье число: ");
                    double aaa = double.Parse(Console.ReadLine());

                    if (a >= aa && a >= aaa) //
                    
                        Console.WriteLine($"Максимальное число: {a}");
                  
                    else if (aa >= a && aa >= aaa)
                    
                        Console.WriteLine($"Максимально число{aa}"); //=)
                    
                    else
                    
                        Console.WriteLine($"Максимальное число: {aaa}");
                    
                    break;

                //Задание_3
                case 3:
                    double sam = 0; // Переменная для хранения суммы положительных чисел

                    Console.Write("Введите первое число: ");
                    double n = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    double nu = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите третье число: ");
                    double numm = Convert.ToInt32(Console.ReadLine());

                    if (n > 0)
                        sam += n;  

                    if (nu > 0)                   
                        sam += nu;             

                    if (numm > 0)                 
                        sam += numm;
                    

                    Console.WriteLine($"Сумма положительных чисел: {sam}");                              
                    break;

                //Задание_4
                case 4:
                    Console.Write("Введите число: ");
                    int x = Convert.ToInt32(Console.ReadLine());

                    if (x > 10)
                    {
                        x *= 2;
                    }
                    Console.WriteLine($"Результат: {x}");
                    break;

                //Задание_5
                case 5:
                    Console.WriteLine("Введите число от 1 до 7: ");
                    double dayZ = Convert.ToInt32(Console.ReadLine());

                    string[] weekdays = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };

                    if (dayZ >= 1 && dayZ <= 7) // Условие 
                    {
                        Console.WriteLine(weekdays[(int)(dayZ - 1)]);
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели неправильное число");
                    }
                    break;

                //Задание_6
                case 6:
                   double numbe = 4913;

                    while (numbe % 17 != 0)
                    {
                        numbe++; //Значение цикла переменной увеличивается на 1
                    }
                    Console.WriteLine($"Число которое делится нацело на 17 это: {numbe}");
                    break;

                //Задание_7
                case 7:
                    double distante = 10; // начальная дистанция
                    double day = 1; 

                    while (distante < 100)
                    {
                        distante += distante * 0.05; // увеличиваем дистанцию на 5%
                        day++; 

                        if (distante >= 20) 
                        {
                            Console.WriteLine($"На {day}-й день пробежит 20 км");
                        }
                    }
                    Console.WriteLine($"Суммарный пробег больше 100 км на {day}-й день");
                    break;

                //Задание_8
                case 8:
                    Console.WriteLine("Введите число для нахождения факториалаааааа:");
                    double number = double.Parse(Console.ReadLine());
                   double fack = 1;

                    for (double i = 1; i <= number; i++) //Факториал
                    {
                        fack *= i;
                    }

                    Console.WriteLine($"Факториал числа {number} равен {fack}");
                    break;

                //Задание_9
                case 9:
                    Console.Write("Введите натуральное число: ");
                    double nig = double.Parse(Console.ReadLine());// преобразуем его (Parse типо) в целочисленное значение

                    for (double i = 2; i <= nig; i++)//
                    {
                        if (nig % i == 0) //Проверка делится ли число
                        {
                            Console.WriteLine("Наименьший делитель отличный от 1 для числа {0}: {1}", nig, i);                           
                        }
                    }
                    break;
            }
            Console.WriteLine("0_o Спасибо за уделенное время o_0");
            Console.ReadKey();
        }
    }
}
