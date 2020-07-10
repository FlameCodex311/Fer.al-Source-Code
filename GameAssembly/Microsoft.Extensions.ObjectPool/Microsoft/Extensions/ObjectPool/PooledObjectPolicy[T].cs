/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

// Image 64: Microsoft.Extensions.ObjectPool.dll - Assembly: Microsoft.Extensions.ObjectPool, Version=3.1.3.0, Culture=neutral, PublicKeyToken=adb9793829ddae60 - Types 7751-7763

namespace Microsoft.Extensions.ObjectPool
{
	public abstract class PooledObjectPolicy<T> : IPooledObjectPolicy<T> // TypeDefIndex: 7762
	{
		// Constructors
		protected PooledObjectPolicy();
	
		// Methods
		public abstract T Create();
		public abstract bool Return(T obj);
	}
}
