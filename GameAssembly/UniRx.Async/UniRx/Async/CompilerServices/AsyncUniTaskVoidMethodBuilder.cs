/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UniRx.Async;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.CompilerServices
{
	public struct AsyncUniTaskVoidMethodBuilder // TypeDefIndex: 8738
	{
		// Fields
		private Action moveNext; // 0x00
	
		// Properties
		public UniTaskVoid Task { get; } // 0x0000000180020DB0-0x0000000180020DC0 
	
		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public static AsyncUniTaskVoidMethodBuilder Create(); // 0x000000018035FCC0-0x000000018035FCD0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public void SetException(Exception exception); // 0x0000000180253A90-0x0000000180253B60
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public void SetResult(); // 0x0000000180003310-0x0000000180003870
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
			where TAwaiter : INotifyCompletion
			where TStateMachine : IAsyncStateMachine;
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		[SecuritySafeCritical] // 0x00000001800B4050-0x00000001800B4080
		public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine)
			where TAwaiter : ICriticalNotifyCompletion
			where TStateMachine : IAsyncStateMachine;
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public void Start<TStateMachine>(ref TStateMachine stateMachine)
			where TStateMachine : IAsyncStateMachine;
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180003310-0x0000000180003870
	}
}
