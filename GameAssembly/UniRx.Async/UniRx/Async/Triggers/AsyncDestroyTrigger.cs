/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;
using UnityEngine;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent] // 0x00000001800B36B0-0x00000001800B36C0
	public class AsyncDestroyTrigger : UnityEngine.MonoBehaviour // TypeDefIndex: 8647
	{
		// Fields
		private bool called; // 0x18
		private UniTaskCompletionSource promise; // 0x20
		private CancellationTokenSource cancellationTokenSource; // 0x28
		private object canellationTokenSourceOrQueue; // 0x30
	
		// Properties
		public CancellationToken CancellationToken { get; } // 0x000000018165EF70-0x000000018165EFF0 
	
		// Constructors
		public AsyncDestroyTrigger(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void OnDestroy(); // 0x000000018165EE00-0x000000018165EF70
		public UniTask OnDestroyAsync(); // 0x000000018165ED70-0x000000018165EE00
		public void AddCancellationTriggerOnDestory(CancellationTokenSource cts); // 0x000000018165EB90-0x000000018165ED70
	}
}
