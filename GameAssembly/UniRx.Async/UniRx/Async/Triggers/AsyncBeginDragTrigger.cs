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
	public class AsyncBeginDragTrigger : AsyncTriggerBase, IBeginDragHandler // TypeDefIndex: 8641
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onBeginDrag; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onBeginDrags; // 0x38
	
		// Constructors
		public AsyncBeginDragTrigger(); // 0x000000018165DE80-0x000000018165DEE0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x000000018165DD30-0x000000018165DDA0
		void IBeginDragHandler.OnBeginDrag(PointerEventData eventData); // 0x000000018165DE20-0x000000018165DE80
		public UniTask<PointerEventData> OnBeginDragAsync(CancellationToken cancellationToken = default); // 0x000000018165DDA0-0x000000018165DE20
	}
}
