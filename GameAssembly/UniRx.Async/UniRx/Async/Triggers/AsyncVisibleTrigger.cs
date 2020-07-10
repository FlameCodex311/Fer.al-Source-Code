/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;
using UnityEngine;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent] // 0x00000001800B36B0-0x00000001800B36C0
	public class AsyncVisibleTrigger : AsyncTriggerBase // TypeDefIndex: 8688
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> onBecameInvisible; // 0x30
		private AsyncTriggerPromiseDictionary<AsyncUnit> onBecameInvisibles; // 0x38
		private AsyncTriggerPromise<AsyncUnit> onBecameVisible; // 0x40
		private AsyncTriggerPromiseDictionary<AsyncUnit> onBecameVisibles; // 0x48
	
		// Constructors
		public AsyncVisibleTrigger(); // 0x0000000181667C20-0x0000000181667C80
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000181667950-0x00000001816679E0
		private void OnBecameInvisible(); // 0x0000000181667A60-0x0000000181667B00
		public UniTask OnBecameInvisibleAsync(CancellationToken cancellationToken = default); // 0x00000001816679E0-0x0000000181667A60
		private void OnBecameVisible(); // 0x0000000181667B80-0x0000000181667C20
		public UniTask OnBecameVisibleAsync(CancellationToken cancellationToken = default); // 0x0000000181667B00-0x0000000181667B80
	}
}
