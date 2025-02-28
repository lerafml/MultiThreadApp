using MultiThreadApp.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MultiThreadApp.Strategies
{
    public class ParallelStrategy : IStrategy
    {
        public long Sum(int[] arr)
        {
            int threadCount = 4;
            int chunkSize = arr.Length / threadCount;

            List<Thread> threads = new List<Thread>();
            List<int> partialSums = new List<int>(new int[threadCount]);

            for (int i = 0; i < threadCount; i++)
            {
                int threadIndex = i;
                int start = threadIndex * chunkSize;
                int end = (threadIndex == threadCount - 1) ? arr.Length : start + chunkSize;

                Thread thread = new Thread(() =>
                {
                    int sum = 0;
                    for (int j = start; j < end; j++)
                    {
                        sum += arr[j];
                    }
                    partialSums[threadIndex] = sum;
                });

                threads.Add(thread);
                thread.Start();
            }
            
            foreach (var thread in threads)
            {
                thread.Join();
            }
            return partialSums.Sum();
        }
    }
}
