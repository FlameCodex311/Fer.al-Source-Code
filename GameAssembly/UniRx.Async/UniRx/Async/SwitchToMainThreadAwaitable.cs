/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	public struct SwitchToMainThreadAwaitable // TypeDefIndex: 8730
	{
		// Nested types
		public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8731
		{
			// Properties
			public bool IsCompleted { get; } // 0x00000001800A1B40-0x00000001800A1BE0 
	
			// Methods
			public void GetResult(); // 0x0000000180003FD0-0x00000001800045A0
			public void OnCompleted(Action continuation); // 0x00000001800A1770-0x00000001800A1780
			public void UnsafeOnCompleted(Action continuation); // 0x00000001800A1770-0x00000001800A1780
		}
	
		// Methods
		public Awaiter GetAwaiter(); // 0x00000001800A14E0-0x00000001800A1560
	}
}
