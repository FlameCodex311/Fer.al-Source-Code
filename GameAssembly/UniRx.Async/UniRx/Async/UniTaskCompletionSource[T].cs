/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	public class UniTaskCompletionSource<T> : IAwaiter<T>, IPromise<T> // TypeDefIndex: 8749
	{
		// Fields
		private const int Pending = 0; // Metadata: 0x00778095
		private const int Succeeded = 1; // Metadata: 0x00778099
		private const int Faulted = 2; // Metadata: 0x0077809D
		private const int Canceled = 3; // Metadata: 0x007780A1
		private int state;
		private T value;
		private bool handled;
		private ExceptionHolder exception;
		private object continuation;
	
		// Properties
		bool IAwaiter.IsCompleted { get; }
		public UniTask<T> Task { get; }
		public UniTask UnitTask { get; }
		AwaiterStatus IAwaiter.Status { get; }
	
		// Constructors
		public UniTaskCompletionSource();
	
		// Methods
		[Conditional] // 0x00000001801D54F0-0x00000001801D5520
		internal void MarkHandled();
		T IAwaiter<T>.GetResult();
		void ICriticalNotifyCompletion.UnsafeOnCompleted(Action action);
		private void TryInvokeContinuation();
		public bool TrySetResult(T value);
		public bool TrySetException(Exception exception);
		public bool TrySetCanceled();
		public bool TrySetCanceled(OperationCanceledException exception);
		void IAwaiter.GetResult();
		void INotifyCompletion.OnCompleted(Action continuation);
	}
}
