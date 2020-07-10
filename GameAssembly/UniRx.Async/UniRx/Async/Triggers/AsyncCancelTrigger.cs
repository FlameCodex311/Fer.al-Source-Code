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
	public class AsyncCancelTrigger : AsyncTriggerBase, ICancelHandler // TypeDefIndex: 8642
	{
		// Fields
		private AsyncTriggerPromise<BaseEventData> onCancel; // 0x30
		private AsyncTriggerPromiseDictionary<BaseEventData> onCancels; // 0x38
	
		// Constructors
		public AsyncCancelTrigger(); // 0x000000018165E030-0x000000018165E090
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x000000018165DEE0-0x000000018165DF50
		void ICancelHandler.OnCancel(BaseEventData eventData); // 0x000000018165DFD0-0x000000018165E030
		public UniTask<BaseEventData> OnCancelAsync(CancellationToken cancellationToken = default); // 0x000000018165DF50-0x000000018165DFD0
	}
}
