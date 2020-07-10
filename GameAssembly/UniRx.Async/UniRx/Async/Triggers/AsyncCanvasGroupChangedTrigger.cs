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
	public class AsyncCanvasGroupChangedTrigger : AsyncTriggerBase // TypeDefIndex: 8643
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> onCanvasGroupChanged; // 0x30
		private AsyncTriggerPromiseDictionary<AsyncUnit> onCanvasGroupChangeds; // 0x38
	
		// Constructors
		public AsyncCanvasGroupChangedTrigger(); // 0x000000018165E220-0x000000018165E280
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x000000018165E090-0x000000018165E100
		private void OnCanvasGroupChanged(); // 0x000000018165E180-0x000000018165E220
		public UniTask OnCanvasGroupChangedAsync(CancellationToken cancellationToken = default); // 0x000000018165E100-0x000000018165E180
	}
}
