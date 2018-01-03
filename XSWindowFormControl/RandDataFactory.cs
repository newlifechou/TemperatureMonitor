using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTest
{
    public static class RandDataFactory
    {
        public static int GetRand(int val, int maxSpeed)
        {
            var rand = new Random();
            int result = val + rand.Next(0, maxSpeed+1);
            if (result > 200)
            {
                result = 200;
            }
            return result;
        }
        public static int[] GetRandInt(int count)
        {
            int[] data = new int[count];
            var rand = new Random();
            for (int i = 0; i < data.Length; i++)
            {
                int temp = rand.Next(0, 100);
                data[i] = temp;
            }
            return data;
        }
    }
}
