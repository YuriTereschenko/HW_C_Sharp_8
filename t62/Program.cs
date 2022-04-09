//Задача 62: Заполните спирально массив 4 на 4.

void PrintArray(int[,] incomingArray, string arrayName)
{
    System.Console.WriteLine($"Вывод массива '{arrayName}':");
    for (int j = 0; j < incomingArray.GetLength(1); j++)
    {
        for (int i = 0; i < incomingArray.GetLength(0); i++)
        {
            System.Console.Write(incomingArray[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine("-----------------------------");
}

int[,] SpiralFilling(int[,] array)
{    
    int corX = 0;
    int corY = 0;
    int count = 1;
    array[0, 0] = 1;
    while (count < (array.GetLength(0) * array.GetLength(1)))
    {
        while (corX + 1 < array.GetLength(0) && array[corX + 1, corY] == 0) //вправо
        {
            corX++;
            count++;
            array[corX, corY] = count;
        }

        while (corY + 1 < array.GetLength(1) && array[corX, corY + 1] == 0) //вниз
        {
            corY++;
            count++;
            array[corX, corY] = count;
        }        

        while (corX > 0 && array[corX - 1, corY] == 0) // влево
        {
            corX--;
            count++;
            array[corX, corY] = count;
        }

        while (corY > 0 && array[corX, corY - 1] == 0) //вверх
        {
            corY--;
            count++;
            array[corX, corY] = count;
        }
    }
    return array;
}


int[,] array = new int[4, 4];
PrintArray(SpiralFilling(array), "Заполненный массив");