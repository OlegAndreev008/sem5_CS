﻿// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] mass = new int[10];
int count = 0;
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(100, 1000);
    Console.Write($"{mass[i]}  ");
}
Console.WriteLine();
for (int j = 0; j < mass.Length; j++)
{
    if (mass[j] % 2 == 0)
    {
        count += 1;
    }
}
Console.Write($"Количество четных элементов в массиве равно {count}");

// Создаем произвольный массив и переменную счетчика чисел, изначально равную 0.
// Первым циклом заполняем массив трехзначными числами.
// Вторым циклом проверяем числа массива на четность. В случае выполнения условия увеличиваем переменную на 1.