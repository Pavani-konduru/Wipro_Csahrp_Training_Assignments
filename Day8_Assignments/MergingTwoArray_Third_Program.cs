
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergingTwoArrays_Third
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = { 4, 13, 14, 20, 78, 100 };
            int[] B = { 2, 11, 17, 25, 35, 99 };

            int[] C = new int[A.Length + B.Length];

            int i = 0, j = 0, k = 0;

            while (i < A.Length && j < B.Length)
            {
                if (A[i] < B[j])
                {
                    C[k] = A[i];
                    k++;
                    i++;
                }
                else if (A[i] > B[j])
                {
                    C[k] = B[j];
                    k++;
                    j++;
                }
                else
                {
                    C[k] = A[i];
                    k++;
                    i++;
                    j++;
                }
            }

            // copy remaining items from A to C
            while (i < A.Length)
            {
                C[k] = A[i];
                k++;
                i++;
            }

            // copy remaining items from B to C
            while (j < B.Length)
            {
                C[k] = B[j];
                k++;
                j++;
            }

            for (int n = 0; n < k; n++)
            {
                Console.Write("  " + C[n]);
            }

            Console.ReadLine();
        }
    }
}
