using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueFiles.Entities
{
    public class MainManager
    {
        public MyQueue myQueue = new MyQueue();
        public RandomValue randomValue = new RandomValue();
        private MainManager() { }
        private static readonly MainManager _instance = new MainManager();
        public static MainManager Instance { get { return _instance; } }

        public void Init()
        {
            myQueue.ClearQueue();
        }
    }
}
