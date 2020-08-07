/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion
{
	public class WeakReferenceTable<TKey, TValue> // TypeDefIndex: 15847
		where TKey : class
		where TValue : IDisposable
	{
		// Fields
		private List<WeakReference<TKey>> keys;
		private List<TValue> values;
	
		// Properties
		public int Count { get; }
	
		// Constructors
		public WeakReferenceTable();
	
		// Methods
		public void Clear();
		public void Add(TKey key, TValue value);
		public void Remove(TKey key);
		public bool TryGetValueWithRefCheck(TKey key, out TValue value);
		public void RemoveMissingReferences();
		private void CheckCount();
	}
}
