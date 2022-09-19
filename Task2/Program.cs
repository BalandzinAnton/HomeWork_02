// Задача 13: Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.

using static System.Console;
Clear();

WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


if (num>=100)
{
    int a3 = (num%1000-num%100)/100;
    WriteLine(a3);
}
else
{
    WriteLine($"третьей цифры нет");
}