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
	public class AsyncPointerEnterTrigger : AsyncTriggerBase, IPointerEnterHandler // TypeDefIndex: 8662
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onPointerEnter; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerEnters; // 0x38
	
		// Constructors
		public AsyncPointerEnterTrigger(); // 0x0000000181663230-0x0000000181663290
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x00000001816630E0-0x0000000181663150
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData); // 0x00000001816631D0-0x0000000181663230
		public UniTask<PointerEventData> OnPointerEnterAsync(CancellationToken cancellationToken = default); // 0x0000000181663150-0x00000001816631D0
	}
}
