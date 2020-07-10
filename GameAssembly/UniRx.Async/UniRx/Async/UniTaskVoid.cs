/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async
{
	[AsyncMethodBuilder] // 0x000000018011EF60-0x000000018011EFB0
	public struct UniTaskVoid // TypeDefIndex: 8620
	{
		// Nested types
		public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8621
		{
			// Properties
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public bool IsCompleted { get; } // 0x0000000180023B90-0x0000000180023BA0 
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public void GetResult(); // 0x0000000180321910-0x0000000180321960
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public void OnCompleted(Action continuation); // 0x0000000180003310-0x0000000180003870
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public void UnsafeOnCompleted(Action continuation); // 0x0000000180003310-0x0000000180003870
		}
	
		// Methods
		public void Forget(); // 0x0000000180003310-0x0000000180003870
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public Awaiter GetAwaiter(); // 0x0000000180020DB0-0x0000000180020DC0
	}
}
