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
            Console.WriteLine("пример первый");
            
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
