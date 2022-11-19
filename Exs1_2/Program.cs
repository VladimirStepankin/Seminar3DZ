/*Напишите программу, которая принимает на вход пятизначное число
и проверяет, является ли оно палиндромом.*/

int number = ReadInt("Введите пятизначное число: ");

int temp = number;
int revers = 0;
int i = 0;
if (number > 9999 && number < 1000000)
{
    while (number > 0)
    {
        i = number % 10;
        revers = revers * 10 + i;
        number = number / 10;
    }
    if (temp == revers)
    {
        Console.WriteLine("Да");
    }
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