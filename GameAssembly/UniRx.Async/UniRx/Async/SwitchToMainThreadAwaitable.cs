/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async
{
	public struct SwitchToMainThreadAwaitable // TypeDefIndex: 8567
	{
		// Nested types
		public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8568
		{
			// Properties
			public bool IsCompleted { get; } // 0x0000000180254140-0x00000001802541F0 
	
			// Methods
			public void GetResult(); // 0x0000000180003310-0x0000000180003870
			public void OnCompleted(Action continuation); // 0x0000000180253D60-0x0000000180253D70
			public void UnsafeOnCompleted(Action continuation); // 0x0000000180253D60-0x0000000180253D70
		}
	
		// Methods
		public Awaiter GetAwaiter(); // 0x0000000180020DB0-0x0000000180020DC0
	}
}
