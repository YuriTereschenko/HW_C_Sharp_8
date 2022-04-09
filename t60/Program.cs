/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. */

int GetRndNum(int[] array)
{

    int index = new Random().Next(10, 30);
    while (true)
    {
        if (array[index] == 0)
        {
            array[index] = 1;
            return index;
            break;
        }
        else
        {
            index = new Random().Next(10, 100);
        }
    }
}

int[,,] FillArray(int columns, int rows, int depth)
{
    int[] arrayOfRndNum = new int[100];
    int[,,] returnArray = new int[rows, columns, depth];
    for (int i = 0; i < returnArray.GetLength(0); i++)
    {
        for (int j = 0; j < returnArray.GetLength(1); j++)
        {
            for (int k = 0; k < returnArray.GetLength(2); k++)
            {
                returnArray[i, j, k] = GetRndNum(arrayOfRndNum);
            }
        }
    }
    return returnArray;
}


void PrintArray(int[,,] incomingArray)
{
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
            for (int k = 0; k < incomingArray.GetLength(2); k++)
            {
                System.Console.Write($" индекс [{i}, {j}, {k}] = {incomingArray[i, j, k]}\t");
            }
            System.Console.WriteLine();
        }
    }
    System.Console.WriteLine("-----------------------------");
}


int[,,] result = FillArray(2, 2, 2);
PrintArray(result);
