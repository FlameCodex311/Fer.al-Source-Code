/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using UniRx.Async;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Internal
{
	public abstract class ReusablePromise : IAwaiter // TypeDefIndex: 8703
	{
		// Fields
		private ExceptionDispatchInfo exception; // 0x10
		private object continuation; // 0x18
		private AwaiterStatus status; // 0x20
	
		// Properties
		public UniTask Task { get; } // 0x0000000180362190-0x00000001803621A0 
		public virtual bool IsCompleted { get; } // 0x000000018121F210-0x000000018121F220 
		public AwaiterStatus Status { get; } // 0x00000001803C2700-0x00000001803C2710 
	
		// Constructors
		protected ReusablePromise(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public virtual void GetResult(); // 0x000000018166E7D0-0x000000018166E8C0
		void IAwaiter.GetResult(); // 0x00000001806A3950-0x00000001806A3970
		public void ResetStatus(bool forceReset); // 0x000000018166EA50-0x000000018166EA70
		public virtual bool TrySetCanceled(); // 0x000000018166EB70-0x000000018166EBA0
		public virtual bool TrySetException(Exception ex); // 0x000000018166EBA0-0x000000018166EBF0
		public virtual bool TrySetResult(); // 0x000000018166EBF0-0x000000018166EC20
		private void TryInvokeContinuation(); // 0x000000018166EA70-0x000000018166EB70
		public void OnCompleted(Action action); // 0x000000018166E8C0-0x000000018166EA50
		public void UnsafeOnCompleted(Action action); // 0x000000018166E8C0-0x000000018166EA50
	}
}
