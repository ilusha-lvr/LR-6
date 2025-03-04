﻿namespace ConsoleApp1
{
	internal class Program
	{
		static void Main()
		{
			while (true)
			{
				Console.WriteLine("Введите выражение (например, 2 + 2):");
				string input = Console.ReadLine();
				if (input.ToLower() == "exit")
				{
					Console.WriteLine("Выход из программы.");
					break;
				}
			
				string[] elements = input.Split(' ');
				if (elements.Length != 3)
				{
					Console.WriteLine("Неверный формат ввода.");
					continue;
				}

				double operand1, operand2;
				if (!double.TryParse(elements[0], out operand1) || !double.TryParse(elements[2], out operand2))
				{
					Console.WriteLine("Ошибка при разборе чисел.");
					continue;
				}

				char operation = char.Parse(elements[1]);

				// Выполняем операцию
				double result = 0;
				switch (operation)
				{
					case '+':
						result = operand1 + operand2;
						break;
					case '-':
						result = operand1 - operand2;
						break;
					case '*':
						result = operand1 * operand2;
						break;
					case '/':
						if (operand2 != 0)
							result = operand1 / operand2;
						else
							Console.WriteLine("Деление на ноль невозможно.");
						break;
					default:
						Console.WriteLine("Неизвестная операция.");
						continue;
				}

				Console.WriteLine("Результат: " + result);
			}
		}
	}
}