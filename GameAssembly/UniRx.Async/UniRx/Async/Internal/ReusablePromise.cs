/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using UniRx.Async;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Internal
{
	public abstract class ReusablePromise : IAwaiter // TypeDefIndex: 8869
	{
		// Fields
		private ExceptionDispatchInfo exception; // 0x10
		private object continuation; // 0x18
		private AwaiterStatus status; // 0x20
	
		// Properties
		public UniTask Task { get; } // 0x0000000180411160-0x0000000180411170 
		public virtual bool IsCompleted { get; } // 0x000000018066B070-0x000000018066B080 
		public AwaiterStatus Status { get; } // 0x00000001803FB670-0x00000001803FB680 
	
		// Constructors
		protected ReusablePromise(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public virtual void GetResult(); // 0x0000000180E1B260-0x0000000180E1B350
		void IAwaiter.GetResult(); // 0x000000018037F800-0x000000018037F820
		public void ResetStatus(bool forceReset); // 0x0000000180E1B4E0-0x0000000180E1B500
		public virtual bool TrySetCanceled(); // 0x0000000180E1B600-0x0000000180E1B630
		public virtual bool TrySetException(Exception ex); // 0x0000000180E1B630-0x0000000180E1B680
		public virtual bool TrySetResult(); // 0x0000000180E1B680-0x0000000180E1B6B0
		private void TryInvokeContinuation(); // 0x0000000180E1B500-0x0000000180E1B600
		public void OnCompleted(Action action); // 0x0000000180E1B350-0x0000000180E1B4E0
		public void UnsafeOnCompleted(Action action); // 0x0000000180E1B350-0x0000000180E1B4E0
	}
}
