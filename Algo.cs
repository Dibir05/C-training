using System;

class Program
{
    static int[][] Str(int[] a)
    {
        int c = a.Length / 2;

        int[][] ms = new int[2][];
        int[] ms1 = new int[c]; //первая половина массива
        int[] ms2 = new int[c]; //вторая половина массива
        ms[0] = ms1;
        ms[1] = ms2;
        for (int i = 0; i < c; i++)
        {
            ms1[i] = a[i];
            
            ms2[i] = a[i + c];

        }
        for (int j = 0; j < ms1.Length / 2; j++)
        {
            int temp = ms1[j];
            ms1[j] = ms1[ms1.Length - j - 1];
            ms1[ms1.Length - j - 1] = temp;
        }
        for (int s = 0; s < ms2.Length / 2; s++)
        {
            int temp1 = ms2[s];
            ms2[s] = ms2[ms2.Length - s - 1];
            ms2[ms2.Length - s - 1] = temp1;
        }

        return ms;

    }
    static void Main()
    {
        int[] a = new int[8] { 1, 2, 3, 4, 5, 6, 7,8};
        var bb = Str(a);
        foreach (int[] row in bb)
        {
            foreach (int number in row)
            {
                Console.Write($"{number} \t");
            }
            Console.WriteLine();
        }


    }
} 
