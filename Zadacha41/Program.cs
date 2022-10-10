// Zadacha 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Сколько чисел требуется ввести?");
int countofNumbers = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < countofNumbers; i++)
{
	Console.WriteLine($"Введите {i+1} число");
	int inputNumber = Convert.ToInt32(Console.ReadLine());
	if (inputNumber>0) count++;
}
Console.WriteLine("Положительных чисел введено - " + count);