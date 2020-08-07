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
	public class AsyncLateUpdateTrigger : AsyncTriggerBase // TypeDefIndex: 8822
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> lateUpdate; // 0x30
		private AsyncTriggerPromiseDictionary<AsyncUnit> lateUpdates; // 0x38
	
		// Constructors
		public AsyncLateUpdateTrigger(); // 0x0000000180E0F390-0x0000000180E0F3F0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E0F200-0x0000000180E0F270
		private void LateUpdate(); // 0x0000000180E0F2F0-0x0000000180E0F390
		public UniTask LateUpdateAsync(CancellationToken cancellationToken = default); // 0x0000000180E0F270-0x0000000180E0F2F0
	}
}
