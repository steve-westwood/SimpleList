using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			SimpleList<int> _strings = new SimpleList<int>();
			_strings.Add(1);
			_strings.Add(2);
			_strings.Add(3);
			_strings.Add(4);
			_strings.Add(5);
			var count = _strings.Count;
			var number5 = _strings[4];
			_strings[4] = 6;
			var number6 = _strings[4];
			_strings.Insert(4, 5);
			var number1 = _strings.RemoveAt(0);
			_strings.Clear();



		}
	}
}
