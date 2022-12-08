using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._12._2022WinFormDB
{
    internal class DelegateClass
    {
		private DelegateClass() { }
		private static readonly DelegateClass _instance = new DelegateClass();

		public static DelegateClass Instance
		{
			get { return _instance; }

		}

		public delegate int T2Numbers_delegate(int num1, int num2);

		public int CalcPlus(int num1, int num2)
		{
			return num1 + num2;
		}

		public int CalcMinus(int num1, int num2)
		{
			return num1 - num2;
		}
		public int CalcMultiply(int num1, int num2)
		{
			return num1 * num2;
		}

		public int CalcDivide(int num1, int num2)
		{
			return num1 / num2;
		}

		public int Calc(int a, int b, T2Numbers_delegate c)
		{
			return 10+ c(a,b);
		}
	}
}
