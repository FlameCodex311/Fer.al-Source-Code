/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Internal
{
	internal sealed class ArrayPool<T> // TypeDefIndex: 8855
	{
		// Fields
		private const int DefaultMaxNumberOfArraysPerBucket = 50; // Metadata: 0x007780D7
		private static readonly T[] EmptyArray;
		public static readonly ArrayPool<T> Shared;
		private readonly MinimumQueue<T[]>[] buckets;
		private readonly SpinLock[] locks;
	
		// Constructors
		private ArrayPool();
		static ArrayPool();
	
		// Methods
		public T[] Rent(int minimumLength);
		public void Return(T[] array, bool clearArray = false /* Metadata: 0x007780D6 */);
		private static int CalculateSize(int size);
		private static int GetQueueIndex(int size);
	}
}
