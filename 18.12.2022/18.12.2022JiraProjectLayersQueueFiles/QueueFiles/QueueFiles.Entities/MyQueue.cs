using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueueFiles.Model;

namespace QueueFiles.Entities
{
    public class MyQueue
    {
        private Queue<Item> myQueue = new Queue<Item>();
        public Item Pop()
        {
            if(myQueue.Count == 0) return null;
            else
                return myQueue.Dequeue();
        }

        public void Push(Item newItem)
        {
            myQueue.Enqueue(newItem);
        }

        public void ClearQueue()
        {
            myQueue.Clear();
        }
    }
}
