// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void FillArray (double [,] num2d)
{
    Random rnd = new Random();
    for (int i = 0; i < num2d.GetLength(0); i++)
    {
       for (int j = 0; j < num2d.GetLength(1); j++)
       {
           num2d [i,j]=rnd.NextDouble();
           
       }
    }
}

void PrintArray (double [,] num2d)
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

void Task47()
{
    Console.Write("Введите число строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double [,] num2d = new double [m,n];
    FillArray(num2d);
    PrintArray(num2d);
}

Task47();

