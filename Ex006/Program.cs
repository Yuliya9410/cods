// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите числа: ");
string numbers = Console.ReadLine();

string[] newNumbers = new string[numbers.Length];
int k = 0;
for(int i = 0; i < newNumbers.Length; i++)
{
    if (numbers[i] == ',')
    {
        k++;
    }
    else
    {
         newNumbers[k] = newNumbers[k] + $"{numbers[i]}";
    }
}
k++;
int[] resultNumbers = new int[k];
PrintArray(resultNumbers, newNumbers);
int sum = 0;
for(int i = 0; i < k; i++)
{
    if(resultNumbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine("Количество чисел больше 0: " + sum);

void PrintArray(int[] array, string[] string1)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(string1);
        Console.Write(array[i] + " ");
    }
Console.WriteLine();
}

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[,] coeff = new double[2,2];
double[] crossPoint = new double[2];

void InputCoefficients()
{
    for(int i = 0; i < coeff.GetLength(0); i++)
    {
        Console.Write($"Введите коэффициенты {i + 1} - го уравнения(y = k * x + b):\n");
        for(int j = 0; j < coeff.GetLength(1); j++)
        {
            if(j==0) Console.Write($"Введите коэффициент k: ");
            else Console.Write($"Введите коэффициент b: ");
            coeff[i,j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Decision(double[,] coeff)
{
    crossPoint[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);
    crossPoint[1] = crossPoint[0] * coeff[0,0] + coeff[0,1];
    return crossPoint;
}

void OutputResponse(double[,] coeff)
{
    if(coeff[0,0] == coeff[1,0] && coeff[0,1] == coeff[1,1])
    {
        Console.Write($"\nПрямые совпадают");
    }
            else if(coeff[0,0] == coeff[1,0] && coeff[0,1] != coeff[1,1])
        {
            Console.Write($"\nПрямые параллельны");
        }
            else
            {
                Decision(coeff);
                Console.Write($"\nТочка пересечения прямых:({crossPoint[0]}, {crossPoint[1]})");
            }
}

InputCoefficients();
OutputResponse(coeff);