/*
    Задача 15: Напишите программу, которая принимает на вход 
цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
*/

Console.Write("Введите число : ");

int Num = Convert.ToInt32(Console.ReadLine());

if (Num%7==6 || Num%7==0) Console.WriteLine("Выходной день");
else Console.WriteLine("День рабочий");


