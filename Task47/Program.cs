// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 0;
int j = 0;
            
void FillArray(int[,] matr)
 {
    for (i = 0; i < m; i++)
    {
       for (j = 0; j < n; j++) 
       {
        matr[i,j] = new Random().Next(-100,100);
        Console.Write($"{matr[i,j]} ");
       }
    Console.WriteLine();
    }
 }

string[,] matrix = new string [m,n];
int[,] matr = new int [m,n];

FillArray(matr);

