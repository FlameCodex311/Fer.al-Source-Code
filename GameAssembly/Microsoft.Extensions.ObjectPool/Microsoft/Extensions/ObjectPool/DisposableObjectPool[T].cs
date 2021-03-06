﻿/*
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
	internal sealed class DisposableObjectPool<T> : DefaultObjectPool<T>, IDisposable // TypeDefIndex: 7923
		where T : class
	{
		// Fields
		private bool _isDisposed;
	
		// Constructors
		public DisposableObjectPool(IPooledObjectPolicy<T> policy, int maximumRetained);
	
		// Methods
		public override T Get();
		public override void Return(T obj);
		private bool ReturnCore(T obj);
		public void Dispose();
		private void DisposeItem(T item);
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <Get>g__ThrowObjectDisposedException|3_0();
	}
}
