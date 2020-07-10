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
	public class AsyncSelectTrigger : AsyncTriggerBase, ISelectHandler // TypeDefIndex: 8667
	{
		// Fields
		private AsyncTriggerPromise<BaseEventData> onSelect; // 0x30
		private AsyncTriggerPromiseDictionary<BaseEventData> onSelects; // 0x38
	
		// Constructors
		public AsyncSelectTrigger(); // 0x0000000181663C20-0x0000000181663C80
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000181663AD0-0x0000000181663B40
		void ISelectHandler.OnSelect(BaseEventData eventData); // 0x0000000181663BC0-0x0000000181663C20
		public UniTask<BaseEventData> OnSelectAsync(CancellationToken cancellationToken = default); // 0x0000000181663B40-0x0000000181663BC0
	}
}
