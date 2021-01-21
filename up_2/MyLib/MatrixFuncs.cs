using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;

namespace MyLib
{/// <summary>
/// матрикс артемикс
/// </summary>
    public static class MatrixAndArrayFuncs
    {
        static public int[][] Func1(int m, int n)
        {
            int[][] result = new int[m][];
            for (int i = 0; i < m; i++)
            {
                result[i] = new int[n];
                for (int j = 0; j < n; j++)
                {
                    result[i][j] = 10 * i;
                }
            }
            return result;
        }
        static public int Func2(int[][] matrix)
        {
            int num = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int positive = 0, negative = 0;
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i][j]>0)
                    {
                        positive++;
                    }
                    if (matrix[i][j]<0)
                    {
                        negative++;
                    }
                    if (positive!=0 && negative!=0 && negative==positive)
                    {
                        num = i;
                    }
                }
            }
            return num;
        }
        static public void Func3(int[] a, int k)
        {
            if (k > 0 && k < a.Length)
            {
                int num = a[k - 1] * 2;
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] += num;
                }
            }
        }
        static public void Func4(int[][] matrix)
        {
            int[][] duplicate = matrix;
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // иду по матрице (ij)
                    Dictionary<pos, int> dict = new Dictionary<pos, int>();
                    int minDist = 0;

                    for (int p = 0; p < n; p++)
                    {
                        for (int q = 0; q < n; q++)
                        {
                            
                            // иду по проверочке (pq) 
                            if (matrix[p][q]!=0)
                            {
                                dict.Add(new pos(p, q), Distance(i, j, p, q));
                                if (Distance(i, j, p, q)<minDist)
                                {
                                    minDist = Distance(i, j, p, q);
                                }
                            }
                            
                        }
                    }

                    int amount = 0;
                    // ищу ненулевое и их количество (>1 => оставляю)
                    pos keyToReplace = new pos();
                    foreach (var item in dict)
                    {
                        if (item.Value == minDist)
                        {
                            amount++;
                            keyToReplace = item.Key;
                        }
                    }
                    if (amount == 1)
                    {
                        matrix[i][j] = duplicate[keyToReplace.i][keyToReplace.j];
                    }
                    // ищу ближайшее из них

                }
            }
        }
        /// <summary>
        /// хихихи
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        static public string Func5(int [][] matrix)
        {

            //____________________________первая попытка______________________________________________________________
            //Graph graph = new Graph();
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    graph.AddVertex(Coord(i, 0));

            //    for (int j = 1; j < matrix[i].Length; j++)
            //    {
            //        graph.AddEdge(Coord(i, j - 1), Coord(i,j),matrix[i][j]);
            //        graph.AddVertex(Coord(i,j));

            //    } 
            //    graph.AddVertex("[левый верхний угол]");
            //    graph.AddEdge(Coord(i, matrix[i].Length-1), "[левый верхний угол]" , matrix[i].Length - 1);

            //}
            //for (int i = 1; i < matrix.GetLength(0); i++)
            //{
            //    graph.AddVertex(Coord(i, 0));
            //    graph.AddEdge(Coord(i - 1, 0), Coord(i, 0), matrix[i][0]);
            //    for (int j = 0; j < matrix[i].Length; j++)
            //    {
            //        graph.AddVertex(Coord(i, j));
            //        graph.AddEdge(Coord(i, j-1), Coord(i, j), matrix[i][j]);
            //        if (j<matrix[i-1].Length)
            //        {
            //            graph.AddEdge(Coord(i-1, j), Coord(i, j), matrix[i][j]);
            //        }
            //    }

            //}
            //Dijkstra dijkstra = new Dijkstra(graph);
            //return dijkstra.FindShortestPath("[левый верхний угол]", Coord(matrix[matrix.GetLength(0) - 1].Length, 0));
            //__________________________________________________________________________________________


            // //___вторая попытка
            //Graph graph = new Graph();

            //graph.AddVertex(Coord(0, 0));//добавляю самый первый элемент
            //for (int j = 1; j < matrix[0].Length; j++)//иду по столбцам первой строки
            //{
            //    graph.AddVertex(Coord(0, j));
            //    graph.AddEdge(Coord(0, j - 1), Coord(0, j), matrix[0][j]);//заполняю первую строку и соединяю между собой

            //}
            //graph.AddVertex("[левый верхний угол]");// добавляю стартовую точку
            //graph.AddEdge(Coord(0, matrix[0].Length - 1), "[левый верхний угол]", matrix[0][matrix[0].Length - 1]);

            //for (int i = 1; i < matrix.GetLength(0); i++)//иду по строкам
            //{
            //    graph.AddVertex(Coord(i, 0));//сначала добавляю первый элемент в строке и соединяю с первым элементом предыдущей строки
            //    graph.AddEdge(Coord(i - 1, 0), Coord(i, 0), matrix[i][0]);
            //    for (int j = 0; j < matrix[i].Length; j++)
            //    {

            //        graph.AddVertex(Coord(i, j));// потом создаю вершины и связь по строке и с предыдущей
            //        graph.AddEdge(Coord(i, j - 1), Coord(i, j), matrix[i][j]);
            //        if (j < matrix[i - 1].Length)
            //        {
            //            graph.AddEdge(Coord(i - 1, j), Coord(i, j), matrix[i][j]);
            //        }
            //    }


            //}
            //graph.AddVertex("[нижний правый угол]");// добавляю стартовую точку
            //graph.AddEdge("[нижний правый угол]", Coord(matrix.GetLength(0) - 1, 0), matrix[matrix.GetLength(0) - 1][0]);





            //////_______________

            ////for (int i = 0; i < graph.Vertices.Count; i++)
            ////{
            ////    Console.WriteLine(graph.Vertices[i].Name);
            ////}

            //////_______________

            //Dijkstra dijkstra = new Dijkstra(graph);
            //// return dijkstra.FindShortestPath("[левый верхний угол]", Coord(matrix.GetLength(0) - 1, 0));
            //return dijkstra.FindShortestPath("[нижний правый угол]", "[левый верхний угол]");

            //___третяя попытка
            Graph graph = new Graph();

            graph.AddVertex(Coord(0, 0));//добавляю самый первый элемент
            for (int j = 1; j < matrix[0].Length; j++)//иду по столбцам первой строки
            {
                graph.AddVertex(Coord(0, j));
                graph.AddEdge(Coord(0, j - 1), Coord(0, j), max(matrix[0][j], matrix[0][j-1]));//заполняю первую строку и соединяю между собой
                
            }
            graph.AddVertex("[левый верхний угол]");// добавляю стартовую точку
            graph.AddEdge(Coord(0, matrix[0].Length - 1), "[левый верхний угол]", matrix[0][matrix[0].Length - 1]);

            for (int i = 1; i < matrix.GetLength(0); i++)//иду по строкам
            {
                graph.AddVertex(Coord(i, 0));//сначала добавляю первый элемент в строке и соединяю с первым элементом предыдущей строки
                graph.AddEdge(Coord(i - 1, 0), Coord(i, 0), max(matrix[i-1][0], matrix[i][0]) );
                for (int j = 1; j < matrix[i].Length; j++)
                {

                    graph.AddVertex(Coord(i, j));// потом создаю вершины и связь по строке и с предыдущей
                    graph.AddEdge(Coord(i, j - 1), Coord(i, j),max(matrix[i][j-1], matrix[i][j]));
                    if (j < matrix[i - 1].Length)
                    {
                        graph.AddEdge(Coord(i - 1, j), Coord(i, j), max(matrix[i-1][j], matrix[i][j]));
                    }
                }


            }
            graph.AddVertex("[нижний правый угол]");// добавляю стартовую точку
            graph.AddEdge("[нижний правый угол]", Coord(matrix.GetLength(0) - 1, 0), matrix[matrix.GetLength(0) - 1][0]);





            ////_______________

            //for (int i = 0; i < graph.Vertices.Count; i++)
            //{
            //    Console.WriteLine(graph.Vertices[i].Name);
            //}

            ////_______________

            Dijkstra dijkstra = new Dijkstra(graph);
            // return dijkstra.FindShortestPath("[левый верхний угол]", Coord(matrix.GetLength(0) - 1, 0));
            return dijkstra.FindShortestPath("[нижний правый угол]", "[левый верхний угол]");













        }
        //private pos FindShortestWay(int[][] mas, pos poz,ref List<pos> way)
        //{
        //    if (!poz.Equals(new pos(mas.GetLength(0) - 1, 0))) 
        //    {
        //        //смотрим позицию и проверяем куда мы можем пойти
        //        // мы можем идти только в 
        //    }

        //}
        private struct pos
        {
            public int i;
            public int j;

            public pos(int i, int j)
            {
                this.i = i;
                this.j = j;
            }
        }
        private static int Distance(int i, int j,int p, int q)
        {
            return Math.Abs(i - p) + Math.Abs(j - q);
        }
        private static string Coord(int i, int j) => $"[{i},{j}]";
        private static string Coord(pos poz) => $"[{poz.i},{poz.j}]";
        private static int max(int a, int b)
        {
            if (a>b)
            {
                return a;
            }
            if (b>a)
            {
                return b;
            }
            return a;
        }
        
    }


}
