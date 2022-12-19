using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueFiles.Entities
{
    public class RandomValue
    {
        public int Max { get; set; }
        public int Min { get; set; }
        public int GetRandomBetween(int num1, int num2)
        {
            Random random = new Random(DateTime.Now.Millisecond);
            return random.Next(num1, num2);
        }
    }
}
