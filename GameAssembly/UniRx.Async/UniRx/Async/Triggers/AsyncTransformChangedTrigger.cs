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
	public class AsyncTransformChangedTrigger : AsyncTriggerBase // TypeDefIndex: 8837
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> onBeforeTransformParentChanged; // 0x30
		private AsyncTriggerPromiseDictionary<AsyncUnit> onBeforeTransformParentChangeds; // 0x38
		private AsyncTriggerPromise<AsyncUnit> onTransformParentChanged; // 0x40
		private AsyncTriggerPromiseDictionary<AsyncUnit> onTransformParentChangeds; // 0x48
		private AsyncTriggerPromise<AsyncUnit> onTransformChildrenChanged; // 0x50
		private AsyncTriggerPromiseDictionary<AsyncUnit> onTransformChildrenChangeds; // 0x58
	
		// Constructors
		public AsyncTransformChangedTrigger(); // 0x0000000180E11A60-0x0000000180E11AC0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E11650-0x0000000180E11700
		private void OnBeforeTransformParentChanged(); // 0x0000000180E11780-0x0000000180E11820
		public UniTask OnBeforeTransformParentChangedAsync(CancellationToken cancellationToken = default); // 0x0000000180E11700-0x0000000180E11780
		private void OnTransformParentChanged(); // 0x0000000180E119C0-0x0000000180E11A60
		public UniTask OnTransformParentChangedAsync(CancellationToken cancellationToken = default); // 0x0000000180E11940-0x0000000180E119C0
		private void OnTransformChildrenChanged(); // 0x0000000180E118A0-0x0000000180E11940
		public UniTask OnTransformChildrenChangedAsync(CancellationToken cancellationToken = default); // 0x0000000180E11820-0x0000000180E118A0
	}
}
