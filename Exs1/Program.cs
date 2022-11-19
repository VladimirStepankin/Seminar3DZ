/*Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.*/

int number = ReadInt("Введите пятизначное число: ");

int number1 = number % 10;
int number5 = number / 10000;
int number2 = (number % 100) / 10;
int number4 = (number / 1000) - (number5 * 10);

if (number > 9999 && number < 1000000)
{
    if (number1 == number5 && number2 == number4)
        Console.WriteLine("Да");

    else
    {
        Console.WriteLine("Нет");
    }
}
else Console.Write("Введено неверное число");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}