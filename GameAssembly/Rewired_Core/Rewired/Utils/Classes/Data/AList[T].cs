/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	[CustomClassObfuscation] // 0x00000001801CE530-0x00000001801CE5A0
	[CustomObfuscation] // 0x00000001801CE530-0x00000001801CE5A0
	internal class AList<T> : IList, IList<T> // TypeDefIndex: 6977
	{
		// Fields
		private const int SFatwjibynXGEomWOnOKTtIVggf = 4; // Metadata: 0x00766646
		private static readonly T[] EmpnQqFSmctMRvSIhWrQSbIUrQJ;
		private IEqualityComparer<T> BpqgKwtwxiCJWBlAQLLFXpVLOJgD;
		public T[] _items;
		private int LHcUXOytTkIjlqPoenVhkyCFGKR;
		public int _count;
		private int JcItYmplPOUuUXgZFGENZdovpnY;
		private bool WWdbcyRFlTeBVkzHnYfpEPbdVyg;
		private readonly int OoGlvnFCRjGSzsoWBBLcZxoAxKx;
		private readonly bool aIIxLBxcYMhlGvgopclnroCYGOX;
		private int wNPCYmLfYxcqAQsDPfNrFaPUdXp;
		[NonSerialized]
		private object vYiBUIHFosLSVhIQAioByfsCKmi;
	
		// Properties
		public int Count { get; }
		public int Capacity { get; }
		public int FreeSpace { get; }
		public bool IsFixedSize { get; }
		public IEqualityComparer<T> EqualityComparer { get; set; }
		public int Version { get; }
		public T this[int index] { get => default; set {} }
		bool ICollection<T>.IsReadOnly { get; }
		bool IList.IsReadOnly { get; }
		object IList.this[int index] { get => default; set {} }
		int ICollection.Count { get; }
		bool ICollection.IsSynchronized { get; }
		object ICollection.SyncRoot { get; }
	
		// Nested types
		[Serializable]
		public struct skKzdUZbYBEBxZqKQKAIgzFPcIt : IEnumerator<T> // TypeDefIndex: 6978
		{
			// Fields
			private AList<T> list;
			private int index;
			private int version;
			private T current;
	
			// Properties
			public T iqRXBCFJzSXINtBNEmUcRPMPsKE { get; }
			object lEHmhZcDVBCvVkmanIeFkjDMVct { get; }
	
			// Constructors
			internal skKzdUZbYBEBxZqKQKAIgzFPcIt(AList<T> list);
	
			// Methods
			public void Dispose();
			public bool MoveNext();
			private bool mGRuCjPDMbxAnMBLgXgjddgPkSL();
			void IEnumerator.Reset();
		}
	
		// Constructors
		public AList();
		public AList(int startingCapacity);
		public AList(int startingCapacity, int maxCapacity);
		public AList(int startingCapacity, int maxCapacity, int expansionIncrement);
		public AList(IEnumerable<T> collection);
		public AList(IEnumerable<T> collection, int maxCapacity, int expansionIncrement);
		static AList();
	
		// Methods
		public T GetRandom();
		public int Add(T item);
		public bool Add(T[] items, int count = 0 /* Metadata: 0x00766632 */, int startIndex = 0 /* Metadata: 0x00766636 */, bool allowPartialAdd = false /* Metadata: 0x0076663A */);
		public bool Add(AList<T> items, int count = 0 /* Metadata: 0x0076663B */, int startIndex = 0 /* Metadata: 0x0076663F */, bool allowPartialAdd = false /* Metadata: 0x00766643 */);
		public int AddIfUnique(T item);
		public int AddToFirstOpenSpace(T item);
		public int AddToFirstOpenSpace(T item, T openSpaceEquals);
		public bool Insert(int index, T item);
		public bool Remove(T item);
		public void RemoveAt(int index);
		public bool Contains(T item);
		public bool Contains(T item, IEqualityComparer<T> comparer);
		public int IndexOf(T item);
		public int IndexOf(T item, int index);
		public int IndexOf(T item, int index, int count);
		public int IndexOf(T item, IEqualityComparer<T> comparer);
		public int IndexOf(T item, int index, IEqualityComparer<T> comparer);
		public int IndexOf(T item, int index, int count, IEqualityComparer<T> comparer);
		public void Reverse();
		public void Reverse(int index, int count);
		public void Sort();
		public void Sort(IComparer<T> comparer);
		public void Sort(int index, int count, IComparer<T> comparer);
		public List<T> GetRange(int index, int count);
		public ReadOnlyCollection<T> AsReadOnly();
		public bool Exists(Predicate<T> match);
		public T Find(Predicate<T> match);
		public List<T> FindAll(Predicate<T> match);
		public int FindIndex(Predicate<T> match);
		public int FindIndex(int startIndex, Predicate<T> match);
		public int FindIndex(int startIndex, int count, Predicate<T> match);
		public T FindLast(Predicate<T> match);
		public int FindLastIndex(Predicate<T> match);
		public int FindLastIndex(int startIndex, Predicate<T> match);
		public int FindLastIndex(int startIndex, int count, Predicate<T> match);
		public void ForEach(Action<T> action);
		public int LastIndexOf(T item);
		public int LastIndexOf(T item, int index);
		public int LastIndexOf(T item, int index, int count);
		public int RemoveAll(Predicate<T> match);
		public bool TrueForAll(Predicate<T> match);
		public T[] ToArray();
		public void CopyTo(int index, T[] array, int arrayIndex, int count);
		public void CopyTo(T[] array, int arrayIndex);
		public void Clear();
		public void TrimExcess();
		private int KYhcXjRTztAqPRAJgphDPJVmzZt(int param_0000ee4a, bool param_0000ee4b = false /* Metadata: 0x00766644 */);
		private int KuuXFaPZEHiivZPFizEBZKcqAZe(int param_0000ee4c, int param_0000ee4d);
		private bool UGfPaKfKAIAknjNVXFiWfAahWzU(int param_0000ee4e, bool param_0000ee4f = false /* Metadata: 0x00766645 */);
		void IList<T>.Insert(int index, T item);
		void ICollection<T>.Add(T item);
		void ICollection<T>.CopyTo(T[] array, int arrayIndex);
		void ICollection.CopyTo(Array array, int index);
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		int IList.Add(object value);
		bool IList.Contains(object value);
		int IList.IndexOf(object value);
		void IList.Insert(int index, object value);
		void IList.Remove(object value);
		public static AList<T> CreateFixedLengthList(int capacity);
		private static bool yMMYzBSOYmQjMegUabqvdRTfDWfl(object param_0000ee61);
	}
}
