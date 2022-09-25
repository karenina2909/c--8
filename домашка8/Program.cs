// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int [,] CreateRandom2dArray()
{
    Console.Write("введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите миним возможное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите максим возможное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int [,]newArray = new int[rows,columns];

    for (int i=0; i<rows; i++)
        for (int j=0; j<columns; j++)
            newArray[i,j]= new Random().Next(minValue,maxValue+1);
    return newArray;
}

void Show2dArray(int[,]array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
            Console.Write(array[i,j]+" ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,]myArray = CreateRandom2dArray();
Show2dArray(myArray);

/*
void SelectionSort(int[,]array)
{
for (int a=0; a<array.GetLength(0); a++)
   for (int i=0; i<array.GetLength(1)-1; i++)
   {
    int maxPos =i;
    for (int j=i+1; j<array.GetLength(1); j++)
    {
        if (array[a,j]> array[a,maxPos])
        {
            maxPos=j;
        }
    }
    int temp = array[a,i];
    array[a,i] = array[a,maxPos];
    array[a,maxPos]= temp;
   } 
}
SelectionSort(myArray);
Show2dArray(myArray);
*/
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
 //с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
/*
int MinSum (int [,]array)
{
    int [] array1=new int [array.GetLength(0)];
    for (int i=0; i<array.GetLength(0); i++)
   {
    int sum=0;
    for (int j=0; j<array.GetLength(1); j++)
    {
        sum = sum+array[i,j];
    }
    array1[i]=sum;
    Console.WriteLine(array1[i]);
   }
   int minCol = 0;
   for (int k=1; k<array1.Length; k++)
   { 
    if (array1[k]<array1[minCol])
    {
        minCol = k;
    }
   }
return minCol;
}
Console.WriteLine($"минимальная сумма {MinSum(myArray)+1} строка");
*/
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int [,] Res (int [,]a, int [,]b)
{
    int [,] ab=new int [a.GetLength(0),b.GetLength(1)];
    if (a.GetLength(1) != b.GetLength(0)) 
    Console.WriteLine("Матрицы нельзя перемножить");
      else{
      for (int i = 0; i < a.GetLength(0); i++)
     {
         for (int j = 0; j < b.GetLength(1); j++)
          {
             for (int k = 0; k < b.GetLength(0); k++)
                {
                  ab[i,j] += a[i,k] * b[k,j];
                }
           }
     }
    }
    return ab;

}
int[,]myArray2 = CreateRandom2dArray();
Show2dArray(myArray2);
int[,]myArray3 = Res(myArray, myArray2);
Show2dArray(myArray3);


//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
/*
int [, ,] CreateRandom3dArray()
{
    Console.Write("введите количество строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите количество столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите количество станиц: ");
    int page = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите миним возможное двузначное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите максим возможное двузначное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int [, ,]newArray = new int[rows,columns,page];

    for (int i=0; i<rows; i++)
        for (int j=0; j<columns; j++)
            for (int n=0; n<page; n++)
            newArray[i,j,n]= new Random().Next(minValue,maxValue+1);
    return newArray;
}

void Show3dArray(int[, ,]array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
             for (int n=0; n<array.GetLength(2); n++)
                Console.Write(array[i,j,n]+ $"{(i,j,n)}"+" ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[, ,]myArray = CreateRandom3dArray();
Show3dArray(myArray);
*/
//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07
/*
int [,] CreateRandomArray()
{
    Console.Write("введите i: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("введите j: ");
    int columns = Convert.ToInt32(Console.ReadLine());
     
    int [, ]Array = new int[rows,columns];
int m =1;
while (m>=rows*columns)
{
    for (int i=0; i<rows; i++)
    {
        if (i==0)
        {
            for (int j=0; j<columns; j++)
            { int n = m;
               Array[i,j]=n;
                n++;
            }
            m=n ;
        }
        if (i>=1 & i<rows-1)
        {
                for (int n=columns+1; n<columns+rows; n++)
                {
                    Array[i,columns]=n;
                    Array[i,]
                }
         }

        

    }
        for (int j=0; j<columns; j++)
            


            newArray[i,j]= ;
    return newArray;
}

void Show3dArray(int[, ,]array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
             for (int n=1; n<; n++)
                Console.Write(array[i,j,n]+ $"{(i,j,n)}"+" ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[, ,]myArray = CreateRandom3dArray();
Show3dArray(myArray);
*/
