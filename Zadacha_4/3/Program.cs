﻿Console.Clear ();
int number1 = 22;
int number2 = 3;
int number3 = 9;
int max = 0;
if (number1 > number2)
{
    max = number1;
}
else 
{
    max = number2;
}
if (max > number3)
{
    Console.WriteLine($"Чисо {max} больше");
}
else
{
    Console.WriteLine($"Чисо {number3} больше");
}