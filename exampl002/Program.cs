﻿//Задача 4: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите в столбик три числа:");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB > max)
{
    max = numberB;
}

if (numberC > max)
{
    max = numberC;
}

Console.WriteLine("Наибольшее из введённых чисел -> " + max);