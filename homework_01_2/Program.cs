// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int number3 = Convert.ToInt32(Console.ReadLine());
Console.Write("number1 = ");
Console.WriteLine(number1);
Console.Write("number2 = ");
Console.WriteLine(number2);
Console.Write("number3 = ");
Console.WriteLine(number3);
if (number1 > number2)
{
    if (number1 > number3)
    {
       Console.Write("Число ");
        Console.Write(number1);
        Console.WriteLine(" самое больше среди представленных"); 
    }
    else
    {
        Console.Write("Число ");
        Console.Write(number3);
        Console.WriteLine(" самое больше среди представленных"); 
    }
}
else
{
    if (number2 > number3)
    {
       Console.Write("Число ");
        Console.Write(number2);
        Console.WriteLine(" самое больше среди представленных"); 
    }
    else
    {
        Console.Write("Число ");
        Console.Write(number3);
        Console.WriteLine(" самое больше среди представленных"); 
    }
}