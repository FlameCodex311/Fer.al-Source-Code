/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Internal
{
	internal sealed class LazyPromise : IAwaiter // TypeDefIndex: 8697
	{
		// Fields
		private Func<UniTask> factory; // 0x10
		private UniTask value; // 0x18
	
		// Properties
		public bool IsCompleted { get; } // 0x000000018166C2A0-0x000000018166C330 
		public AwaiterStatus Status { get; } // 0x000000018166C330-0x000000018166C3C0 
	
		// Constructors
		public LazyPromise(Func<UniTask> factory); // 0x000000018037D3F0-0x000000018037D420
	
		// Methods
		private void Create(); // 0x000000018166C140-0x000000018166C190
		public void GetResult(); // 0x000000018166C190-0x000000018166C220
		void IAwaiter.GetResult(); // 0x000000018166C190-0x000000018166C220
		public void UnsafeOnCompleted(Action continuation); // 0x000000018166C220-0x000000018166C2A0
		public void OnCompleted(Action continuation); // 0x000000018166C220-0x000000018166C2A0
	}
}
