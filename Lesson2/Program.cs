using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShowArrays();

            //ShowRefAndValueTypes();

            //JaggedAray();

            //Ifcase();

            //ShowFor();

            //string command;// = Console.ReadLine();

            /*while (command != "exit")
            {
                Console.WriteLine("Выполняется какая-то работа");
                command = Console.ReadLine();
            }*/

            /*do
            {
                Console.WriteLine("Выполняется работа");
                command = Console.ReadLine();
                
            } while (command != "exit");*/

            /*for (; ; )
            {
                Console.WriteLine("Выполняется работа");
                continue;
                command = Console.ReadLine();
                if (command == "exit")
                {
                    break;
                }
            }*/

            int size = 10;
            Console.WriteLine("Practice Lesson2:");
            Console.WriteLine("Введите номер задания:");
            string TaskNum = Console.ReadLine();

            switch (TaskNum)
            {
                case "1":
                    PrintMatrix(size, OneAndZeroColumnMatrix(size));
                    break;
                case "2":
                    PrintMatrix(size, AboveMainDiagonal(size));
                    break;
                case "3":
                    PrintMatrix(size, MainDiagonal(size));
                    break;
                case "4":
                    PrintMatrix(size, Chess(size));
                    break;
                default:
                    Console.WriteLine("Число введено не верно");
                    break;
            }


            Console.WriteLine();
            Console.WriteLine("Работа завершена");
            Console.ReadLine();
        }

        static int[,] OneAndZeroColumnMatrix(int size)
        {
            int[,] matrix = new int[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j % 2 == 0)
                    { 
                        matrix[i, j] = 1;
                    }
                    else
                    { 
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }

        static int[,] AboveMainDiagonal(int size)
        {
            int[,] matrix = new int[size, size];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j <= i)
                    {
                        matrix[i, j] = 1; 
                    }
                    else
                    { 
                        matrix[i, j] = 0;
                    }

                }
            }
            return matrix;
        }

        static int[,] MainDiagonal(int size)
        {
            int[,] matrix = new int[size, size];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == i)
                    {
                        matrix[i, j] = 8;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }

        static int[,] Chess(int size)
        {
            int[,] matrix = new int[size, size];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)  //(((i%2==0)&&(j%2==0))||((i%2!=0)&&(j%2!=0)))
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }

        static void PrintMatrix(int N, int[,] MTX)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                { 
                    Console.Write(MTX[i, j] + " "); 
                }
                Console.WriteLine();
            }
        }

        private static void ShowFor()
        {
            //вывести числа от 0 до 10
            for (int i = 0; i < 11 /*i <= 10*/; i++)
            {
                //Console.WriteLine(i);
            }

            //for (int i = 0; i < 11; Console.WriteLine(i), i++) ;

            //вывести только четные числа от 0 до 100
            /*for (int i = 0; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            for (int i = 0; i < 101; i += 2)
            {
                Console.WriteLine(i);
            }*/

            int[] numbers1 = new int[5] { 11, 22, 33, 44, 55 };
            for (int i = 0; i < numbers1.GetLength(0); i++)
            {
                Console.WriteLine(numbers1[i]);
            }
        }

        private static void Ifcase()
        {
            
            /*if (command == "exit")
            {
                Console.WriteLine("Работа завершена");
            }
            else
            {
                Console.WriteLine("Выполняется какая-то работа");
            }*/
            string command = Console.ReadLine();
            switch (command)
            {
                case "exit":
                    Console.WriteLine("Работа завершена");
                    break;
                case "option1":
                case "option2":
                case "option3":
                    Console.WriteLine("Включена какая-то функция");
                    break;
                default:
                    Console.WriteLine("Выполняется какая-то работа");
                    break;
            }
        }

        private static void JaggedAray()
        {
            int[][] table = new int[3][];
            table[0] = new int[4];
            table[1] = new int[2];
            table[2] = new int[3];

            table[0][0] = 1;
            table[0][1] = 2;
            table[0][2] = 3;
            table[0][3] = 4;

            table[1][0] = 5;
            table[1][1] = 6;

            table[2][0] = 7;
            table[2][1] = 8;
            table[2][2] = 9;

            Console.WriteLine(table[0][0] + " " + table[0][1] + " " + table[0][2] + " " + table[0][3]);
            Console.WriteLine(table[1][0] + " " + table[1][1]);
            Console.WriteLine(table[2][0] + " " + table[2][1] + " " + table[2][2]);
        }

        private static void ShowRefAndValueTypes()
        {
            int[] a = new int[2] { 5, 5 };
            int[] b = new int[2] { 9, 9 };

            Console.WriteLine(a[0] + " " + a[1]);
            Console.WriteLine(b[0] + " " + b[1]);

            a = b;
            Console.WriteLine("---------------");
            Console.WriteLine(a[0] + " " + a[1]);
            Console.WriteLine(b[0] + " " + b[1]);

            b[0] = 100;
            b[1] = 100;
            Console.WriteLine("---------------");
            Console.WriteLine(a[0] + " " + a[1]);
            Console.WriteLine(b[0] + " " + b[1]);

            Console.WriteLine("================");

            int x = 5;
            int y = 9;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("------------");

            x = y;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("------------");

            y = 100;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine("------------");
        }

        private static void ShowArrays()
        {
            int number = 10;
            int[] numbers = new int[5];
            numbers[0] = 11;
            numbers[1] = 1511;
            numbers[2] = 1164;
            numbers[3] = 114;
            numbers[4] = 1184;

            int[] numbers1 = new int[5] { 11, 22, 33, 44, 55 };
            int[] numbers2 = new int[] { 111, 222, 333, 444, 555 };
            int[] numbers3 = { 1, 2, 3, 4, 5 };

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);

            Console.WriteLine("--------------");
            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.GetLength(0));

            int[,] table = new int[2, 3];
            table[0, 0] = 1;
            table[0, 1] = 2;
            table[0, 2] = 3;

            table[1, 0] = 4;
            table[1, 1] = 5;
            table[1, 2] = 6;
            Console.WriteLine("================");
            Console.Write(table[0, 0] + " ");
            Console.Write(table[0, 1] + " ");
            Console.WriteLine(table[0, 2]);

            Console.Write(table[1, 0] + " ");
            Console.Write(table[1, 1] + " ");
            Console.WriteLine(table[1, 2]);

            Console.WriteLine("--------------------");
            Console.WriteLine(table.Length);
            Console.WriteLine(table.GetLength(0));
            Console.WriteLine(table.GetLength(1));

            int[,] table1 = new int[2, 3] 
            { 
                { 1, 2, 3 }, 
                { 4, 5, 6 } 
            };

            int[, , , ,] FiveDimension = new int[2, 2, 3, 4, 5];
        }

        static void PrintSmth()
        {
            Console.WriteLine("Результат работы метода");
        }

        static void DoSmth()
        {
            int a = 10;
            int b = 15;
            int sum = a + b;
            Console.WriteLine("Результат работы метода: " + sum);
        }

        static void WithArgs(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Результат работы метода: " + sum);
        }

        static int CalcSum(int a, int b)
        {
            return (a+b)*10/2;
        }
    }
}
