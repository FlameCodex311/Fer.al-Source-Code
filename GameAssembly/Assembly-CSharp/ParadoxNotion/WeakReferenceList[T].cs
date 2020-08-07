/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion
{
	public class WeakReferenceList<T> // TypeDefIndex: 15846
		where T : class
	{
		// Fields
		private List<WeakReference<T>> list;
	
		// Properties
		public int Count { get; }
		public T this[int i] { get => default; set {} }
	
		// Constructors
		public WeakReferenceList();
		public WeakReferenceList(int capacity);
	
		// Methods
		public void Add(T item);
		public void Remove(T item);
		public bool Contains(T item, out int index);
		public void Clear();
		public List<T> ToReferenceList();
		public static implicit operator WeakReferenceList<T>(List<T> value);
	}
}
