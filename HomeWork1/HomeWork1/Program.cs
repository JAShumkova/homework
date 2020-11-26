using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число в диапазоне от 100 до 999:");

            var input = Console.ReadLine();
            int number;
            if (Int32.TryParse(input, out number))
            {
	            if (number > 99 && number < 1000)
	            {
		            int units = number % 10;
		            int dozens = (number / 10) % 10;
		            int hundreds = number / 100;

		            number = units * 100 + dozens * 10 + hundreds;

		            Console.WriteLine("Перевёрнутное число: {0}", number);
                }
	            else
	            {
		            Console.WriteLine("Введёное число не соответствует нужному диапазону!");
                }
            }
            else
            {
                Console.WriteLine("Был некорректный ввод данных!");
            }

            Console.ReadKey();
            Console.WriteLine("Пока-пока!");
        }
    }
}
