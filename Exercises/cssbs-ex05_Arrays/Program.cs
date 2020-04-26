using System;

namespace cssbs_ex05_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 0, 2, 4, 6, 8, 10 };
            int[] B = new int[] { 1, 3, 5, 7, 9 };
            int[] C = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            int sumA = 0, sumB = 0, sumC = 0;

            Console.WriteLine("Part 0: print arrays.");
            foreach (int itemA in A)
                Console.Write(itemA + " ");
            Console.WriteLine();
            foreach (int itemB in B)
                Console.Write(itemB + " ");
            Console.WriteLine();
            foreach (int itemC in C)
                Console.Write(itemC + " ");
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();

            for (int i = 0; i < A.Length; i++)
            {
                sumA += A[i];
            }

            for (int i = 0; i < B.Length; i++)
            {
                sumB += B[i];
            }

            for (int i = 0; i < C.Length; i++)
            {
                sumC += C[i];
            }

            double avgA, avgB, avgC;

            avgA = (double)sumA / A.Length;
            avgB = (double)sumB / B.Length;
            avgC = (double)sumC / C.Length;

            Console.WriteLine("Part 1: count, sum and average arrays.");

            Console.WriteLine("Array A count = " + A.Length + ", sum = " + sumA + ", average = " + avgA);
            Console.WriteLine("Array B count = " + B.Length + ", sum = " + sumB + ", average = " + avgB);
            Console.WriteLine("Array C count = " + C.Length + ", sum = " + sumC + ", average = " + avgC);

            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();

            int[] revA = A;
            int[] revB = B;
            int[] revC = C;

            Array.Reverse(revA);
            Array.Reverse(revB);
            Array.Reverse(revC);

            Console.Write("Part 2: Reversed Arrays.");
            Console.WriteLine();

            foreach (int r in revA)
            {
                Console.Write(r + " ");
            }
            Console.WriteLine();
            foreach (int r in revB)
            {
                Console.Write(r + " ");
            }
            Console.WriteLine();
            foreach (int r in revC)
            {
                Console.Write(r + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Part 3: Rotate Arrays.");
            Console.WriteLine();

            int[] revAA = A;
            int[] revBB = B;
            int[] revCC = C;

            Array.Reverse(revAA);
            Array.Reverse(revBB);
            Array.Reverse(revCC);

            rotations(0, A, A.Length, 2); // rotation method created 0 = Left
            rotations(1, B, B.Length, 2); // rotation method created 1 = right
            rotations(0, C, C.Length, 4); // rotation method created 0 = left

            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Part 4: sort Array C:");

            Array.Sort(C, (x, y) => y.CompareTo(x));
            for (int j = 0; j < C.Length; j++)
            {
                Console.Write(C[j] + " ");
            }
            Console.ReadKey();
        }

        public static void print(int[] x, int l)
        {
            for (int i = 0; i < l; i++)
            {
                Console.Write(x[i] + " ");
            }
        }

        public static void rotations(int x, int[] y, int l, int n)
        {
            if (x == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    int temp = y[0];
                    Array.Copy(y, 1, y, 0, l - 1);
                    y[l - 1] = temp;
                }
                Console.WriteLine("Rotation is L, places " + n);
                Program.print(y, l);
                Console.WriteLine();
            }
            else if (x == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    int temp = y[^1];
                    Array.Copy(y, 0, y, 1, l - 1);
                    y[0] = temp;
                }
                Console.WriteLine("Rotation is R, places " + n);
                Program.print(y, l);
                Console.WriteLine();
            }
        }
    }
}
