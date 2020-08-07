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
	public class AsyncEndDragTrigger : AsyncTriggerBase, IEndDragHandler // TypeDefIndex: 8817
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onEndDrag; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onEndDrags; // 0x38
	
		// Constructors
		public AsyncEndDragTrigger(); // 0x0000000180E0D030-0x0000000180E0D090
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E0CEE0-0x0000000180E0CF50
		void IEndDragHandler.OnEndDrag(PointerEventData eventData); // 0x0000000180E0CFD0-0x0000000180E0D030
		public UniTask<PointerEventData> OnEndDragAsync(CancellationToken cancellationToken = default); // 0x0000000180E0CF50-0x0000000180E0CFD0
	}
}
