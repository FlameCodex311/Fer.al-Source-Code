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
	public class AsyncFixedUpdateTrigger : AsyncTriggerBase // TypeDefIndex: 8819
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> fixedUpdate; // 0x30
		private AsyncTriggerPromiseDictionary<AsyncUnit> fixedUpdates; // 0x38
	
		// Constructors
		public AsyncFixedUpdateTrigger(); // 0x0000000180E0ED40-0x0000000180E0EDA0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E0ECD0-0x0000000180E0ED40
		private void FixedUpdate(); // 0x0000000180E0EC30-0x0000000180E0ECD0
		public UniTask FixedUpdateAsync(CancellationToken cancellationToken = default); // 0x0000000180E0EBB0-0x0000000180E0EC30
	}
}
