/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	public static class Progress // TypeDefIndex: 8581
	{
		// Nested types
		private sealed class NullProgress<T> : IProgress<T> // TypeDefIndex: 8582
		{
			// Fields
			public static readonly IProgress<T> Instance;
	
			// Constructors
			private NullProgress();
			static NullProgress();
	
			// Methods
			public void Report(T value);
		}
	
		private sealed class AnonymousProgress<T> : IProgress<T> // TypeDefIndex: 8583
		{
			// Fields
			private readonly Action<T> action;
	
			// Constructors
			public AnonymousProgress(Action<T> action);
	
			// Methods
			public void Report(T value);
		}
	
		private sealed class OnlyValueChangedProgress<T> : IProgress<T> // TypeDefIndex: 8584
		{
			// Fields
			private readonly Action<T> action;
			private readonly IEqualityComparer<T> comparer;
			private bool isFirstCall;
			private T latestValue;
	
			// Constructors
			public OnlyValueChangedProgress(Action<T> action, IEqualityComparer<T> comparer);
	
			// Methods
			public void Report(T value);
		}
	
		// Methods
		public static IProgress<T> Create<T>(Action<T> handler);
		public static IProgress<T> CreateOnlyValueChanged<T>(Action<T> handler, IEqualityComparer<T> comparer = null);
	}
}
