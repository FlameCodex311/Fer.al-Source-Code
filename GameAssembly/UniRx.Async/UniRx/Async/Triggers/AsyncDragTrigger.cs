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
	public class AsyncDragTrigger : AsyncTriggerBase, IDragHandler // TypeDefIndex: 8648
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onDrag; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onDrags; // 0x38
	
		// Constructors
		public AsyncDragTrigger(); // 0x000000018165F140-0x000000018165F1A0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x000000018165EFF0-0x000000018165F060
		void IDragHandler.OnDrag(PointerEventData eventData); // 0x000000018165F0E0-0x000000018165F140
		public UniTask<PointerEventData> OnDragAsync(CancellationToken cancellationToken = default); // 0x000000018165F060-0x000000018165F0E0
	}
}
