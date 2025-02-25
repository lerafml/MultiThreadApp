using MultiThreadApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadApp.Strategies
{
    public class LINQStrategy : IStrategy
    {
        public long Sum(int[] arr)
        {
            return arr.AsParallel().WithDegreeOfParallelism(2).Sum();
        }
    }
}
