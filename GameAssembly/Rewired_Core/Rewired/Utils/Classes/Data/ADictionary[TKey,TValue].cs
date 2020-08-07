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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation] // 0x00000001801D0AE0-0x00000001801D0B50
	[CustomObfuscation] // 0x00000001801D0AE0-0x00000001801D0B50
	internal class ADictionary<TKey, TValue> : IDictionary, IDictionary<TKey, TValue> // TypeDefIndex: 6961
	{
		// Fields
		private const string iywZuyOxphtuNibzHwTawJAHFjQ = "Version"; // Metadata: 0x007665EE
		private const string cbHizAgOdHuBBLmAtJiMKjFnccF = "HashSize"; // Metadata: 0x007665F9
		private const string caehSiMfmWBCkGgBshSpDrOIEjup = "KeyValuePairs"; // Metadata: 0x00766605
		private const string oPjNonZKkECUyVifoZubTVnhBlr = "Comparer"; // Metadata: 0x00766616
		private int[] gQzPpqxRCmDNjjxvzJMrNaplFRED;
		internal Entry[] _entries;
		internal int _count;
		private int wNPCYmLfYxcqAQsDPfNrFaPUdXp;
		private int eAqOfpDiFlECOPQSEyCBEyeaJpW;
		private int HYKCXxgFhrAgggiphnfYgWJyhYIc;
		private int XTFGxgGBgKoAOtuHtZmXVHQvrqx;
		private IEqualityComparer<TKey> ONmdwHaXVKXTucZhYdWHNijhbip;
		private IEqualityComparer<TValue> sOxEPvSrUSxFDEuOTOmAAtxWhRD;
		private KeyCollection BtcuDhDnnSEohOGNhSbOXqnStyP;
		private ValueCollection aEwRyncXwnIZMjJrXWDaBZXESTP;
		private readonly object vYiBUIHFosLSVhIQAioByfsCKmi;
		private static readonly bool SidKWeuekvleteANqUttcMdXPoQ;
		private static readonly bool gMHfftmWPtiXwIpBQtvOIqmmThy;
	
		// Properties
		public int Count { get; }
		public int TotalCount { get; }
		public KeyCollection Keys { get; }
		public ValueCollection Values { get; }
		public IEqualityComparer<TKey> KeyComparer { get; set; }
		public IEqualityComparer<TValue> ValueComparer { get; set; }
		public TValue this[TKey key] { get => default; set {} }
		public int IndexOfFirst { get; }
		public int IndexOfLast { get; }
		ICollection<TKey> IDictionary<TKey,TValue>.Keys { get; }
		ICollection<TValue> IDictionary<TKey,TValue>.Values { get; }
		bool ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
		bool ICollection.IsSynchronized { get; }
		object ICollection.SyncRoot { get; }
		bool IDictionary.IsFixedSize { get; }
		bool IDictionary.IsReadOnly { get; }
		ICollection IDictionary.Keys { get; }
		ICollection IDictionary.Values { get; }
		object IDictionary.this[object key] { get => default; set {} }
	
		// Nested types
		[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
		[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
		internal struct Entry // TypeDefIndex: 6962
		{
			// Fields
			public int hashCode;
			public int next;
			public TKey key;
			public TValue value;
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
		[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
		public struct Enumerator : IDictionaryEnumerator, IEnumerator<KeyValuePair<TKey, TValue>> // TypeDefIndex: 6963
		{
			// Fields
			internal const int DictEntry = 1; // Metadata: 0x00766622
			internal const int KeyValuePair = 2; // Metadata: 0x00766626
			private ADictionary<TKey, TValue> PPzpPGLKIynvruBNxkGUfOVeEjO;
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
			internal Enumerator(ADictionary<TKey, TValue> dictionary, int getEnumeratorRetType);
	
			// Methods
			public bool MoveNext();
			public void Dispose();
			void IEnumerator.Reset();
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
		[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
		public sealed class KeyCollection : ICollection, ICollection<TKey> // TypeDefIndex: 6964
		{
			// Fields
			private ADictionary<TKey, TValue> PPzpPGLKIynvruBNxkGUfOVeEjO;
	
			// Properties
			public int Count { get; }
			bool ICollection<TKey>.IsReadOnly { get; }
			bool ICollection.IsSynchronized { get; }
			object ICollection.SyncRoot { get; }
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
			[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
			public struct Enumerator : IEnumerator<TKey> // TypeDefIndex: 6965
			{
				// Fields
				private ADictionary<TKey, TValue> PPzpPGLKIynvruBNxkGUfOVeEjO;
				private int sTgsnEJuUoRNnuSXfCYtcCJrAEKa;
				private int nlbIzkFWqZgWHDwirMvtyFNvieiE;
				private TKey hbRfzrSblKFuxxedFtFWaiLHbtl;
	
				// Properties
				public TKey Current { get; }
				object IEnumerator.Current { get; }
	
				// Constructors
				internal Enumerator(ADictionary<TKey, TValue> dictionary);
	
				// Methods
				public void Dispose();
				public bool MoveNext();
				void IEnumerator.Reset();
			}
	
			// Constructors
			public KeyCollection(ADictionary<TKey, TValue> dictionary);
	
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
		public sealed class ValueCollection : ICollection, ICollection<TValue> // TypeDefIndex: 6966
		{
			// Fields
			private ADictionary<TKey, TValue> PPzpPGLKIynvruBNxkGUfOVeEjO;
	
			// Properties
			public int Count { get; }
			bool ICollection<TValue>.IsReadOnly { get; }
			bool ICollection.IsSynchronized { get; }
			object ICollection.SyncRoot { get; }
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
			[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
			public struct Enumerator : IEnumerator<TValue> // TypeDefIndex: 6967
			{
				// Fields
				private ADictionary<TKey, TValue> PPzpPGLKIynvruBNxkGUfOVeEjO;
				private int sTgsnEJuUoRNnuSXfCYtcCJrAEKa;
				private int nlbIzkFWqZgWHDwirMvtyFNvieiE;
				private TValue cgNhrEKxwCsXVTwGCnhEJKQDBKow;
	
				// Properties
				public TValue Current { get; }
				object IEnumerator.Current { get; }
	
				// Constructors
				internal Enumerator(ADictionary<TKey, TValue> dictionary);
	
				// Methods
				public void Dispose();
				public bool MoveNext();
				void IEnumerator.Reset();
			}
	
			// Constructors
			public ValueCollection(ADictionary<TKey, TValue> dictionary);
	
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
		public ADictionary();
		public ADictionary(IEqualityComparer<TKey> keyComparer);
		public ADictionary(IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer);
		public ADictionary(int capacity);
		public ADictionary(int capacity, IEqualityComparer<TKey> keyComparer);
		public ADictionary(int capacity, IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer);
		public ADictionary(IDictionary<TKey, TValue> dictionary);
		public ADictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> keyComparer);
		public ADictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer);
		static ADictionary();
	
		// Methods
		public void Add(TKey key, TValue value);
		public void Clear();
		public bool ContainsKey(TKey key);
		public bool ContainsValue(TValue value);
		public Enumerator GetEnumerator();
		public bool Remove(TKey key);
		public bool TryGetValue(TKey key, out TValue value);
		public TValue GetValueSafe(TKey key);
		public int IndexOfKey(TKey key);
		public int IndexOfValue(TValue value);
		public bool IsValidAt(int index);
		public TKey GetKeyAt(int index);
		public TValue GetValueAt(int index);
		public KeyValuePair<TKey, TValue> GetEntryAt(int index);
		public bool TryGetKeyAt(int index, out TKey key);
		public bool TryGetValueAt(int index, out TValue value);
		public bool TryGetEntryAt(int index, out KeyValuePair<TKey, TValue> entry);
		public bool GetNextIndex(ref int index);
		public int GetNextIndex(int index);
		public bool GetNextKey(ref int index, out TKey key);
		public bool GetNextValue(ref int index, out TValue value);
		public bool GetNextEntry(ref int index, out KeyValuePair<TKey, TValue> entry);
		public bool GetPreviousIndex(ref int index);
		public int GetPreviousIndex(int index);
		public bool GetPreviousKey(ref int index, out TKey key);
		public bool GetPreviousValue(ref int index, out TValue value);
		public bool GetPreviousEntry(ref int index, out KeyValuePair<TKey, TValue> entry);
		public bool RemoveAt(int index);
		private void bjoCRSGKcKJqCGyTAcErfuLsGvoe(KeyValuePair<TKey, TValue>[] param_0000ed56, int param_0000ed57);
		private void ItdhavHGXcUkAhyjaCFbIXENJheh(int param_0000ed58);
		private void gGuUUojlLQdvAiowetCyHBwGjGrz(TKey param_0000ed59, TValue param_0000ed5a, bool param_0000ed5b);
		private void UGfPaKfKAIAknjNVXFiWfAahWzU();
		private void UGfPaKfKAIAknjNVXFiWfAahWzU(int param_0000ed5c, bool param_0000ed5d);
		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator();
		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair);
		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair);
		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair);
		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index);
		void ICollection.CopyTo(Array array, int index);
		IEnumerator IEnumerable.GetEnumerator();
		void IDictionary.Add(object key, object value);
		bool IDictionary.Contains(object key);
		IDictionaryEnumerator IDictionary.GetEnumerator();
		void IDictionary.Remove(object key);
		private static bool JvXanRonvbXUZIaiBBNFeXVoemD(object param_0000ed6c);
		private static void TCzlRwKTuhIaiAJNIeAFFBrauxT<T>(object param_0000ed6d, string param_0000ed6e);
	}
}
