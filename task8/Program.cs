using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Введите два числа от 0 до 10:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());

            if ((number1 >= 0 && number1 <= 10) && (number2 >= 0 && number2 <= 10))
            {
                Console.WriteLine($"Результат умножения: {number1 * number2}");
                break;
            }
            else
            {
                Console.WriteLine("Введенные числа недопустимы. Попробуйте снова.");
            }
        }
    }
}
