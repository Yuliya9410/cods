// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Console.WriteLine("Введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Массив до изменения");
PrintArray(numbers);

for(int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1) - 1; j++)
    {
        for(int z = 0; z < numbers.GetLength(1) - 1; z++)
        {
            if(numbers[i,z] < numbers [i, z + 1])
            {
                int temp = 0;
                temp = numbers[i,z];
                numbers[i,z] = numbers[i, z + 1];
                numbers[i, z + 1] = temp;

            }
        }

    }
}

Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями");
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");

        }
        Console.Write("]");
        Console.WriteLine(" ");
    }
}
*/
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
Console.WriteLine("Введите размер массива m x n и диапазон случайных значений");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for(int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(array,i);
    if(sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

Console.WriteLine($"\n{minSumLine+1} - строка с наименьшей суммой({sumLine}) элементов");

int SumLineElements(int[,] array, int i)
{
    int sumLine = array [i,0];
    for(int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i,j];
    }
    return sumLine;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
}
*/
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
Console.WriteLine("Введите размеры матриц и диапазон случайных значений: ");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы ( и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до  ");

int[,] firstMartrix =  new int [m, n];
CreateArray(firstMartrix);
Console.WriteLine($"Первая матрица: ");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[n,p];
CreateArray(secomdMartrix);
Console.WriteLine($"Вторая матрица: ");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($" Произведение первой и второй матриц: ");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMatrix, int[,] secomdMatrix, int[,] resultMatrix)
{
    for(int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0; 
            for(int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i,k] * secomdMartrix[k,j];
            }
        resultMatrix[i,j] = sum;
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
}
*/
// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4;
int[,] sqareMatrix = new int[n,n];

int temp = 1;
int i = 0; 
int j = 0;

while(temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
    sqareMatrix[i,j] = temp;
    temp++;
    if(i <= j + 1 &&  i + j < sqareMatrix.GetLength(1) -1)
    j++;
    else if(i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
    else if(i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
    else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] / 10 <= 0)
            Console.Write($" {array[i,j]} ");
            
            else Console.Write($"{array[i,j]}");
        }
    Console.WriteLine();
    }
}