using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadApp.Interfaces
{
    public interface IGenerator
    {
        int[] GenerateArray(int count, int min, int max);
    }
}
