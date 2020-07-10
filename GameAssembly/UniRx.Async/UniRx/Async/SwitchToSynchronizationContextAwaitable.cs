/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async
{
	public struct SwitchToSynchronizationContextAwaitable // TypeDefIndex: 8573
	{
		// Fields
		private readonly SynchronizationContext synchronizationContext; // 0x00
	
		// Nested types
		public struct Awaiter : ICriticalNotifyCompletion // TypeDefIndex: 8574
		{
			// Fields
			private static readonly SendOrPostCallback switchToCallback; // 0x00
			private readonly SynchronizationContext synchronizationContext; // 0x00
	
			// Properties
			public bool IsCompleted { get; } // 0x0000000180020DB0-0x0000000180020DC0 
	
			// Constructors
			public Awaiter(SynchronizationContext synchronizationContext); // 0x0000000180004C60-0x0000000180004C90
			static Awaiter(); // 0x0000000181667F70-0x0000000181668040
	
			// Methods
			public void GetResult(); // 0x0000000180003310-0x0000000180003870
			public void OnCompleted(Action continuation); // 0x0000000180253D70-0x0000000180253E00
			public void UnsafeOnCompleted(Action continuation); // 0x0000000180253E70-0x0000000180253F00
			private static void Callback(object state); // 0x0000000181667DB0-0x0000000181667EB0
		}
	
		// Constructors
		public SwitchToSynchronizationContextAwaitable(SynchronizationContext synchronizationContext); // 0x0000000180004C60-0x0000000180004C90
	
		// Methods
		public Awaiter GetAwaiter(); // 0x0000000180004C30-0x0000000180004C40
	}
}
