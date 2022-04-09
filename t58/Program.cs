/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. */

int[,] arrayB = {{1,2,3},
                 {4,5,6}};
int[,] arrayA = {{1,2},
                 {3,4},
                 {5,6}};
int[,] arrayResult = new int[arrayA.GetLength(0),arrayA.GetLength(0)];
for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int k = 0; k < arrayB.GetLength(1); k++) 
        {
            for (int j = 0; j < arrayA.GetLength(1); j++)
            {
                arrayResult[i,k] = arrayResult[i,k] + (arrayA[i,j] * arrayB[j,k]);
            }
        }
    }


PrintArray(arrayA, "Массив А:");
PrintArray(arrayB, "Массив B:");
PrintArray(arrayResult, "Результат:");


void PrintArray(int[,] incomingArray, string arrayName)
{
    System.Console.WriteLine($"Вывод массива '{arrayName}':");
    for (int i = 0; i < incomingArray.GetLength(0); i++)
    {
        for (int j = 0; j < incomingArray.GetLength(1); j++)
        {
            System.Console.Write(incomingArray[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine("-----------------------------");
}

