/*
    Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
*/
Console.WriteLine("Введите число :");
int num = Convert.ToInt16(Console.ReadLine());

// int o = num /100;


Console.WriteLine(num/10-num/100*10);


