/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	[AsyncMethodBuilder] // 0x000000018026FC90-0x000000018026FCE0
	public struct UniTask<T> : IEquatable<UniRx.Async.UniTask<T>> // TypeDefIndex: 8738
	{
		// Fields
		private readonly T result;
		private readonly IAwaiter<T> awaiter;
	
		// Properties
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public AwaiterStatus Status { get; }
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public bool IsCompleted { get; }
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public T Result { get; }
	
		// Nested types
		private class IsCanceledAwaiter : IAwaiter<ValueTuple<bool, T>> // TypeDefIndex: 8739
		{
			// Fields
			private readonly IAwaiter<T> awaiter;
	
			// Properties
			public bool IsCompleted { get; }
			public AwaiterStatus Status { get; }
	
			// Constructors
			public IsCanceledAwaiter(IAwaiter<T> awaiter);
	
			// Methods
			public ValueTuple<bool, T> GetResult();
			public void OnCompleted(Action continuation);
			public void UnsafeOnCompleted(Action continuation);
			void IAwaiter.GetResult();
		}
	
		public struct Awaiter : IAwaiter<T> // TypeDefIndex: 8740
		{
			// Fields
			private readonly UniTask<T> task;
	
			// Properties
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public bool IsCompleted { get; }
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public AwaiterStatus Status { get; }
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public Awaiter(UniTask<T> task);
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IAwaiter.GetResult();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public T GetResult();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public void OnCompleted(Action continuation);
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public void UnsafeOnCompleted(Action continuation);
		}
	
		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public UniTask(T result);
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public UniTask(IAwaiter<T> awaiter);
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public UniTask(Func<UniTask<T>> factory);
	
		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Awaiter GetAwaiter();
		public UniTask<ValueTuple<bool, T>> SuppressCancellationThrow();
		public bool Equals(UniTask<T> other);
		public override int GetHashCode();
		public override string ToString();
		public static implicit operator UniTask(UniTask<T> task);
	}
}
