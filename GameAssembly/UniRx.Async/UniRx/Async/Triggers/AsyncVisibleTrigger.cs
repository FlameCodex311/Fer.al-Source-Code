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
	public class AsyncVisibleTrigger : AsyncTriggerBase // TypeDefIndex: 8854
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> onBecameInvisible; // 0x30
		private AsyncTriggerPromiseDictionary<AsyncUnit> onBecameInvisibles; // 0x38
		private AsyncTriggerPromise<AsyncUnit> onBecameVisible; // 0x40
		private AsyncTriggerPromiseDictionary<AsyncUnit> onBecameVisibles; // 0x48
	
		// Constructors
		public AsyncVisibleTrigger(); // 0x0000000181AC5020-0x0000000181AC52A0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000181AC4D50-0x0000000181AC4DE0
		private void OnBecameInvisible(); // 0x0000000181AC4E60-0x0000000181AC4F00
		public UniTask OnBecameInvisibleAsync(CancellationToken cancellationToken = default); // 0x0000000181AC4DE0-0x0000000181AC4E60
		private void OnBecameVisible(); // 0x0000000181AC4F80-0x0000000181AC5020
		public UniTask OnBecameVisibleAsync(CancellationToken cancellationToken = default); // 0x0000000181AC4F00-0x0000000181AC4F80
	}
}
