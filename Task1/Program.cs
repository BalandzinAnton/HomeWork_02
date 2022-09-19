// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

using static System.Console;
Clear();

int number=new Random().Next(100,1000);
WriteLine(number); // a1a2a3

int a3 = number%10;
int a2 = (number%100-a3)/10;

WriteLine(a2);