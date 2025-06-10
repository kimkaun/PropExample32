using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample32
{
    class Fibonacci
    {
        public static long Get(int i)
        {
            Console.WriteLine("Get(" + i + ") 호출됨");
            if(i<0) { return 0; }
            if(i==1) { return 1; }
            return Get(i - 2) + Get(i - 1);
        }
        public static long GetM(int i)
        {
            long value = 0;
            if(memo.ContainsKey(i))
            {
                value = memo[i];
            }
            else
            {
                if (i < 0) value = 0;
                if (i == 1) value = 1;
                if (i == 2) value = 1;
                if(i>2)
                {
                    memo[i] = value = GetM(i - 2) + GetM(i - 1);
                }
            }
            return value;
        }

        // 메모라이제이션
        private static Dictionary<int,long> memo = new Dictionary<int, long>();
   
    }
}
