using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
	public interface ISimpleList<T>
	{
		/// <summary>Adds an item to the ISimpleList<T>.</summary>
		/// <param name="item">The object to add to the ISimpleList<T>.</param>
		void Add(T item);

		/// <summary>Removes all items from the ISimpleList<T>.</summary>
		void Clear();

		/// <summary>Gets the number of elements contained in the ISimpleList<T>.</summary>
		int Count { get; }

		/// <summary>Gets or sets the element at the specified index.</summary>
		/// <param name="index">The zero-based index of the element to get or set.</param>
		/// <returns>The element at the specified index.</returns>
		T this[int index] { get; set; }

		/// <summary>Inserts an item to the ISimpleList<T> at the specified index.</summary>
		/// <param name="index">The zero-based index at which item should be inserted.</param>
		/// <param name="item">The object to insert into the ISimpleList<T>.</param>
		void Insert(int index, T item);

		/// <summary>Removes the ISimpleList<T> item at the specified index.</summary>
		/// <param name="index">The zero-based index of the item to remove.</param>
		/// <returns>Removed element.</returns>
		T RemoveAt(int index);
	}

}
