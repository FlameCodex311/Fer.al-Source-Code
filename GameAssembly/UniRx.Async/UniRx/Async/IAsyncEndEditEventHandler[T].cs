﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	public interface IAsyncEndEditEventHandler<T> : IDisposable // TypeDefIndex: 8801
	{
		// Methods
		UniTask<T> OnEndEditAsync();
		UniTask<ValueTuple<bool, T>> OnEndEditAsyncSuppressCancellationThrow();
	}
}
