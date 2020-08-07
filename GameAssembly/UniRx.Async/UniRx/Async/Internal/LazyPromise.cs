/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Internal
{
	internal sealed class LazyPromise : IAwaiter // TypeDefIndex: 8863
	{
		// Fields
		private Func<UniTask> factory; // 0x10
		private UniTask value; // 0x18
	
		// Properties
		public bool IsCompleted { get; } // 0x0000000180E18FD0-0x0000000180E19030 
		public AwaiterStatus Status { get; } // 0x0000000180E19030-0x0000000180E19090 
	
		// Constructors
		public LazyPromise(Func<UniTask> factory); // 0x0000000180400150-0x0000000180400180
	
		// Methods
		private void Create(); // 0x0000000180E18E90-0x0000000180E18EE0
		public void GetResult(); // 0x0000000180E18EE0-0x0000000180E18F40
		void IAwaiter.GetResult(); // 0x0000000180E18EE0-0x0000000180E18F40
		public void UnsafeOnCompleted(Action continuation); // 0x0000000180E18F40-0x0000000180E18FD0
		public void OnCompleted(Action continuation); // 0x0000000180E18F40-0x0000000180E18FD0
	}
}
