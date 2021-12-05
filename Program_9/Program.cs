using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!Супер-пупер калькулятор!");

            Console.WriteLine();
            try
            {
                Console.Write("Введите целое число X: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число Y: ");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("    1 - Сложение");
                Console.WriteLine("    2 - Вычитание");
                Console.WriteLine("    3 - Произведение");
                Console.WriteLine("    4 - Частное");

                Console.WriteLine();

                Console.Write("Ваш выбор: ");

                int oper = Convert.ToInt32(Console.ReadLine());
                int result = 0;
                

                if (oper == 1) result = x + y;
                else if (oper == 2) result = x - y;
                else if (oper == 3) result = x * y;
                else if (oper == 4) result = x / y;
                else if (oper >4) throw new ArgumentOutOfRangeException ();


                Console.Write("Результат: ");
                Console.WriteLine(result);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Нет операции с указанным номером!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено недопустимое значение");               
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль!");
            }          

            Console.ReadKey();
        }
    }
}
//1.    Смоделируйте работу простого калькулятора.
//Программа должна запрашивать 2 числа, а затем – код операции (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное).
//После этого на консоль выводится ответ. Используйте обработку исключений для защиты от ввода некорректных данных.
