// Заменить строки на столбцы в двумерном массиве


int m = 4, n = 4;
int[,] array = new int[m,n];

void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write(collection[i,j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i,j] = new Random().Next(0,10);
        }
    }
}

void Replace(int[,] collection)
{
    int memory;
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = i; j < collection.GetLength(1); j++)
        {
            memory = collection[i,j];
            collection[i,j] = collection[j,i];
            collection[j,i] = memory;
        }
    }
}

FillArray(array);
PrintArray(array);
Replace(array);
Console.WriteLine("_________________");
PrintArray(array);