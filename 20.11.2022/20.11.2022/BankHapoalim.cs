using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._11._2022
{
    internal class BankHapoalim
    {
        public readonly int _branchCnt;
        public Hapoalim[] b;

        public BankHapoalim(int branchCnt)
        {
            _branchCnt = branchCnt;
            b = new Hapoalim[_branchCnt];
        }

        public int BranchCnt 
        {
            get { return _branchCnt; }
        }

        public void Import(Bank[] list)
        {
            int index=0;

            for (int i = 0; i < list.Length; i++)
            {
                if (i > 0)
                {
                    if (list[i].Name.Contains("הפועלים"))
                    {
                        b[index] = (Hapoalim)list[i];
                        index++;
                    }
                }
            }
        }
    }
}
