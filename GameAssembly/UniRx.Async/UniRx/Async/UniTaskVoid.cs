/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	[AsyncMethodBuilder] // 0x0000000180284380-0x00000001802843D0
	public struct UniTaskVoid // TypeDefIndex: 8786
	{
		// Nested types
		public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8787
		{
			// Properties
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public bool IsCompleted { get; } // 0x00000001800A1560-0x00000001800A1570 
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public void GetResult(); // 0x000000018010E930-0x000000018010E980
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public void OnCompleted(Action continuation); // 0x0000000180003FD0-0x00000001800045A0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public void UnsafeOnCompleted(Action continuation); // 0x0000000180003FD0-0x00000001800045A0
		}
	
		// Methods
		public void Forget(); // 0x0000000180003FD0-0x00000001800045A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Awaiter GetAwaiter(); // 0x00000001800A14E0-0x00000001800A1560
	}
}
