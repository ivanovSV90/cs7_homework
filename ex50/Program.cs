// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет. 
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


int[,] numbers = new int[new Random().Next(2, 7), new Random().Next(2, 7)];
InputArray(numbers);
PrintArray(numbers);

System.Console.WriteLine("Для вывода выбранного элемента массива");
int height = EnterInt("введите высоту ");
int width = EnterInt("введите ширину");

PrintSelectedItem(numbers, height, width);



int EnterInt(string text)
{
    System.Console.WriteLine(text);
    return int.Parse(Console.ReadLine()!);
}

void InputArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(10, 100);
        }

    }
}

void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i, j],4}");
        }
        System.Console.WriteLine();
    }
}

void PrintSelectedItem(int[,] numbers, int height, int width)
{
    if (height <= numbers.GetLength(0) && width <= numbers.GetLength(1))
        System.Console.WriteLine($"значение выбранного элемента = {numbers[height - 1, width - 1]}");
    else
        System.Console.WriteLine("такого числа в массиве нет");
}