/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	public struct SwitchToThreadPoolAwaitable // TypeDefIndex: 8732
	{
		// Nested types
		public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8733
		{
			// Fields
			private static readonly WaitCallback switchToCallback; // 0x00
	
			// Properties
			public bool IsCompleted { get; } // 0x00000001800A14E0-0x00000001800A1560 
	
			// Constructors
			static Awaiter(); // 0x0000000180E14F30-0x0000000180E14F90
	
			// Methods
			public void GetResult(); // 0x0000000180003FD0-0x00000001800045A0
			public void OnCompleted(Action continuation); // 0x00000001800A1810-0x00000001800A1880
			public void UnsafeOnCompleted(Action continuation); // 0x00000001800A1910-0x00000001800A1980
			private static void Callback(object state); // 0x0000000180E14D30-0x0000000180E14DB0
		}
	
		// Methods
		public Awaiter GetAwaiter(); // 0x00000001800A14E0-0x00000001800A1560
	}
}
