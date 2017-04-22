using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third_Task
{
    class BubbleSorting
    {
        public void BubbleSort()
        {
            int i, j;
            int temp;
            Random r = new Random();
            int size = 20;
            int[] mas = new int[size];
                for (i = 0; i < mas.Length; i++)
                {
                    mas[i] = r.Next(0, 101);
                }

                Console.WriteLine("Перший массив - невідсортований :");
                for (i = 0; i < mas.Length; i++)
                {
                    Console.Write(mas[i]+" ");
                }
                  
            
            for (i = 0; i < size - 1; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (mas[i] > mas[j])
                    {
                         temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Відсортований :");
            for (i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
                  
        }
    }
class InsertionArray
{
      public void InsertionSort()
            {
                int i;
            Random r = new Random();
            int size = 20;
            int[] mas = new int[size];
                for (i = 0; i < mas.Length; i++)
                {
                    mas[i] = r.Next(0, 100);
                }
                Console.WriteLine();
                Console.WriteLine("Перший массив - невідсортований :");
                for (i = 0; i < mas.Length; i++)
                {
                    Console.Write(mas[i]+" ");
                }
                int a, b;
                for ( i = 1; i <  mas.Length; i++)
                {
                    a = mas[i];
                    b = i - 1;
                    while (b >= 0 && mas[b] > a)
                    {
                        mas[b + 1] = mas[b];
                        b = b - 1;
                    }
                    mas[b + 1] = a;
                }
                Console.WriteLine();
                Console.WriteLine("Відсортований :");
                for (i = 0; i < mas.Length; i++)
                {
                    Console.Write(mas[i] + " ");
                }
                  
    }
}
class Transposition
{

    public void Transpositin()
    {

        int i;
        Random r = new Random();
        int size = 20;
        int[] mas = new int[size];
        for (i = 0; i < mas.Length; i++)
        {
            mas[i] = r.Next(1, 99);
        }
        Console.WriteLine();
        Console.WriteLine("Перший массив - невідсортований :");
        for (i = 0; i < mas.Length; i++)
        {
            Console.Write(mas[i] + " ");
        }
        for (i= 1; i < mas.Length; i++)
        {
            int cur = mas[i];
            int j = i;
            while (j > 0 && cur < mas[j - 1])
            {
                mas[j] = mas[j - 1];
                j--;
            }
            mas[j] = cur;
        }
        Console.WriteLine();
        Console.WriteLine("Відсортований :");
        for (i = 0; i < mas.Length; i++)
        {
            Console.Write(mas[i] + " ");
        }
    }
}
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Сортування методом бульбашки");
            Console.WriteLine();
            Console.WriteLine();
            BubbleSorting b1 = new BubbleSorting();
                b1.BubbleSort();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Сортування методом вставки");
                
                Console.WriteLine();
                InsertionArray b2 = new InsertionArray();
                b2.InsertionSort();

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Сортування методом перестановки");

                Console.WriteLine();

                Transposition b3 = new Transposition();
                b3.Transpositin();

                Console.ReadLine();

            }

        }
    }