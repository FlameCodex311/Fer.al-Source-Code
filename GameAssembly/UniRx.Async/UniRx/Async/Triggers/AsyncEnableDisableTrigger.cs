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
	public class AsyncEnableDisableTrigger : AsyncTriggerBase // TypeDefIndex: 8816
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> onEnable; // 0x30
		private AsyncTriggerPromiseDictionary<AsyncUnit> onEnables; // 0x38
		private AsyncTriggerPromise<AsyncUnit> onDisable; // 0x40
		private AsyncTriggerPromiseDictionary<AsyncUnit> onDisables; // 0x48
	
		// Constructors
		public AsyncEnableDisableTrigger(); // 0x0000000180E0CE80-0x0000000180E0CEE0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E0CBB0-0x0000000180E0CC40
		private void OnEnable(); // 0x0000000180E0CDE0-0x0000000180E0CE80
		public UniTask OnEnableAsync(CancellationToken cancellationToken = default); // 0x0000000180E0CD60-0x0000000180E0CDE0
		private void OnDisable(); // 0x0000000180E0CCC0-0x0000000180E0CD60
		public UniTask OnDisableAsync(CancellationToken cancellationToken = default); // 0x0000000180E0CC40-0x0000000180E0CCC0
	}
}
