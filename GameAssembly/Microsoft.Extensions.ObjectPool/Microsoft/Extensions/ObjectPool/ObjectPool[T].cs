/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

// Image 65: Microsoft.Extensions.ObjectPool.dll - Assembly: Microsoft.Extensions.ObjectPool, Version=3.1.3.0, Culture=neutral, PublicKeyToken=adb9793829ddae60 - Types 7917-7929

namespace Microsoft.Extensions.ObjectPool
{
	public abstract class ObjectPool<T> // TypeDefIndex: 7925
		where T : class
	{
		// Constructors
		protected ObjectPool();
	
		// Methods
		public abstract T Get();
		public abstract void Return(T obj);
	}
}
