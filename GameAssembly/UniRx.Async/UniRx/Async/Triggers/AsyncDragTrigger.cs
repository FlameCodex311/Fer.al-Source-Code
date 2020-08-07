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
	public class AsyncDragTrigger : AsyncTriggerBase, IDragHandler // TypeDefIndex: 8814
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onDrag; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onDrags; // 0x38
	
		// Constructors
		public AsyncDragTrigger(); // 0x0000000180E0C9A0-0x0000000180E0CA00
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E0C850-0x0000000180E0C8C0
		void IDragHandler.OnDrag(PointerEventData eventData); // 0x0000000180E0C940-0x0000000180E0C9A0
		public UniTask<PointerEventData> OnDragAsync(CancellationToken cancellationToken = default); // 0x0000000180E0C8C0-0x0000000180E0C940
	}
}
