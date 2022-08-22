// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)
{
    Console.WriteLine("Число 1 является квадратом числа 2.");
}
else if (num2 == num1 * num1)
{
    Console.WriteLine("Число 2 является квадратом числа 1.");
}
else
{
    Console.WriteLine("Числа не являются квадратами.");
}