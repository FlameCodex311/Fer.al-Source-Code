﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Internal
{
	internal class DisposedObserver<T> : IObserver<T> // TypeDefIndex: 8900
	{
		// Fields
		public static readonly DisposedObserver<T> Instance;
	
		// Constructors
		private DisposedObserver();
		static DisposedObserver();
	
		// Methods
		public void OnCompleted();
		public void OnError(Exception error);
		public void OnNext(T value);
	}
}
