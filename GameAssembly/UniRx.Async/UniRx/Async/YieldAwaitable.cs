/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	public struct YieldAwaitable // TypeDefIndex: 8727
	{
		// Fields
		private readonly PlayerLoopTiming timing; // 0x00
	
		// Nested types
		public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8728
		{
			// Fields
			private readonly PlayerLoopTiming timing; // 0x00
	
			// Properties
			public bool IsCompleted { get; } // 0x00000001800A14E0-0x00000001800A1560 
	
			// Constructors
			public Awaiter(PlayerLoopTiming timing); // 0x0000000180007630-0x0000000180007640
	
			// Methods
			public void GetResult(); // 0x0000000180003FD0-0x00000001800045A0
			public void OnCompleted(Action continuation); // 0x000000018010E9F0-0x000000018010EA00
			public void UnsafeOnCompleted(Action continuation); // 0x000000018010E9F0-0x000000018010EA00
		}
	
		// Constructors
		public YieldAwaitable(PlayerLoopTiming timing); // 0x0000000180007630-0x0000000180007640
	
		// Methods
		public Awaiter GetAwaiter(); // 0x0000000180004EC0-0x0000000180004ED0
		public UniTask ToUniTask(); // 0x000000018010F300-0x000000018010F3E0
	}
}
