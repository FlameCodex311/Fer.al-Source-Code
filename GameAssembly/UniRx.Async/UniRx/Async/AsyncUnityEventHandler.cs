/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine.Events;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async
{
	public class AsyncUnityEventHandler : IAwaiter, IAsyncClickEventHandler // TypeDefIndex: 8636
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
		bool IAwaiter.IsCompleted { get; } // 0x00000001810EC120-0x00000001810EC130 
		AwaiterStatus IAwaiter.Status { get; } // 0x00000001810EC130-0x00000001810EC140 
	
		// Constructors
		public AsyncUnityEventHandler(UnityEvent unityEvent, CancellationToken cancellationToken, bool callOnce); // 0x0000000181667450-0x00000001816675B0
		static AsyncUnityEventHandler(); // 0x00000001816673F0-0x0000000181667450
	
		// Methods
		public UniTask OnInvokeAsync(); // 0x0000000180362190-0x00000001803621A0
		public UniTask<bool> OnInvokeAsyncSuppressCancellationThrow(); // 0x00000001816670B0-0x0000000181667170
		private void Invoke(); // 0x0000000181667090-0x00000001816670B0
		private static void CancellationCallback(object state); // 0x0000000181666F70-0x0000000181667050
		public void Dispose(); // 0x0000000181667050-0x0000000181667090
		void IAwaiter.GetResult(); // 0x0000000181667360-0x00000001816673F0
		void INotifyCompletion.OnCompleted(Action action); // 0x00000001816671F0-0x00000001816672A0
		void ICriticalNotifyCompletion.UnsafeOnCompleted(Action action); // 0x0000000181667170-0x00000001816671F0
		UniTask IAsyncClickEventHandler.OnClickAsync(); // 0x0000000180362190-0x00000001803621A0
		UniTask<bool> IAsyncClickEventHandler.OnClickAsyncSuppressCancellationThrow(); // 0x00000001816672A0-0x0000000181667360
	}
}
