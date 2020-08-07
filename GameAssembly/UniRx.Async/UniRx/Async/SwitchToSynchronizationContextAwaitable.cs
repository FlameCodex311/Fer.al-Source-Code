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
	public struct SwitchToSynchronizationContextAwaitable // TypeDefIndex: 8736
	{
		// Fields
		private readonly SynchronizationContext synchronizationContext; // 0x00
	
		// Nested types
		public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8737
		{
			// Fields
			private static readonly SendOrPostCallback switchToCallback; // 0x00
			private readonly SynchronizationContext synchronizationContext; // 0x00
	
			// Properties
			public bool IsCompleted { get; } // 0x00000001800A14E0-0x00000001800A1560 
	
			// Constructors
			public Awaiter(SynchronizationContext synchronizationContext); // 0x000000018001A8F0-0x000000018001A900
			static Awaiter(); // 0x0000000180E14FF0-0x0000000180E150B0
	
			// Methods
			public void GetResult(); // 0x0000000180003FD0-0x00000001800045A0
			public void OnCompleted(Action continuation); // 0x00000001800A1780-0x00000001800A1810
			public void UnsafeOnCompleted(Action continuation); // 0x00000001800A1880-0x00000001800A1910
			private static void Callback(object state); // 0x0000000180E14E30-0x0000000180E14F30
		}
	
		// Constructors
		public SwitchToSynchronizationContextAwaitable(SynchronizationContext synchronizationContext); // 0x000000018001A8F0-0x000000018001A900
	
		// Methods
		public Awaiter GetAwaiter(); // 0x000000018001A8D0-0x000000018001A8E0
	}
}
