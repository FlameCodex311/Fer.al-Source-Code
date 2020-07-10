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
	public class AsyncTransformChangedTrigger : AsyncTriggerBase // TypeDefIndex: 8671
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> onBeforeTransformParentChanged; // 0x30
		private AsyncTriggerPromiseDictionary<AsyncUnit> onBeforeTransformParentChangeds; // 0x38
		private AsyncTriggerPromise<AsyncUnit> onTransformParentChanged; // 0x40
		private AsyncTriggerPromiseDictionary<AsyncUnit> onTransformParentChangeds; // 0x48
		private AsyncTriggerPromise<AsyncUnit> onTransformChildrenChanged; // 0x50
		private AsyncTriggerPromiseDictionary<AsyncUnit> onTransformChildrenChangeds; // 0x58
	
		// Constructors
		public AsyncTransformChangedTrigger(); // 0x0000000181664320-0x0000000181664380
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000181663F10-0x0000000181663FC0
		private void OnBeforeTransformParentChanged(); // 0x0000000181664040-0x00000001816640E0
		public UniTask OnBeforeTransformParentChangedAsync(CancellationToken cancellationToken = default); // 0x0000000181663FC0-0x0000000181664040
		private void OnTransformParentChanged(); // 0x0000000181664280-0x0000000181664320
		public UniTask OnTransformParentChangedAsync(CancellationToken cancellationToken = default); // 0x0000000181664200-0x0000000181664280
		private void OnTransformChildrenChanged(); // 0x0000000181664160-0x0000000181664200
		public UniTask OnTransformChildrenChangedAsync(CancellationToken cancellationToken = default); // 0x00000001816640E0-0x0000000181664160
	}
}
