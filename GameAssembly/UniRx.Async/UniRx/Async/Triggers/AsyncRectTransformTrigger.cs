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
	public class AsyncRectTransformTrigger : AsyncTriggerBase // TypeDefIndex: 8665
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> onRectTransformDimensionsChange; // 0x30
		private AsyncTriggerPromiseDictionary<AsyncUnit> onRectTransformDimensionsChanges; // 0x38
		private AsyncTriggerPromise<AsyncUnit> onRectTransformRemoved; // 0x40
		private AsyncTriggerPromiseDictionary<AsyncUnit> onRectTransformRemoveds; // 0x48
	
		// Constructors
		public AsyncRectTransformTrigger(); // 0x00000001816638C0-0x0000000181663920
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x00000001816635F0-0x0000000181663680
		private void OnRectTransformDimensionsChange(); // 0x0000000181663700-0x00000001816637A0
		public UniTask OnRectTransformDimensionsChangeAsync(CancellationToken cancellationToken = default); // 0x0000000181663680-0x0000000181663700
		private void OnRectTransformRemoved(); // 0x0000000181663820-0x00000001816638C0
		public UniTask OnRectTransformRemovedAsync(CancellationToken cancellationToken = default); // 0x00000001816637A0-0x0000000181663820
	}
}
