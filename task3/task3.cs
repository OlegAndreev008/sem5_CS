// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] mass = new double[10];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().NextDouble();
    Console.Write($"{mass[i]:F2}  ");
}
Console.WriteLine();
double maxValue = mass.Max();
double minValue = mass.Min();
// Console.WriteLine($"{maxValue:F2}");
// Console.WriteLine($"{minValue:F2}");
double result = maxValue - minValue;
Console.WriteLine($"Разница между макс и мин элементами массива равна {result:F2}");

//Не знаю, почему числа в массиве до единицы, знаний не хватает сделать нормально ((
//Задали массив веществ. чисел, нашли макс, мин значения и их разность в переменной result.