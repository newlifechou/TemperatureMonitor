using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphTest
{
    public static class RandDataFactory
    {
        public static int GetRand(int val, int maxSpeed, bool isIncreased)
        {
            var rand = new Random();

            if (isIncreased)
                val = val + rand.Next(-1, maxSpeed + 1);
            else
                val = val - rand.Next(-1, maxSpeed + 1);

            if (val > 1000)
            {
                val = 1000;
            }
            if (val < 20)
            {
                val = 20;
            }
            return val;
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
