/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;
using UnityEngine;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class AsyncDestroyTrigger : UnityEngine.MonoBehaviour // TypeDefIndex: 8813
	{
		// Fields
		private bool called; // 0x18
		private UniTaskCompletionSource promise; // 0x20
		private CancellationTokenSource cancellationTokenSource; // 0x28
		private object canellationTokenSourceOrQueue; // 0x30
	
		// Properties
		public CancellationToken CancellationToken { get; } // 0x0000000180E0C7D0-0x0000000180E0C850 
	
		// Constructors
		public AsyncDestroyTrigger(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void OnDestroy(); // 0x0000000180E0C670-0x0000000180E0C7D0
		public UniTask OnDestroyAsync(); // 0x0000000180E0C5E0-0x0000000180E0C670
		public void AddCancellationTriggerOnDestory(CancellationTokenSource cts); // 0x0000000180E0C400-0x0000000180E0C5E0
	}
}
