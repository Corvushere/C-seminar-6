//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.



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
            Console.WriteLine("Количество элементов больше нуля: {0}", x);



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


