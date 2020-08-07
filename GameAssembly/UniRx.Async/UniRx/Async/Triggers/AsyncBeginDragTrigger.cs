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
	public class AsyncBeginDragTrigger : AsyncTriggerBase, IBeginDragHandler // TypeDefIndex: 8807
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onBeginDrag; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onBeginDrags; // 0x38
	
		// Constructors
		public AsyncBeginDragTrigger(); // 0x0000000180E0B6F0-0x0000000180E0B750
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E0B5A0-0x0000000180E0B610
		void IBeginDragHandler.OnBeginDrag(PointerEventData eventData); // 0x0000000180E0B690-0x0000000180E0B6F0
		public UniTask<PointerEventData> OnBeginDragAsync(CancellationToken cancellationToken = default); // 0x0000000180E0B610-0x0000000180E0B690
	}
}
