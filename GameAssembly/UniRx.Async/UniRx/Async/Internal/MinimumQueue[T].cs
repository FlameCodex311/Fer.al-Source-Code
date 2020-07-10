/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Internal
{
	internal class MinimumQueue<T> // TypeDefIndex: 8699
	{
		// Fields
		private const int MinimumGrow = 4; // Metadata: 0x007433F5
		private const int GrowFactor = 200; // Metadata: 0x007433F9
		private T[] array;
		private int head;
		private int tail;
		private int size;
	
		// Properties
		public int Count { get; }
	
		// Constructors
		public MinimumQueue(int capacity);
	
		// Methods
		public T Peek();
		public void Enqueue(T item);
		public T Dequeue();
		private void Grow();
		private void SetCapacity(int capacity);
		private void MoveNext(ref int index);
		private void ThrowForEmptyQueue();
	}
}
