using System;

namespace Array
{
    class Program
    {
        static void Main()
        {
            //Просим задать длинну массива
            Console.WriteLine("Какой длинны массив вы хотите?");
            int lenght = int.Parse(Console.ReadLine());
            Console.WriteLine("--------------------");

            int[] x = new int[lenght];
            int countEven = 0;
            int countOdd = 0;
            for(int i = 0; i < x.Length; i++)
            {
                //задаем случайное число от 1 до 999
                Random Random = new Random();
                int number = Random.Next(1, 999);
                x[i] = number;
                Console.WriteLine($"{x[i]}");

                //подсчитываем колличество чётных чисел
                if(number % 2 == 0)
                    countEven++;

                //подсчитываем колличество нечётных чисел
                if(number % 2 != 0)
                    countOdd++;
            }
            //показываем колличество чётных и нечётных чисел
            Console.WriteLine("чётное число появилось " + countEven + " раз");
            Console.WriteLine("нечётное число появилось " + countOdd + " раз");
        }
    }
}
