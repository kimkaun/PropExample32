using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample32
{
    class Sample
    {
        public static int value;
        static Sample() // 정적 생성자 정의
        {
            value = 10;
            Console.WriteLine("정적 생성자 호출");
        }
    }
}
