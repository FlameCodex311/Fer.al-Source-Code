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
	public class AsyncPointerExitTrigger : AsyncTriggerBase, IPointerExitHandler // TypeDefIndex: 8663
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onPointerExit; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerExits; // 0x38
	
		// Constructors
		public AsyncPointerExitTrigger(); // 0x00000001816633E0-0x0000000181663440
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000181663290-0x0000000181663300
		void IPointerExitHandler.OnPointerExit(PointerEventData eventData); // 0x0000000181663380-0x00000001816633E0
		public UniTask<PointerEventData> OnPointerExitAsync(CancellationToken cancellationToken = default); // 0x0000000181663300-0x0000000181663380
	}
}
