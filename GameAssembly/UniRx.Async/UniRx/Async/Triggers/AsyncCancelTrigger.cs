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

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class AsyncCancelTrigger : AsyncTriggerBase, ICancelHandler // TypeDefIndex: 8808
	{
		// Fields
		private AsyncTriggerPromise<BaseEventData> onCancel; // 0x30
		private AsyncTriggerPromiseDictionary<BaseEventData> onCancels; // 0x38
	
		// Constructors
		public AsyncCancelTrigger(); // 0x0000000180E0B8A0-0x0000000180E0B900
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E0B750-0x0000000180E0B7C0
		void ICancelHandler.OnCancel(BaseEventData eventData); // 0x0000000180E0B840-0x0000000180E0B8A0
		public UniTask<BaseEventData> OnCancelAsync(CancellationToken cancellationToken = default); // 0x0000000180E0B7C0-0x0000000180E0B840
	}
}
