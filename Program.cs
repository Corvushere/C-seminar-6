//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int m;
m = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[m];
            int x = 0;
            void vvod(){
            Console.WriteLine("Исходный массив");
            for (int i = 0; i <m; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("{0} ", arr[i]);}}
            void even(){
                foreach(int element in arr)
            {
                
                if (element % 2 == 0)
                {x++;
                    }}}
            rand();
            even();
            Console.WriteLine();
            Console.WriteLine("Количество четных элементов {0}", x);