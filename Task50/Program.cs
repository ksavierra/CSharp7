// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

   Console.Write("Введите число для проверки: ");
   int number = Convert.ToInt32(Console.ReadLine());

   bool flag = false;

   void SearchNumber(int[,] matr)
   {
      for (i = 0; i < m; i++)
      {
         for (j = 0; j < n; j++) 
         {
            if (matr[i,j] == number) 
               {
                  Console.WriteLine("Введенное Вами число есть в массиве" + number);
                  flag = true;
               }
         }
            if (flag == false)
               {
                 Console.WriteLine("Введенное Вами число отсутствует в данном массиве");
                 return;
               }
               Console.ReadKey();
      }  
   }    

int[,] matr = new int [m,n];

FillArray(matr);
SearchNumber(matr);

