using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the beautifulQuadruples function below.
     */
 public static long BeautifulQuadruplesOptimized(int a, int b, int c, int d)
{
    int[] arr = { a, b, c, d };
    Array.Sort(arr);
    a = arr[0]; b = arr[1]; c = arr[2]; d = arr[3];

    long totalBeautiful = 0;

    for (int w = 1; w <= a; w++)
    {
        for (int x = w; x <= b; x++)
        {
            for (int y = x; y <= c; y++)
            {
                int val = w ^ x ^ y;
                if (val < y || val > d)
                {
                    totalBeautiful += (long)(d - y + 1);
                }
                else
                {
                    totalBeautiful += (long)(d - y);
                }
            }
        }
    }
    return totalBeautiful;
}


    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] abcd = Console.ReadLine().Split(' ');

        int a = Convert.ToInt32(abcd[0]);

        int b = Convert.ToInt32(abcd[1]);

        int c = Convert.ToInt32(abcd[2]);

        int d = Convert.ToInt32(abcd[3]);

        int result = beautifulQuadruples(a, b, c, d);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
