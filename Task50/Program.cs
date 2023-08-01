// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
void FillArray (int [,] num2d)
{
    Random rnd = new Random();
    for (int i = 0; i < num2d.GetLength(0); i++)
    {
       for (int j = 0; j < num2d.GetLength(1); j++)
       {
           num2d [i,j]=rnd.Next(100);
           
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

void FindElement (int[,] num2d, int rows, int colums)
{
    
    if (rows < num2d.GetLength(0) && colums < num2d.GetLength(1)) 
    {
        Console.WriteLine(num2d[rows, colums]);
    }
    
    else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");
}

void Task50()
{
    
    int [,] num2d = new int [5,5];
    FillArray(num2d);
    PrintArray(num2d);
    Console.Write("Введите индекс строки: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите индекс столбца: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    FindElement(num2d, rows, colums);    
}
Task50();