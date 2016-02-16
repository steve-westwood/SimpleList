using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	public class SimpleList<T> : ISimpleList<T>
	{
		private T[] _arr = new T[] { };

		public void Add(T item)
		{
			List<T> _list = new List<T>();
			_list.AddRange(_arr);
			_list.Add(item);
			_arr = _list.ToArray();
		}

		public void Clear()
		{
			_arr = new T[] { };
		}

		public int Count
		{
			get { return _arr.Length; }
		}

		public T this[int index]
		{
			get
			{
				return _arr[index];
			}
			set
			{
				_arr[index] = value;
			}
		}

		public void Insert(int index, T item)
		{
			List<T> _list = new List<T>();
			int length = _arr.Length;
			for (int i = 0; i <= length; i++)
			{
				if (i == index)
				{
					_list.Add(item);
				}
				else
				{
					if (i < index)
						_list.Add(_arr[i]);
					else
						_list.Add(_arr[i - 1]);
				}
			}
			_arr = _list.ToArray();
		}

		public T RemoveAt(int index)
		{
			T t = default(T);
			List<T> _list = new List<T>();
			int length = _arr.Length;
			if (length > 0)
			{
				for (int i = 0; i < length; i++)
				{
					if (i == index)
						t = _arr[i];
					else
						_list.Add(_arr[i]);

				}
			}
			_arr = _list.ToArray();
			return t;
		}
	}
}
