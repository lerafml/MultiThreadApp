using MultiThreadApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadApp
{
    public class Context
    {
        private IStrategy _strategy;
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
        public long Execute(int[] arr)
        {
            return _strategy.Sum(arr);
        }
    }
}
