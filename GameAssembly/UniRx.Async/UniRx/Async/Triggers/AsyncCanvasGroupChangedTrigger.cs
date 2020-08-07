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
	public class AsyncCanvasGroupChangedTrigger : AsyncTriggerBase // TypeDefIndex: 8809
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> onCanvasGroupChanged; // 0x30
		private AsyncTriggerPromiseDictionary<AsyncUnit> onCanvasGroupChangeds; // 0x38
	
		// Constructors
		public AsyncCanvasGroupChangedTrigger(); // 0x0000000180E0BA90-0x0000000180E0BAF0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E0B900-0x0000000180E0B970
		private void OnCanvasGroupChanged(); // 0x0000000180E0B9F0-0x0000000180E0BA90
		public UniTask OnCanvasGroupChangedAsync(CancellationToken cancellationToken = default); // 0x0000000180E0B970-0x0000000180E0B9F0
	}
}
