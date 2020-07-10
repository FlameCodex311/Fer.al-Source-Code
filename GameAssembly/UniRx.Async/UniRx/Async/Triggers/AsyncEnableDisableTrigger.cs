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
	public class AsyncEnableDisableTrigger : AsyncTriggerBase // TypeDefIndex: 8650
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> onEnable; // 0x30
		private AsyncTriggerPromiseDictionary<AsyncUnit> onEnables; // 0x38
		private AsyncTriggerPromise<AsyncUnit> onDisable; // 0x40
		private AsyncTriggerPromiseDictionary<AsyncUnit> onDisables; // 0x48
	
		// Constructors
		public AsyncEnableDisableTrigger(); // 0x000000018165F620-0x000000018165F680
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x000000018165F350-0x000000018165F3E0
		private void OnEnable(); // 0x000000018165F580-0x000000018165F620
		public UniTask OnEnableAsync(CancellationToken cancellationToken = default); // 0x000000018165F500-0x000000018165F580
		private void OnDisable(); // 0x000000018165F460-0x000000018165F500
		public UniTask OnDisableAsync(CancellationToken cancellationToken = default); // 0x000000018165F3E0-0x000000018165F460
	}
}
