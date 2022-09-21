// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int height = EnterInt("введите высоту");
int width = EnterInt("введите ширину");
double[,] numbers = new double[height, width];

InputArray(numbers);
PrintArray(numbers);


int EnterInt(string text)
{
    System.Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

void InputArray(double[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = Math.Round(new Random().NextDouble() * 10, 1);
        }
    }
}

void PrintArray(double[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i, j],5}");
        }
        System.Console.WriteLine();
    }
}
