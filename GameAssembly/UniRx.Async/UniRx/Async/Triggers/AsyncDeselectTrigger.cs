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
using UnityEngine.EventSystems;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent] // 0x00000001800B36B0-0x00000001800B36C0
	public class AsyncDeselectTrigger : AsyncTriggerBase, IDeselectHandler // TypeDefIndex: 8646
	{
		// Fields
		private AsyncTriggerPromise<BaseEventData> onDeselect; // 0x30
		private AsyncTriggerPromiseDictionary<BaseEventData> onDeselects; // 0x38
	
		// Constructors
		public AsyncDeselectTrigger(); // 0x000000018165EB30-0x000000018165EB90
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x000000018165E9E0-0x000000018165EA50
		void IDeselectHandler.OnDeselect(BaseEventData eventData); // 0x000000018165EAD0-0x000000018165EB30
		public UniTask<BaseEventData> OnDeselectAsync(CancellationToken cancellationToken = default); // 0x000000018165EA50-0x000000018165EAD0
	}
}
