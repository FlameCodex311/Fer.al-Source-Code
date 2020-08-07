/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Internal
{
	internal static class ArrayPoolUtil // TypeDefIndex: 8856
	{
		// Nested types
		public struct RentArray<T> : IDisposable // TypeDefIndex: 8857
		{
			// Fields
			public readonly T[] Array;
			public readonly int Length;
			private ArrayPool<T> pool;
	
			// Constructors
			public RentArray(T[] array, int length, ArrayPool<T> pool);
	
			// Methods
			public void Dispose();
			public void DisposeManually(bool clearArray);
		}
	
		// Methods
		internal static void EnsureCapacity<T>(ref T[] array, int index, ArrayPool<T> pool);
		private static void EnsureCapacityCore<T>(ref T[] array, int index, ArrayPool<T> pool);
		public static RentArray<T> Materialize<T>(IEnumerable<T> source);
	}
}
