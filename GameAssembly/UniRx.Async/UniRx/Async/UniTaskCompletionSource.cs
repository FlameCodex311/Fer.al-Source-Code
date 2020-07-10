/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async
{
	public class UniTaskCompletionSource : IAwaiter, IPromise // TypeDefIndex: 8582
	{
		// Fields
		private const int Pending = 0; // Metadata: 0x00743397
		private const int Succeeded = 1; // Metadata: 0x0074339B
		private const int Faulted = 2; // Metadata: 0x0074339F
		private const int Canceled = 3; // Metadata: 0x007433A3
		private int state; // 0x10
		private bool handled; // 0x14
		private ExceptionHolder exception; // 0x18
		private object continuation; // 0x20
	
		// Properties
		AwaiterStatus IAwaiter.Status { get; } // 0x000000018036CFF0-0x000000018036D000 
		bool IAwaiter.IsCompleted { get; } // 0x000000018195A200-0x000000018195A210 
		public UniTask Task { get; } // 0x0000000180362190-0x00000001803621A0 
	
		// Constructors
		public UniTaskCompletionSource(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		[Conditional] // 0x00000001800C0AC0-0x00000001800C0AF0
		internal void MarkHandled(); // 0x00000001820E1B60-0x00000001820E1B70
		void IAwaiter.GetResult(); // 0x00000001820E2130-0x00000001820E2250
		void ICriticalNotifyCompletion.UnsafeOnCompleted(Action action); // 0x00000001820E1B70-0x00000001820E1DC0
		private void TryInvokeContinuation(); // 0x00000001820E1E10-0x00000001820E1F70
		public bool TrySetResult(); // 0x00000001820E20F0-0x00000001820E2130
		public bool TrySetException(Exception exception); // 0x00000001820E2050-0x00000001820E20F0
		public bool TrySetCanceled(); // 0x00000001820E2010-0x00000001820E2050
		public bool TrySetCanceled(OperationCanceledException exception); // 0x00000001820E1F70-0x00000001820E2010
		void INotifyCompletion.OnCompleted(Action continuation); // 0x00000001820E1DC0-0x00000001820E1E10
	}
}
