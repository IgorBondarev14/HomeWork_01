﻿// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Четные числа от 1 до ");
Console.Write(number);
Console.WriteLine(" :");
int count = 1;
while (count <= number)
{
   if (count % 2 == 0)
   {
    Console.WriteLine(count);
    count = count + 1;
   }
    else
    {
        count = count + 1;
    }
}