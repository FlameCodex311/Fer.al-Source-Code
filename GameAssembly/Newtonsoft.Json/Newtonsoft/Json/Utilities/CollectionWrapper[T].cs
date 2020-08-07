/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal class CollectionWrapper<T> : ICollection<T>, IWrappedCollection // TypeDefIndex: 8027
	{
		// Fields
		private readonly IList _list;
		private readonly ICollection<T> _genericCollection;
		private object _syncRoot;
	
		// Properties
		public virtual int Count { get; }
		public virtual bool IsReadOnly { get; }
		bool IList.IsFixedSize { get; }
		object IList.this[int index] { get => default; set {} }
		bool ICollection.IsSynchronized { get; }
		object ICollection.SyncRoot { get; }
		public object UnderlyingCollection { get; }
	
		// Constructors
		public CollectionWrapper(IList list);
		public CollectionWrapper(ICollection<T> list);
	
		// Methods
		public virtual void Add(T item);
		public virtual void Clear();
		public virtual bool Contains(T item);
		public virtual void CopyTo(T[] array, int arrayIndex);
		public virtual bool Remove(T item);
		public virtual IEnumerator<T> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		int IList.Add(object value);
		bool IList.Contains(object value);
		int IList.IndexOf(object value);
		void IList.RemoveAt(int index);
		void IList.Insert(int index, object value);
		void IList.Remove(object value);
		void ICollection.CopyTo(Array array, int arrayIndex);
		private static void VerifyValueType(object value);
		private static bool IsCompatibleObject(object value);
	}
}
