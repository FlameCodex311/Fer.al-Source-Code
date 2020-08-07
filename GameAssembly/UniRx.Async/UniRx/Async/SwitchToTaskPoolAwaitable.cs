/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	public struct SwitchToTaskPoolAwaitable // TypeDefIndex: 8734
	{
		// Nested types
		public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8735
		{
			// Fields
			private static readonly Action<object> switchToCallback; // 0x00
	
			// Properties
			public bool IsCompleted { get; } // 0x00000001800A14E0-0x00000001800A1560 
	
			// Constructors
			static Awaiter(); // 0x0000000180E14F90-0x0000000180E14FF0
	
			// Methods
			public void GetResult(); // 0x0000000180003FD0-0x00000001800045A0
			public void OnCompleted(Action continuation); // 0x00000001800A15B0-0x00000001800A1770
			public void UnsafeOnCompleted(Action continuation); // 0x00000001800A1980-0x00000001800A1B40
			private static void Callback(object state); // 0x0000000180E14DB0-0x0000000180E14E30
		}
	
		// Methods
		public Awaiter GetAwaiter(); // 0x00000001800A14E0-0x00000001800A1560
	}
}
