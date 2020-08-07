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
using Rewired;
using Rewired.Utils.Interfaces;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation] // 0x00000001801D0AE0-0x00000001801D0B50
	[CustomObfuscation] // 0x00000001801D0AE0-0x00000001801D0B50
	internal class IndexedDictionary<TKey, TValue> : IDictionary, IDictionary<TKey, TValue>, IReadOnlyList<TValue> // TypeDefIndex: 6968
	{
		// Fields
		private static readonly bool SidKWeuekvleteANqUttcMdXPoQ;
		private static readonly bool gMHfftmWPtiXwIpBQtvOIqmmThy;
		private IEqualityComparer<TKey> ONmdwHaXVKXTucZhYdWHNijhbip;
		private IEqualityComparer<TValue> sOxEPvSrUSxFDEuOTOmAAtxWhRD;
		private readonly AList<UOusDtCirBqAIjcBOfSGoGGhxCF> QDdpegUvplbleFLzyPPIlUNzJOf;
		private readonly ADictionary<TKey, int> chytxdnGkiCtXVpgexkcbEVFen;
		private bool XTKqqpPhZRQVXqlxpbamolLouUb;
	
		// Properties
		public int Count { get; }
		public bool ContainsDuplicateKeys { get; }
		public bool AllowDuplicateKeys { get; set; }
		public TValue this[int index] { get => default; set {} }
		public IEqualityComparer<TKey> KeyComparer { get; set; }
		public IEqualityComparer<TValue> ValueComparer { get; set; }
		public ICollection<TKey> Keys { get; }
		public ICollection<TValue> Values { get; }
		bool ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
		TValue IDictionary<TKey,TValue>.this[TKey key] { get => default; set {} }
		bool IDictionary.IsFixedSize { get; }
		bool IDictionary.IsReadOnly { get; }
		ICollection IDictionary.Keys { get; }
		ICollection IDictionary.Values { get; }
		object IDictionary.this[object key] { get => default; set {} }
		bool ICollection.IsSynchronized { get; }
		object ICollection.SyncRoot { get; }
		TValue IReadOnlyList<TValue>.this[int param_0000edb5] { get => default; }
		int IReadOnlyList.Count { get; }
		object IReadOnlyList.this[int param_0000edb8] { get => default; }
	
		// Nested types
		private struct UOusDtCirBqAIjcBOfSGoGGhxCF // TypeDefIndex: 6969
		{
			// Fields
			public TKey XoHEbkEkUMHxDaeeeewSFKYIjOYZ;
			public TValue PLdosENimxvPBjeGrIWuaBaRuLxb;
	
			// Constructors
			public UOusDtCirBqAIjcBOfSGoGGhxCF(TKey key, TValue value);
	
			// Methods
			public KeyValuePair<TKey, TValue> BdhfUzRDaYqMlTgFACuSGPOEEpu();
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
		[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
		public struct Enumerator : IDictionaryEnumerator, IEnumerator<KeyValuePair<TKey, TValue>> // TypeDefIndex: 6970
		{
			// Fields
			internal const int DictEntry = 1; // Metadata: 0x0076662A
			internal const int KeyValuePair = 2; // Metadata: 0x0076662E
			private IndexedDictionary<TKey, TValue> PPzpPGLKIynvruBNxkGUfOVeEjO;
			private int nlbIzkFWqZgWHDwirMvtyFNvieiE;
			private int sTgsnEJuUoRNnuSXfCYtcCJrAEKa;
			private KeyValuePair<TKey, TValue> hXsQEjeqlbsWHdImyyWjqLiDOxk;
			private int UNuIAkKRReJsfYxPDpRcmrPXtBQ;
	
			// Properties
			public KeyValuePair<TKey, TValue> Current { get; }
			object IEnumerator.Current { get; }
			DictionaryEntry IDictionaryEnumerator.Entry { get; }
			object IDictionaryEnumerator.Key { get; }
			object IDictionaryEnumerator.Value { get; }
	
			// Constructors
			internal Enumerator(IndexedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType);
	
			// Methods
			public bool MoveNext();
			public void Dispose();
			void IEnumerator.Reset();
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
		[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
		public sealed class KeyCollection : ICollection, ICollection<TKey> // TypeDefIndex: 6971
		{
			// Fields
			private IndexedDictionary<TKey, TValue> PPzpPGLKIynvruBNxkGUfOVeEjO;
	
			// Properties
			public int Count { get; }
			bool ICollection<TKey>.IsReadOnly { get; }
			bool ICollection.IsSynchronized { get; }
			object ICollection.SyncRoot { get; }
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
			[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
			public struct Enumerator : IEnumerator<TKey> // TypeDefIndex: 6972
			{
				// Fields
				private IndexedDictionary<TKey, TValue> PPzpPGLKIynvruBNxkGUfOVeEjO;
				private int sTgsnEJuUoRNnuSXfCYtcCJrAEKa;
				private int nlbIzkFWqZgWHDwirMvtyFNvieiE;
				private TKey hbRfzrSblKFuxxedFtFWaiLHbtl;
	
				// Properties
				public TKey Current { get; }
				object IEnumerator.Current { get; }
	
				// Constructors
				internal Enumerator(IndexedDictionary<TKey, TValue> dictionary);
	
				// Methods
				public void Dispose();
				public bool MoveNext();
				void IEnumerator.Reset();
			}
	
			// Constructors
			public KeyCollection(IndexedDictionary<TKey, TValue> dictionary);
	
			// Methods
			public Enumerator GetEnumerator();
			public void CopyTo(TKey[] array, int index);
			void ICollection<TKey>.Add(TKey item);
			void ICollection<TKey>.Clear();
			bool ICollection<TKey>.Contains(TKey item);
			bool ICollection<TKey>.Remove(TKey item);
			IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator();
			IEnumerator IEnumerable.GetEnumerator();
			void ICollection.CopyTo(Array array, int index);
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
		[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
		public sealed class ValueCollection : ICollection, ICollection<TValue> // TypeDefIndex: 6973
		{
			// Fields
			private IndexedDictionary<TKey, TValue> PPzpPGLKIynvruBNxkGUfOVeEjO;
	
			// Properties
			public int Count { get; }
			bool ICollection<TValue>.IsReadOnly { get; }
			bool ICollection.IsSynchronized { get; }
			object ICollection.SyncRoot { get; }
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
			[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
			public struct Enumerator : IEnumerator<TValue> // TypeDefIndex: 6974
			{
				// Fields
				private IndexedDictionary<TKey, TValue> PPzpPGLKIynvruBNxkGUfOVeEjO;
				private int sTgsnEJuUoRNnuSXfCYtcCJrAEKa;
				private int nlbIzkFWqZgWHDwirMvtyFNvieiE;
				private TValue cgNhrEKxwCsXVTwGCnhEJKQDBKow;
	
				// Properties
				public TValue Current { get; }
				object IEnumerator.Current { get; }
	
				// Constructors
				internal Enumerator(IndexedDictionary<TKey, TValue> dictionary);
	
				// Methods
				public void Dispose();
				public bool MoveNext();
				void IEnumerator.Reset();
			}
	
			// Constructors
			public ValueCollection(IndexedDictionary<TKey, TValue> dictionary);
	
			// Methods
			public Enumerator GetEnumerator();
			public void CopyTo(TValue[] array, int index);
			void ICollection<TValue>.Add(TValue item);
			bool ICollection<TValue>.Remove(TValue item);
			void ICollection<TValue>.Clear();
			bool ICollection<TValue>.Contains(TValue item);
			IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator();
			IEnumerator IEnumerable.GetEnumerator();
			void ICollection.CopyTo(Array array, int index);
		}
	
		// Constructors
		public IndexedDictionary();
		public IndexedDictionary(int capacity);
		public IndexedDictionary(bool allowDuplicateKeys);
		public IndexedDictionary(int capacity, bool allowDuplicateKeys);
		public IndexedDictionary(IDictionary<TKey, TValue> dictionary);
		public IndexedDictionary(IDictionary<TKey, TValue> dictionary, bool allowDuplicateKeys);
		static IndexedDictionary();
	
		// Methods
		public TValue GetValue(TKey key);
		public bool TryGetValue(TKey key, out TValue value);
		public TKey GetKeyAt(int index);
		public KeyValuePair<TKey, TValue> GetEntry(TKey key);
		public KeyValuePair<TKey, TValue> GetEntryAt(int index);
		public bool TryGetEntry(TKey key, out KeyValuePair<TKey, TValue> entry);
		public void Add(TKey key, TValue value);
		public void SetValue(TKey key, TValue value);
		public bool Remove(TKey key);
		public void RemoveAt(int index);
		public void RemoveValue(TValue value);
		public int RemoveAll(TValue value);
		public int IndexOfKey(TKey key);
		public int IndexOfValue(TValue value);
		public bool ContainsKey(TKey key);
		public bool ContainsValue(TValue value);
		public void Clear();
		public void TrimExcess();
		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item);
		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item);
		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index);
		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item);
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
		void IDictionary.Add(object key, object value);
		bool IDictionary.Contains(object key);
		IDictionaryEnumerator IDictionary.GetEnumerator();
		void IDictionary.Remove(object key);
		void ICollection.CopyTo(Array array, int index);
		int IReadOnlyList<TValue>.IndexOf(TValue param_0000edb6);
		bool IReadOnlyList<TValue>.Contains(TValue param_0000edb7);
		int IReadOnlyList.IndexOf(object param_0000edb9);
		bool IReadOnlyList.Contains(object param_0000edba);
	}
}
