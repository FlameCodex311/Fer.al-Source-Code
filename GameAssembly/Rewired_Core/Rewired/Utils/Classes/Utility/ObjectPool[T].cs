/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal class ObjectPool<T> : IObjectPool<T>, IObjectPool // TypeDefIndex: 7072
		where T : class
	{
		// Fields
		protected readonly Queue<T> _pool;
		protected readonly Func<T> _createInstanceDelegate;
		protected readonly Action<T> _processOnReturnDelegate;
		private ulong zmVTMZhvzUQzWQrGMGOGKzlVJbw;
	
		// Properties
		protected ulong InstanceCount { get; }
	
		// Constructors
		public ObjectPool(int startingSize, Func<T> createInstanceDelegate, Action<T> processOnReturnDelegate = null);
		public ObjectPool(Func<T> instancerDelegate);
	
		// Methods
		public void Clear(bool reduceSize = false /* Metadata: 0x0076697C */);
		public T Get();
		public bool Return(T item);
		object IObjectPool.Get();
		bool IObjectPool.Return(object param_0000f61d);
		protected T CreateInstance();
		protected ulong IncrementInstanceCount();
	}
}
