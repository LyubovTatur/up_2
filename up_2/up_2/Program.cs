using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace up_2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Задание 1.");
            MatrixAndArrayFuncs.ShowArray(MatrixAndArrayFuncs.Func1(3, 6));

            Console.WriteLine("Задание 2.");

            var mas = MatrixAndArrayFuncs.RandomArray(3, 4);
            MatrixAndArrayFuncs.ShowArray(mas);
            Console.Write("ответ ");
            Console.WriteLine(MatrixAndArrayFuncs.Func2(mas));
            Console.WriteLine("Задание 3.");
            int[] mas2 = new int[] { 3, 5, 7, 2, 4, 6, -5, -6 };
            MatrixAndArrayFuncs.ShowArray(mas2);
            MatrixAndArrayFuncs.Func3(mas2, 2);
            MatrixAndArrayFuncs.ShowArray(mas2);

            Console.WriteLine("Задание 4.");
            int[][] mas3 = new int[][] { new int[] { 0, 0, 0 },
                                         new int[] { 0, 0, 0 }, 
                                         new int[] { 0, 0, 1 } };
            MatrixAndArrayFuncs.ShowArray(mas3);
            Console.WriteLine("_____________");
            MatrixAndArrayFuncs.Func4(mas3);
            MatrixAndArrayFuncs.ShowArray(mas3);

            Console.WriteLine("Задание 5.");
            Console.WriteLine("пример первый");
            // рисунки есть в папке где то с этими матрицами
            int[][] a = new int[6][];
            a[0] = new int[] {1,1,1,100,100,1,1 };
            a[1] = new int[] {1,100,1,1,1,1 };
            a[2] = new int[] {1 };
            a[3] = new int[] {1,1,1,1,100 };
            a[4] = new int[] {100,100,1,100 };
            a[5] = new int[] { 1,1,1};
            Console.WriteLine(MatrixAndArrayFuncs.Func5(a));

            Console.WriteLine("пример посложнее");
            int[][] b = new int[8][];
            b[0] = new int[] { 10,1};
            b[1] = new int[] { 10,1,1,1,10,10,10,10};
            b[2] = new int[] {10,10,10,1 };
            b[3] = new int[] { 10,10,10,1,1,1,1,1};
            b[4] = new int[] {1,1,1,6,100,100,100,1 };//
            b[5] = new int[] { 1,10,1,1,1,1,10,1};
            b[6] = new int[] { 1,10,10,10,10,1,10,1};
            b[7] = new int[] { 1,10,10,10,10,1,1,1};
            Console.WriteLine(MatrixAndArrayFuncs.Func5(b));

            Console.ReadLine();

        }
    }
}
