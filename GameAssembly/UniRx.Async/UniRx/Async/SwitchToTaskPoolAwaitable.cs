/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async
{
	public struct SwitchToTaskPoolAwaitable // TypeDefIndex: 8571
	{
		// Nested types
		public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8572
		{
			// Fields
			private static readonly Action<object> switchToCallback; // 0x00
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180020DB0-0x0000000180020DC0 
	
			// Constructors
			static Awaiter(); // 0x0000000181667F10-0x0000000181667F70
	
			// Methods
			public void GetResult(); // 0x0000000180003310-0x0000000180003870
			public void OnCompleted(Action continuation); // 0x0000000180253B90-0x0000000180253D60
			public void UnsafeOnCompleted(Action continuation); // 0x0000000180253F70-0x0000000180254140
			private static void Callback(object state); // 0x0000000181667D30-0x0000000181667DB0
		}
	
		// Methods
		public Awaiter GetAwaiter(); // 0x0000000180020DB0-0x0000000180020DC0
	}
}
