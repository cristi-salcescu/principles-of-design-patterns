using System;
using System.Collections.Generic;
using System.Text;

namespace CounterExamples
{
    public class Counter
    {
        private int count;

        public Counter()
        {
            count = 0;
        }

        public int Increment()
        {
            count += 1;
            return count;
        }
    }
}
