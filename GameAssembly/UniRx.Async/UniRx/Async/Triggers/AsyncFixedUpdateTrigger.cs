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
	public class AsyncFixedUpdateTrigger : AsyncTriggerBase // TypeDefIndex: 8653
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> fixedUpdate; // 0x30
		private AsyncTriggerPromiseDictionary<AsyncUnit> fixedUpdates; // 0x38
	
		// Constructors
		public AsyncFixedUpdateTrigger(); // 0x00000001816615A0-0x0000000181661600
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000181661530-0x00000001816615A0
		private void FixedUpdate(); // 0x0000000181661490-0x0000000181661530
		public UniTask FixedUpdateAsync(CancellationToken cancellationToken = default); // 0x0000000181661410-0x0000000181661490
	}
}
