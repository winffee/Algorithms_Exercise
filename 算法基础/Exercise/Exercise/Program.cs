using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = InitArray();
            PrintArr(A);

            Insertion_Sort_Des(A);
            PrintArr(A);
            Console.ReadKey();
        }

        public static void PrintArr(int[] arr)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < arr.Length; i++)
            {
                sb.Append(arr[i] + ",");
            }
            sb.Remove(sb.Length - 1, 1);
            sb.Append("]");
            Console.WriteLine(sb.ToString());
        }
        

        public static int[] InitArray()
        {
            Random rand = new Random();
            int[] A = new int[10];
            for (int i = 0; i < 10; i++)
            {
                A[i]=rand.Next(0, 100);
            }
            return A;
        }

        //插入排序(升序)
        public static void Insertion_Sort(int[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                int key = A[i];
                int j = i - 1;
                while (j >= 0 && A[j] > key)
                {
                    A[j + 1] = A[j];
                    A[j] = key;
                    j--;
                }
            }
        }

        //2.1-2 插入排序(降序)
        public static void Insertion_Sort_Des(int[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                int key = A[i];
                int j = i - 1;
                while (j >= 0 && A[j] < key)
                {
                    A[j + 1] = A[j];
                    A[j] = key;
                    j--;
                }
            }
        }
    }
}
