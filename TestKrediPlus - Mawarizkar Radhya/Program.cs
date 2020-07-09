using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKrediPlus___Mawarizkar_Radhya {
    class Program {
        static void Main(string[] args) {
            #region Number 1
            Console.WriteLine("Number 1");
            int a = 7;
            int b = 3;

            Console.WriteLine("SEBELUM");
            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}\n");
            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("SESUDAH");
            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}\n");

            #endregion

            #region Number 2
            Console.WriteLine("Number 2");
            int[] array = { 20, 10, 50, 46, 26, 87, 25, 5, 97, 24 };

            Console.Write("SEBELUM : ");
            foreach (var item in array) {
                Console.Write($"{item} ");
            }

            int temp = 0;

            for (int i = 0; i < 10; i++) {
                for (int j = 0; j < 10; j++) {
                    if (array[i] <= array[j]) {
                        temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
            Console.Write("\nSESUDAH : ");
            foreach (var item in array) {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");
            #endregion
        }
    }
}
