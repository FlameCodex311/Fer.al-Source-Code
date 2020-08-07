/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine.Events;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	public class AsyncUnityEventHandler : IAwaiter, IAsyncClickEventHandler // TypeDefIndex: 8802
	{
		// Fields
		private static Action<object> cancellationCallback; // 0x00
		private readonly UnityAction action; // 0x10
		private readonly UnityEvent unityEvent; // 0x18
		private Action continuation; // 0x20
		private CancellationTokenRegistration registration; // 0x28
		private bool isDisposed; // 0x40
		private bool callOnce; // 0x41
		private UniTask<bool>? suppressCancellationThrowTask; // 0x48
	
		// Properties
		bool IAwaiter.IsCompleted { get; } // 0x0000000180E14B20-0x0000000180E14B30 
		AwaiterStatus IAwaiter.Status { get; } // 0x0000000180E14B30-0x0000000180E14B40 
	
		// Constructors
		public AsyncUnityEventHandler(UnityEvent unityEvent, CancellationToken cancellationToken, bool callOnce); // 0x0000000180E14BA0-0x0000000180E14D00
		static AsyncUnityEventHandler(); // 0x0000000180E14B40-0x0000000180E14BA0
	
		// Methods
		public UniTask OnInvokeAsync(); // 0x0000000180411160-0x0000000180411170
		public UniTask<bool> OnInvokeAsyncSuppressCancellationThrow(); // 0x0000000180E147E0-0x0000000180E148A0
		private void Invoke(); // 0x0000000180E147C0-0x0000000180E147E0
		private static void CancellationCallback(object state); // 0x0000000180E146B0-0x0000000180E14780
		public void Dispose(); // 0x0000000180E14780-0x0000000180E147C0
		void IAwaiter.GetResult(); // 0x0000000180E14A90-0x0000000180E14B20
		void INotifyCompletion.OnCompleted(Action action); // 0x0000000180E14920-0x0000000180E149D0
		void ICriticalNotifyCompletion.UnsafeOnCompleted(Action action); // 0x0000000180E148A0-0x0000000180E14920
		UniTask IAsyncClickEventHandler.OnClickAsync(); // 0x0000000180411160-0x0000000180411170
		UniTask<bool> IAsyncClickEventHandler.OnClickAsyncSuppressCancellationThrow(); // 0x0000000180E149D0-0x0000000180E14A90
	}
}
