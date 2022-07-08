// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("number1 = ");
Console.WriteLine(number1);
Console.Write("number2 = ");
Console.WriteLine(number2);
if (number1 - number2 > 0)
 {  
    Console.Write("Число ");
    Console.Write(number1);
    Console.WriteLine(" больше");
 }
else
{
   if (number1 - number2 < 0)
    {   
        Console.Write("Число ");
        Console.Write(number2);
        Console.WriteLine(" больше");
    }
   else
        Console.WriteLine("Числа одинаковые");
}

