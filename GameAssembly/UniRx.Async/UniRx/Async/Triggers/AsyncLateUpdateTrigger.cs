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
	public class AsyncLateUpdateTrigger : AsyncTriggerBase // TypeDefIndex: 8656
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> lateUpdate; // 0x30
		private AsyncTriggerPromiseDictionary<AsyncUnit> lateUpdates; // 0x38
	
		// Constructors
		public AsyncLateUpdateTrigger(); // 0x0000000181661BF0-0x0000000181661C50
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000181661A60-0x0000000181661AD0
		private void LateUpdate(); // 0x0000000181661B50-0x0000000181661BF0
		public UniTask LateUpdateAsync(CancellationToken cancellationToken = default); // 0x0000000181661AD0-0x0000000181661B50
	}
}
