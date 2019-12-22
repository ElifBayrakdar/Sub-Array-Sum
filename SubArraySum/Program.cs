using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = { 1, 2, 3, 4 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    for (int k = i; k <= j; k++)
                    {
                        sum += arr[k];
                    }
                }
            }
            int result = sum;
        }
    }
}
