using MultiThreadApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadApp
{
    public class ArrayGenerator : IGenerator
    {
        public int[] GenerateArray(int count, int min, int max)
        {
            int[] array = new int[count];
            for(int index = 0; index < count; index++)
            {
                array[index] = new Random().Next(min, max);
            }
            return array;
        }
    }
}
