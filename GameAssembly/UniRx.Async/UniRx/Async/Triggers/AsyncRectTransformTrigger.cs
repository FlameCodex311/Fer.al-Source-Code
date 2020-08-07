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

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class AsyncRectTransformTrigger : AsyncTriggerBase // TypeDefIndex: 8831
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> onRectTransformDimensionsChange; // 0x30
		private AsyncTriggerPromiseDictionary<AsyncUnit> onRectTransformDimensionsChanges; // 0x38
		private AsyncTriggerPromise<AsyncUnit> onRectTransformRemoved; // 0x40
		private AsyncTriggerPromiseDictionary<AsyncUnit> onRectTransformRemoveds; // 0x48
	
		// Constructors
		public AsyncRectTransformTrigger(); // 0x0000000180E11000-0x0000000180E11060
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E10D30-0x0000000180E10DC0
		private void OnRectTransformDimensionsChange(); // 0x0000000180E10E40-0x0000000180E10EE0
		public UniTask OnRectTransformDimensionsChangeAsync(CancellationToken cancellationToken = default); // 0x0000000180E10DC0-0x0000000180E10E40
		private void OnRectTransformRemoved(); // 0x0000000180E10F60-0x0000000180E11000
		public UniTask OnRectTransformRemovedAsync(CancellationToken cancellationToken = default); // 0x0000000180E10EE0-0x0000000180E10F60
	}
}
