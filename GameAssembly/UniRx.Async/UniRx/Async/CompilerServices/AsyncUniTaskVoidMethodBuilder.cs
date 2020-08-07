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
	public struct AsyncUniTaskVoidMethodBuilder // TypeDefIndex: 8904
	{
		// Fields
		private Action moveNext; // 0x00
	
		// Properties
		public UniTaskVoid Task { get; } // 0x00000001800A14E0-0x00000001800A1560 
	
		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public static AsyncUniTaskVoidMethodBuilder Create(); // 0x000000018037DDC0-0x000000018037DDD0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public void SetException(Exception exception); // 0x00000001800A1480-0x00000001800A14E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public void SetResult(); // 0x0000000180003FD0-0x00000001800045A0
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
