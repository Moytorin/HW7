//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.
//1 7 -2 -85
//1 -3 8 -9
//8 7 -7 9
/*
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);  // Создал массив для общего метода
PrintArray(array);  // Вывел массив общего метода

int[,] GetArray(int m, int n, int minValue, int maxValue)  // обьявили метод которыый заполняет 
{
    int[,] result = new int[m, n]; // обьявили двумерный массив 
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue); // метод для заполнения массива
        }
    }
    return result;
}
// метод для вывода двумерного массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }

}*/
/*
//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//i = 4, j = 2 -> такого числа в массиве нет
//i = 1, j = 2 -> 2

Console.WriteLine("Количество строк: ");// Предложение для ввода
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов: ");// Предложение для ввода
int colums = int.Parse(Console.ReadLine()!);
Console.WriteLine("В какой строке искать? : ");// Предложение для ввода
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("В каком столбце искать? : ");// Предложение для ввода
int b = int.Parse(Console.ReadLine()!);


int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array); // делаем вывод этого масиива

Console.WriteLine();
int[,] array1 = NewGetArray(a, b);
PrintArray(array1);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n]; // тело метода// обьвили массив двумерн. m-строки n- столбцы
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue); // метод для заполнения массива
        }
    }
    return result;
}

int[,] NewGetArray(int a, int b) // функция заполнения массива m,n - количество строк и столбцов
{
    for (int i = 0; i < array.GetLength(0); i++) // строки заполняются
    {
        for (int j = 0; j < array.GetLength(1); j++) // столбцы заполняются
        {
            if((i == a) && (j == b))
            {
                Console.WriteLine($"Ваше число: {array.GetValue(a,b)}");
                
            }
        }
    }
    return array; // возвращаем наш сформировавшийся двумерный массив
}

void PrintArray(int[,] array) // который будет работать с нашим двумер. массивом
{
    for (int i = 0; i < array.GetLength(0); i++)  // array.GetLength(0) - обращение к строкам
    {
        for (int j = 0; j < array.GetLength(1); j++)  // array.GetLength(1) - обращение к столбцам
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}*/


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Количество строк: ");// Предложение для ввода
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Количество столбцов: ");// Предложение для ввода
int colums = int.Parse(Console.ReadLine()!);


int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array); // делаем вывод этого масиива

Console.WriteLine();
int[,] array1 = NewGetArray(array);
PrintArray(array1);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n]; // тело метода// обьвили массив двумерн. m-строки n- столбцы
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue); // метод для заполнения массива
        }
    }
    return result;
}

int[,] NewGetArray(int[,] array) // функция заполнения массива m,n - количество строк и столбцов
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++) // строки заполняются
    {
        for (int j = 0; j < array.GetLength(1); j++) // столбцы заполняются
        {
            if(j <= array.GetLength(1))
            {
                sum = j + j; 
                Console.WriteLine($"{sum/array.GetLength(1)}");              
            }
        }
    }
    return array; // возвращаем наш сформировавшийся двумерный массив
}

void PrintArray(int[,] array) // который будет работать с нашим двумер. массивом
{
    for (int i = 0; i < array.GetLength(0); i++)  // array.GetLength(0) - обращение к строкам
    {
        for (int j = 0; j < array.GetLength(1); j++)  // array.GetLength(1) - обращение к столбцам
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}       