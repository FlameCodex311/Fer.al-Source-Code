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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001800FC9A0-0x00000001800FC9F0
	internal class DictionaryWrapper<TKey, TValue> : IDictionary<TKey, TValue>, IWrappedDictionary // TypeDefIndex: 7864
	{
		// Fields
		private readonly IDictionary _dictionary;
		private readonly IDictionary<TKey, TValue> _genericDictionary;
		private object _syncRoot;
	
		// Properties
		public ICollection<TKey> Keys { get; }
		public ICollection<TValue> Values { get; }
		public TValue this[TKey key] { get => default; set {} }
		public int Count { get; }
		public bool IsReadOnly { get; }
		object IDictionary.this[object key] { get => default; set {} }
		bool IDictionary.IsFixedSize { get; }
		ICollection IDictionary.Keys { get; }
		ICollection IDictionary.Values { get; }
		bool ICollection.IsSynchronized { get; }
		object ICollection.SyncRoot { get; }
		public object UnderlyingDictionary { get; }
	
		// Nested types
		private struct DictionaryEnumerator<TEnumeratorKey, TEnumeratorValue> : IDictionaryEnumerator // TypeDefIndex: 7865
		{
			// Fields
			private readonly IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> _e;
	
			// Properties
			public DictionaryEntry Entry { get; }
			public object Key { get; }
			public object Value { get; }
			public object Current { get; }
	
			// Constructors
			public DictionaryEnumerator(IEnumerator<KeyValuePair<TEnumeratorKey, TEnumeratorValue>> e);
	
			// Methods
			public bool MoveNext();
			public void Reset();
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 7866
		{
			// Fields
			public static readonly <>c<TKey, TValue> <>9;
			public static Func<DictionaryEntry, KeyValuePair<TKey, TValue>> <>9__25_0;
	
			// Constructors
			static <>c();
			public <>c();
	
			// Methods
			internal KeyValuePair<TKey, TValue> <GetEnumerator>b__25_0(DictionaryEntry de);
		}
	
		// Constructors
		public DictionaryWrapper(IDictionary dictionary);
		public DictionaryWrapper(IDictionary<TKey, TValue> dictionary);
	
		// Methods
		public void Add(TKey key, TValue value);
		public bool ContainsKey(TKey key);
		public bool Remove(TKey key);
		public bool TryGetValue(TKey key, out TValue value);
		public void Add(KeyValuePair<TKey, TValue> item);
		public void Clear();
		public bool Contains(KeyValuePair<TKey, TValue> item);
		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex);
		public bool Remove(KeyValuePair<TKey, TValue> item);
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		void IDictionary.Add(object key, object value);
		IDictionaryEnumerator IDictionary.GetEnumerator();
		bool IDictionary.Contains(object key);
		public void Remove(object key);
		void ICollection.CopyTo(Array array, int index);
	}
}
