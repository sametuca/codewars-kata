using System;

namespace FindTheOddInt
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            Console.WriteLine(find_it(new int[]{1,1,3,4,1}));
        }
        public static int find_it(int[] seq)
        {
            // 1 2 3 1 4 5
            // 0 1 2 3 4 5
            int[] seqTwo = new int[seq.Length];
            for (var i = 0; i < seq.Length; i++)
            {
                for (var j = 1; j < seq.Length; j++)
                {
                    if(seq[i]==seq[j])
                    {
                        seqTwo[i] = seq[i];
                    }
                }
            }

            return seqTwo[0];
        }
    }
}