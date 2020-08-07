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
	public class AsyncInitializePotentialDragTrigger : AsyncTriggerBase, IInitializePotentialDragHandler // TypeDefIndex: 8820
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onInitializePotentialDrag; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onInitializePotentialDrags; // 0x38
	
		// Constructors
		public AsyncInitializePotentialDragTrigger(); // 0x0000000180E0EEF0-0x0000000180E0EF50
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E0EDA0-0x0000000180E0EE10
		void IInitializePotentialDragHandler.OnInitializePotentialDrag(PointerEventData eventData); // 0x0000000180E0EE90-0x0000000180E0EEF0
		public UniTask<PointerEventData> OnInitializePotentialDragAsync(CancellationToken cancellationToken = default); // 0x0000000180E0EE10-0x0000000180E0EE90
	}
}
