using System; 
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;
namespace Laba1_cs
{
    public struct dela
    {
        public string delo_1;
        public double time_1;
        public dela(string x, double y) { delo_1 = x; time_1 = y; }
        public string GetFullDela()
        {
            return ($"Дело:{delo_1}; Время:{time_1}");
        }

    }
    class Program
    {
        static void Main(string[] args) // Метод Main
        {
            while (true)
            {
                Console.WriteLine("Введите номер задания");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Выполняется задание номер {num}");
                switch (num)
                {
                    case 1:
                        {
                            Clear();
                            int[] myArray;
                            myArray = new int[16];
                            Random rand = new Random();
                            for (var i = 0; i < myArray.Length; i++)
                            {
                                myArray[i] = rand.Next(20);
                                Console.WriteLine(myArray[i]);
                            }
                            int max = 0;
                            foreach (var item in myArray)
                            {
                                if (max < item)
                                {
                                    max = item;
                                }
                            }
                            Console.WriteLine($"Максимальный элемент равен {max}");
                            break;
                        }
                    case 2:
                        {
                            Clear();
                            decimal ptr = 0;
                            decimal[,] matrix = new decimal[3, 4];
                            Random random = new Random();
                            for (var i = 0; i < matrix.GetLength(0); i++)
                                for (var j = 0; j < matrix.GetLength(1); j++)
                                {
                                    matrix[i, j] = Math.Round((random.Next(1050, 3000) / 3.0m), 2);
                                }
                            for (var i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (var j = 0; j < matrix.GetLength(1); j++)
                                {
                                    Write(matrix[i, j] + "  ");
                                }
                                WriteLine();
                            }
                            for (var i = 0; i < matrix.GetLength(1) - 1; i++)
                            {
                                for (int k = 0; k < 4; k++)
                                {
                                    for (var j = 0; j < matrix.GetLength(0); j++)
                                    {
                                        if (matrix[i, j] > matrix[i, j + 1])
                                        {
                                            ptr = matrix[i, j];
                                            matrix[i, j] = matrix[i, j + 1];
                                            matrix[i, j + 1] = ptr;

                                        }

                                    }
                                }

                            }
                            WriteLine("\n");
                            for (var i = 0; i < matrix.GetLength(0); i++)
                            {
                                for (var j = 0; j < matrix.GetLength(1); j++)
                                {
                                    Write(matrix[i, j] + "\t");

                                }
                                WriteLine();
                            }
                            ReadLine();
                            break;
                        }
                    case 3:
                        {
                            Clear();
                            List<dela> delo = new List<dela>();
                            var delo1 = new dela("Покур", 10);
                            delo.Add(delo1);
                            var delo2 = new dela("ЕПокур", 12);
                            delo.Add(delo2);
                            var delo3 = new dela("СПокур", 15);
                            delo.Add(delo3);
                            var delo4 = new dela("НПокур", 16);
                            delo.Add(delo4);
                            var delo5 = new dela("ДПокур", 17);
                            delo.Add(delo5);
                            Console.WriteLine("Дела");
                            delo.ForEach(x => WriteLine(x.GetFullDela()));
                            WriteLine("\n");
                            WriteLine("Дела после 14:00");
                            foreach (var i in delo)
                            {
                                if (i.time_1 > 14)
                                {
                                    WriteLine(i.GetFullDela());
                                }
                            }
                            ReadLine();
                            break;
                        }
                }
            }
        }
    }
}
    

