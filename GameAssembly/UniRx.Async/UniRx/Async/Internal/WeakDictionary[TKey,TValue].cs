/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Internal
{
	internal class WeakDictionary<TKey, TValue> // TypeDefIndex: 8891
		where TKey : class
	{
		// Fields
		private Entry[] buckets;
		private int size;
		private SpinLock gate;
		private readonly float loadFactor;
		private readonly IEqualityComparer<TKey> keyEqualityComparer;
	
		// Nested types
		private class Entry // TypeDefIndex: 8892
		{
			// Fields
			public WeakReference<TKey> Key;
			public TValue Value;
			public int Hash;
			public Entry<TKey, TValue> Prev;
			public Entry<TKey, TValue> Next;
	
			// Constructors
			public Entry();
	
			// Methods
			public override string ToString();
			private int Count();
		}
	
		// Constructors
		public WeakDictionary(int capacity = 4 /* Metadata: 0x007780F3 */, float loadFactor = 0.75f /* Metadata: 0x007780F7 */, IEqualityComparer<TKey> keyComparer = null);
	
		// Methods
		public bool TryAdd(TKey key, TValue value);
		public bool TryGetValue(TKey key, out TValue value);
		public bool TryRemove(TKey key);
		private bool TryAddInternal(TKey key, TValue value);
		private bool AddToBuckets(Entry[] targetBuckets, TKey newKey, TValue value, int keyHash);
		private bool TryGetEntry(TKey key, out int hashIndex, out Entry entry);
		private void Remove(int hashIndex, Entry entry);
		public List<KeyValuePair<TKey, TValue>> ToList();
		public int ToList(ref List<KeyValuePair<TKey, TValue>> list, bool clear = true /* Metadata: 0x007780FB */);
		private static int CalculateCapacity(int collectionSize, float loadFactor);
	}
}
