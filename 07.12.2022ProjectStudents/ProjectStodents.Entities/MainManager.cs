using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectStodents.Entities
{
    public class MainManager
    {
        public Hashtable ht = new Hashtable();
        private MainManager() { }
        private static readonly MainManager _instance=new MainManager();
        public static MainManager Instance { get { return _instance; } }

        public Students Students = new Students();
        public Books Books = new Books();
        public Teachers Teachers = new Teachers();

        public void Init()
        {
            Students.ResetHash();
        }

    }
}
