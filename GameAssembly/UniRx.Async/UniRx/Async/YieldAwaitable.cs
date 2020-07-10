/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async
{
	public struct YieldAwaitable // TypeDefIndex: 8564
	{
		// Fields
		private readonly PlayerLoopTiming timing; // 0x00
	
		// Nested types
		public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8565
		{
			// Fields
			private readonly PlayerLoopTiming timing; // 0x00
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180020DB0-0x0000000180020DC0 
	
			// Constructors
			public Awaiter(PlayerLoopTiming timing); // 0x0000000180004650-0x0000000180004660
	
			// Methods
			public void GetResult(); // 0x0000000180003310-0x0000000180003870
			public void OnCompleted(Action continuation); // 0x00000001803219D0-0x00000001803219E0
			public void UnsafeOnCompleted(Action continuation); // 0x00000001803219D0-0x00000001803219E0
		}
	
		// Constructors
		public YieldAwaitable(PlayerLoopTiming timing); // 0x0000000180004650-0x0000000180004660
	
		// Methods
		public Awaiter GetAwaiter(); // 0x0000000180004180-0x0000000180004190
		public UniTask ToUniTask(); // 0x0000000180321EF0-0x0000000180321F80
	}
}
