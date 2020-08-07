/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 64: MamboJamboStudios.UnityAtomsCore.Runtime.dll - Assembly: MamboJamboStudios.UnityAtomsCore.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7743-7916

namespace UnityAtoms
{
	[EditorIcon] // 0x0000000180241130-0x0000000180241190
	public abstract class AtomList<T, E> : BaseAtomList, IList<T> // TypeDefIndex: 7852
		where E : AtomEvent<T>
	{
		// Fields
		public E Added;
		public E Removed;
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<T> list;
	
		// Properties
		public int Count { get; }
		public bool IsReadOnly { get; }
		public List<T> List { get; set; }
		public T this[int index] { get => default; set {} }
		protected override IList IList { get; }
	
		// Constructors
		protected AtomList();
	
		// Methods
		public void Add(T item);
		public bool Remove(T item);
		public bool Contains(T item);
		public T Get(int i);
		public void CopyTo(T[] array, int arrayIndex);
		IEnumerator IEnumerable.GetEnumerator();
		public IEnumerator<T> GetEnumerator();
		public int IndexOf(T item);
		public void RemoveAt(int index);
		public void Insert(int index, T item);
		public IObservable<T> ObserveAdd();
		public IObservable<T> ObserveRemove();
		public IObservable<Void> ObserveClear();
	}
}
