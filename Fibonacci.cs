﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample32
{
    class Fibonacci
    {
        public long Get(int i)
        {
            if(i<0) { return 0; }
            if(i==1) { return 1; }
            return Get(i - 2) + Get(i - 1);
        }
    }
}
