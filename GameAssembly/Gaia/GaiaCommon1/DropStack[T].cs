/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace GaiaCommon1
{
	[Serializable]
	public class DropStack<T> // TypeDefIndex: 9153
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private T[] m_items;
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int m_topIndex;
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int m_count;
	
		// Properties
		public int Capacity { get; }
		public int Count { get; }
	
		// Constructors
		public DropStack(int capacity);
	
		// Methods
		public void Push(T item);
		public void Push(IEnumerable<T> items);
		public T Pop();
		public T Peek();
	}
}
