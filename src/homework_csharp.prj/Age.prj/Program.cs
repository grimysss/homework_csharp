using System;

namespace Age
{
	class Program
	{
		static void Main(string[] args)
		{
			//Просим ввести возраст
			Console.WriteLine("Сколько вам лет?");
			int age = int.Parse(Console.ReadLine());
			//Проверям возраст для выбора слова
			if(age % 10 == 0 & age > 0 & age < 99)
			{
				Console.WriteLine("Вам " + age + " лет");
			}
			else if(age >= 11 & age <= 19)
			{
				Console.WriteLine("Вам " + age + " лет");
			}
			else if(age % 10 == 1 & age > 0 & age < 99)
			{
				Console.WriteLine("Вам " + age + " год");
			}
			else if(age % 10 == 2 & age > 0 & age < 99)
			{
				Console.WriteLine("Вам " + age + " года");
			}
			else if(age % 10 == 3 & age > 0 & age < 99)
			{
				Console.WriteLine("Вам " + age + " года");
			}
			else if(age % 10 == 4 & age > 0 & age < 99)
			{
				Console.WriteLine("Вам " + age + " года");
			}
			//Выдаем ошибку, если возраст слишком маленький
			else if(age < 0)
			{
				Console.WriteLine("Ошибка, вас еще нет");
			}
			//Выдаем ошибку, если возраст слишком большой
			else if(age > 99)
			{
				Console.WriteLine("Ошибка, вам нужно прилечь");
			}
			//во всех других случаях пишем обычно слово "лет"
			else
			{
				Console.WriteLine("Вам " + age + " лет");
			}
		}
	}
}
