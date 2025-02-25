using MultiThreadApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MultiThreadApp.Strategies
{
    public class ParallelStrategy : IStrategy
    {
        public long Sum(int[] arr)
        {
            long sum = 0;
            Parallel.For(0, arr.Length, i =>
            {
                sum += arr[i];
            });
            return sum;
        }
    }
}
