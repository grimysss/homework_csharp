using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Просим ввести сторону треугольника
            Console.WriteLine("Введите сторону треугольника");
            int x = int.Parse(Console.ReadLine());
            //Проверяем чётность стороны
            if(x % 2 == 0)
            {
                //Строим треугольник с заданной стороной
                for(int i = 1; i <= x; i++)
                {
                    for(int j = 1; j <= x - i; j++)

                        Console.Write(' ');


                    for(int k = 1; k <= 2 * i - 1; k++)
                        Console.Write('*');
                    Console.WriteLine();
                }
            }
            else
            {
                //Выдаем ошибку, если сторона треугольника нечётная
                Console.WriteLine("Ошибка, сторона должна быть чётной");
            }
        }
    }
}