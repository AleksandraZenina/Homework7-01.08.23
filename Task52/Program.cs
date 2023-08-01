// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
void FillArray (int [,] num2d)
{
    Random rnd = new Random();
    for (int i = 0; i < num2d.GetLength(0); i++)
    {
       for (int j = 0; j < num2d.GetLength(1); j++)
       {
           num2d [i,j]=rnd.Next(10);
           
       }
    }
}

void PrintArray (int [,] num2d)
{
    for(int i=0; i<num2d.GetLength(0); i++)
    {
        for (int j = 0; j < num2d.GetLength(1); j++)
        {
            Console.Write(num2d[i,j] + "\t");
        }
        Console.WriteLine();
    }   
}

void CountArithmetic (int [,] num2d)
{
    for (int j = 0; j < num2d.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < num2d.GetLength(0); i++)
        {
            sum += num2d[i, j];
        }
        double arth = sum/num2d.GetLength(0);
        Console.Write($"{arth:F1}; ",arth);
    }
}

void Task52()
{
    int [,] num2d = new int [3,3];
    FillArray(num2d);
    PrintArray(num2d);
    CountArithmetic(num2d);
}
Task52();