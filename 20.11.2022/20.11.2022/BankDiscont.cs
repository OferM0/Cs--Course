using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11._2022
{
    internal class BankDiscont
    {
        public readonly int _branchCnt;
        public Discont[] d;

        public BankDiscont(int branchCnt)
        {
            _branchCnt = branchCnt;
            d = new Discont[_branchCnt];
        }

        public int BranchCnt
        {
            get { return _branchCnt; }
        }

        public void Import(Bank[] list)
        {
            int index = 0;

            for (int i = 0; i < list.Length; i++)
            {
                if (i > 0)
                {
                    if (list[i].Name.Contains("דיסקונט"))
                    {
                        d[index] = (Discont)list[i];
                        index++;
                    }
                }
            }
        }
    }
}
