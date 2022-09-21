// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

int[,] numbers = new int[new Random().Next(2, 7), new Random().Next(2, 7)];
InputAndPrintArray(numbers);

double[] arithmeticMean = new double[numbers.GetLength(1)];
System.Console.WriteLine("Среднее арифметическое каждого столбца");
СalcAndPrintArithmeticMean(numbers);


void InputAndPrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
            System.Console.Write($"{numbers[i, j],6}");
        }
        System.Console.WriteLine();
    }
}


void СalcAndPrintArithmeticMean(int[,] numbers)
{
    double count = 0;
    for (int i = 0; i < numbers.GetLength(1); i++)
    {
        for (int j = 0; j < numbers.GetLength(0); j++)
        {
            count += numbers[j, i];
        }
        arithmeticMean[i] = count / numbers.GetLength(0);
        count = 0;
        
        System.Console.Write($"{Math.Round(arithmeticMean[i], 2),6}");
    }
}