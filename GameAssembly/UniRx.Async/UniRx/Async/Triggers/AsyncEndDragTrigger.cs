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
	public class AsyncEndDragTrigger : AsyncTriggerBase, IEndDragHandler // TypeDefIndex: 8651
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onEndDrag; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onEndDrags; // 0x38
	
		// Constructors
		public AsyncEndDragTrigger(); // 0x000000018165F7D0-0x000000018165F830
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x000000018165F680-0x000000018165F6F0
		void IEndDragHandler.OnEndDrag(PointerEventData eventData); // 0x000000018165F770-0x000000018165F7D0
		public UniTask<PointerEventData> OnEndDragAsync(CancellationToken cancellationToken = default); // 0x000000018165F6F0-0x000000018165F770
	}
}
