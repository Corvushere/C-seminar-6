//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


/*
int m; 
Console.WriteLine("введите размер массива");
m = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[m];
            int x = 0;
            void vvod(){
            for (int i = 0; i <m; i++)
            {
                Console.WriteLine("Введите " + (i+1) + " элемент массива.");
                arr[i] = Convert.ToInt32(Console.ReadLine());
                }}
                void pol(){
                foreach(int element in arr)
            {
                
                if (element > 0)
                {x++;
                    }}}
            vvod();
            pol();
            Console.WriteLine();
            Console.WriteLine("Количество элементов больше нуля: {0}", x);*/



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


/*
double x, y, k1, k2, b1, b2; 
void vvod(){
Console.WriteLine("введите параметр b1");
b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите параметр k1");
k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите параметр b2");
b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите параметр k2");
k2 = Convert.ToDouble(Console.ReadLine());}
void xy(){
x = (b2-b1)/(k1-k2);
y = k1*(b2-b1)/(k1-k2) + b1;}
vvod();
xy();
Console.WriteLine("Точка пересечения прямых [" + x + "," + y + "]");
*/
// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1




/*
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[rows,cols ];
FillArray(array);
PrintArray(array);


void FillArray(int[,] array)
{
for (int i=0;i<array.GetLength(0);i++)
for (int j=0;j<array.GetLength(1);j++)
array[i,j] = new Random().Next(-10,11);
}

void PrintArray(int[,] array)
{
for (int i=0;i<array.GetLength(0);i++)
{
for (int j=0;j<array.GetLength(1);j++)
Console.Write($"{array[i,j],3} \t");
Console.WriteLine();
}
}*/



/*
Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

/*
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[rows,cols ];
FillArray(array);
PrintArray(array);


void FillArray(int[,] array)
{
for (int i=0;i<array.GetLength(0);i++)
for (int j=0;j<array.GetLength(1);j++)
array[i,j] = i+j;
}

void PrintArray(int[,] array)
{
for (int i=0;i<array.GetLength(0);i++)
{
for (int j=0;j<array.GetLength(1);j++)
Console.Write($"{array[i,j],3} \t");
Console.WriteLine();
}}

*/

/*
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
__________
1 4 7 2
5 81 2 9
8 4 2 4
*/



Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[rows,cols ];
FillArray(array);
PrintArray(array);
ChangeArray(array);
PrintArrayChange(array);


void FillArray(int[,] array)
{
for (int i=0;i<array.GetLength(0);i++)
for (int j=0;j<array.GetLength(1);j++)
array[i,j] = i+j;
}
void PrintArray(int[,] array)
{
for (int i=0;i<array.GetLength(0);i++)
{
for (int j=0;j<array.GetLength(1);j++)
Console.Write($"{array[i,j],3} \t");
Console.WriteLine();}
Console.WriteLine("----------------------------------------------------------------------------");}

void ChangeArray(int[,] array)
{
for (int i=0;i<array.GetLength(0);i++)
for (int j=0;j<array.GetLength(1);j++)
if (i % 2!=0 && j % 2!=0) {
array[i,j] = array[i,j] * array[i,j];    
}
else array[i,j] = array[i,j];
}

void PrintArrayChange(int[,] array)
{
for (int i=0;i<array.GetLength(0);i++)
{
for (int j=0;j<array.GetLength(1);j++)
Console.Write($"{array[i,j],3} \t");
Console.WriteLine();
}}