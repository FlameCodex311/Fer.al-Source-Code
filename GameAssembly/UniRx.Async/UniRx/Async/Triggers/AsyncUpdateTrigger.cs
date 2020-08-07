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
	public class AsyncUpdateTrigger : AsyncTriggerBase // TypeDefIndex: 8853
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> update; // 0x30
		private AsyncTriggerPromiseDictionary<AsyncUnit> updates; // 0x38
	
		// Constructors
		public AsyncUpdateTrigger(); // 0x0000000181AC4CF0-0x0000000181AC4D50
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000181AC4B60-0x0000000181AC4BD0
		private void Update(); // 0x0000000181AC4C50-0x0000000181AC4CF0
		public UniTask UpdateAsync(CancellationToken cancellationToken = default); // 0x0000000181AC4BD0-0x0000000181AC4C50
	}
}
