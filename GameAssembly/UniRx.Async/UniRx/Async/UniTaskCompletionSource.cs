/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	public class UniTaskCompletionSource : IAwaiter, IPromise // TypeDefIndex: 8748
	{
		// Fields
		private const int Pending = 0; // Metadata: 0x00778085
		private const int Succeeded = 1; // Metadata: 0x00778089
		private const int Faulted = 2; // Metadata: 0x0077808D
		private const int Canceled = 3; // Metadata: 0x00778091
		private int state; // 0x10
		private bool handled; // 0x14
		private ExceptionHolder exception; // 0x18
		private object continuation; // 0x20
	
		// Properties
		AwaiterStatus IAwaiter.Status { get; } // 0x0000000180387590-0x0000000180387930 
		bool IAwaiter.IsCompleted { get; } // 0x00000001809E9F80-0x00000001809E9F90 
		public UniTask Task { get; } // 0x0000000180411160-0x0000000180411170 
	
		// Constructors
		public UniTaskCompletionSource(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		[Conditional] // 0x00000001801D54F0-0x00000001801D5520
		internal void MarkHandled(); // 0x0000000181AC8420-0x0000000181AC8430
		void IAwaiter.GetResult(); // 0x0000000181AC89E0-0x0000000181AC8AF0
		void ICriticalNotifyCompletion.UnsafeOnCompleted(Action action); // 0x0000000181AC8430-0x0000000181AC8670
		private void TryInvokeContinuation(); // 0x0000000181AC86C0-0x0000000181AC8820
		public bool TrySetResult(); // 0x0000000181AC89A0-0x0000000181AC89E0
		public bool TrySetException(Exception exception); // 0x0000000181AC8900-0x0000000181AC89A0
		public bool TrySetCanceled(); // 0x0000000181AC88C0-0x0000000181AC8900
		public bool TrySetCanceled(OperationCanceledException exception); // 0x0000000181AC8820-0x0000000181AC88C0
		void INotifyCompletion.OnCompleted(Action continuation); // 0x0000000181AC8670-0x0000000181AC86C0
	}
}
