// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

using static System.Console;
Clear();

WriteLine("Введите цифру: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num>7 || num<1)
{
    WriteLine("Нет такого дня недели");
    return;
}

if (num==6 || num==7)
{
    WriteLine("Выходной!");
    return;
}
if (num>0 || num<6)
{
    WriteLine("Будний день");

}
