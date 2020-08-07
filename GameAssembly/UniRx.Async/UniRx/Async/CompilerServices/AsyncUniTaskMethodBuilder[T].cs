/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UniRx.Async;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.CompilerServices
{
	public struct AsyncUniTaskMethodBuilder<T> // TypeDefIndex: 8903
	{
		// Fields
		private T result;
		private UniTaskCompletionSource<T> promise;
		private Action moveNext;
	
		// Properties
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public UniTask<T> Task { get; }
	
		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public static AsyncUniTaskMethodBuilder<T> Create();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public void SetException(Exception exception);
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public void SetResult(T result);
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
			where TAwaiter : INotifyCompletion
			where TStateMachine : IAsyncStateMachine;
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		[SecuritySafeCritical] // 0x00000001801CDDD0-0x00000001801CDE00
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
			where TAwaiter : ICriticalNotifyCompletion
			where TStateMachine : IAsyncStateMachine;
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public void Start<TStateMachine>(ref TStateMachine stateMachine)
			where TStateMachine : IAsyncStateMachine;
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public void SetStateMachine(IAsyncStateMachine stateMachine);
	}
}
