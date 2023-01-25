using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._01._2023
{
	internal class IEnumerableLesson
	{
		//בשביל לרוץ בפוראיצ חייב לממש ienumerable
		//חייב לממש גם 3 פונקציות- movenext/ getenumerator/ reset
		//אם ברצוני לבנות מבנה נתונים פרטי ולרוץ עליו בforeach עלינו לממש את הממשקים הבאים 
		//mylist- מבנה נתונים שבנינו
		//list, dictionary כבר מממשים את הממשקים הללו לכן ניתן לעבור עליהם בforeach
		public void Run()
		{
			MyList list = new MyList();
			list.Add(100);
			list.Add(2345);
			list.Add(33);
			list.Add(2);
			list.Add(22);
			list.Add(4444);

			foreach(int item in list) 
			{ 
				Console.WriteLine(item);
			}

			list.Add(2);
			list.Add(22);
			list.Add(4444);

			foreach (int item in list)
			{
				Console.WriteLine(item);
			}
		}
	}

	public class MyEnumerator: IEnumerator
	{
		int[] arr= new int[100];
		int idx= 0;
		int loop = -1;

		public void Add(int s)
		{
			arr[idx] = s;
			idx++;
		}

		public int GetId()
		{
			return 90;
		}

		public object Current
		{
			get 
			{ 
				return arr[loop]; 
			}
		}
		public bool MoveNext()
		{
			if (loop >= idx)
			{
				//Reset();
				return false;
			}
			else
			{
				loop++;
				//תנאי בשביל מנגנון בקרה על פוראיצ
				//נגיד וברצוננו לעצור פוראיצ' שלא יציג פריט מסוים או לדלג עליו
				if (arr[loop] == 33)
				{
					//return false; //עצירת פוראיצ
					return MoveNext(); //דילוג
				}
				return true;
			}
		}

		public void Reset()
		{
			loop = -1;
		}
	}

	public class MyList : IEnumerable
	{
		MyEnumerator i = new MyEnumerator();

		public void Add(int a)
		{
			i.Add(a);
		}
		public IEnumerator GetEnumerator()
		{
			return i;
		}
	}
}
