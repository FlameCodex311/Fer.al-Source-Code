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
	public struct AsyncUniTaskMethodBuilder // TypeDefIndex: 8902
	{
		// Fields
		private UniTaskCompletionSource promise; // 0x00
		private Action moveNext; // 0x08
	
		// Properties
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public UniTask Task { get; } // 0x00000001800A13B0-0x00000001800A1480 
	
		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public static AsyncUniTaskMethodBuilder Create(); // 0x0000000180A67270-0x0000000180A67280
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public void SetException(Exception exception); // 0x00000001800A1240-0x00000001800A1330
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public void SetResult(); // 0x00000001800A1330-0x00000001800A13B0
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
		public void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180003FD0-0x00000001800045A0
	}
}
