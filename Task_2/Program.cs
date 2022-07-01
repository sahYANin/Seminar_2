/*
    Задача 13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, что третьей цифры нет.
*/
Console.WriteLine("Введите число :");
int num = Convert.ToInt32(Console.ReadLine());
int n = num;
int i = 0;

while (n > 0)
{
    i++;
    n /= 10;
}
//Console.WriteLine(i);

if (i == 2) Console.WriteLine("Нету третий цифры");

if (i >= 3)
{
    // Console.WriteLine(num);
    // Console.WriteLine(i);
    while (i >= 4)
    {
        num = num / 10;
        i--;
    }
    num = num % 10;

    Console.WriteLine(num);
}






/*

using System;
 
class Program {
 public static int Main() {
  Console.Write("Введите число : ");
  int num=int.Parse(Console.ReadLine());
  int i=0;
  while(num>0) {
   i++;
   num/=10;
  }
  Console.WriteLine("Количество цифр введенного числа : {0}", i);
  Console.ReadKey();
  return 0;
 }
}

*/
