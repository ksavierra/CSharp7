// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

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
        matr[i,j] = new Random().Next(0,100);
        Console.Write($"{matr[i,j]} ");
       }
    Console.WriteLine();
    }
 }

void ArithmeticMean(int[,] matr)
{
            double sum = 0;
            double ArithmeticMe = 0;
             for (int j = 0; j < m; j++)
              {    
                 for (int i = 0; i < n; i++) 
                  { 
                             
                   sum += matr[i,j];
                   ArithmeticMe = sum/m;
                                                   
                  }
                  
                  Console.Write($" Среднеарифметическое столбца: {Math.Round(ArithmeticMe, 2)}");
                  Console.WriteLine();
                                                 
              }   

}
   
string[,] matrix = new string [m,n];
int[,] matr = new int [m,n];

FillArray(matr);
ArithmeticMean(matr);



