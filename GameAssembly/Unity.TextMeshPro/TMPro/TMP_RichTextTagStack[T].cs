/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	public struct TMP_RichTextTagStack<T> // TypeDefIndex: 8834
	{
		// Fields
		public T[] m_ItemStack;
		public int m_Index;
		private int m_Capacity;
		private T m_DefaultItem;
		private const int k_DefaultCapacity = 4; // Metadata: 0x0074361D
	
		// Constructors
		public TMP_RichTextTagStack(T[] tagStack);
		public TMP_RichTextTagStack(int capacity);
	
		// Methods
		public void Clear();
		public void SetDefault(T item);
		public void Add(T item);
		public T Remove();
		public void Push(T item);
		public T Pop();
		public T Peek();
		public T CurrentItem();
		public T PreviousItem();
	}
}
