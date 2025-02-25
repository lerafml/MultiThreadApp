using MultiThreadApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadApp.Strategies
{
    public class StandartStrategy : IStrategy
    {
        public long Sum(int[] arr)
        {
            long sum = 0;
            foreach (var item in arr)
            {
                sum += item;
            }
            return sum;
        }
    }
}
