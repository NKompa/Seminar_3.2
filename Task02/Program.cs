// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int num = new Random().Next(100,1000);
int num1 = num/100;
int num2 = num%10;
Console.WriteLine(num);
Console.Write(num1);
Console.Write(num2);
