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
	public class AsyncSubmitTrigger : AsyncTriggerBase, ISubmitHandler // TypeDefIndex: 8670
	{
		// Fields
		private AsyncTriggerPromise<BaseEventData> onSubmit; // 0x30
		private AsyncTriggerPromiseDictionary<BaseEventData> onSubmits; // 0x38
	
		// Constructors
		public AsyncSubmitTrigger(); // 0x0000000181663EB0-0x0000000181663F10
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000181663D60-0x0000000181663DD0
		void ISubmitHandler.OnSubmit(BaseEventData eventData); // 0x0000000181663E50-0x0000000181663EB0
		public UniTask<BaseEventData> OnSubmitAsync(CancellationToken cancellationToken = default); // 0x0000000181663DD0-0x0000000181663E50
	}
}
