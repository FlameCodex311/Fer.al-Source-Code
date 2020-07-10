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
	public class AsyncPointerClickTrigger : AsyncTriggerBase, IPointerClickHandler // TypeDefIndex: 8660
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onPointerClick; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerClicks; // 0x38
	
		// Constructors
		public AsyncPointerClickTrigger(); // 0x0000000181662ED0-0x0000000181662F30
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000181662D80-0x0000000181662DF0
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData); // 0x0000000181662E70-0x0000000181662ED0
		public UniTask<PointerEventData> OnPointerClickAsync(CancellationToken cancellationToken = default); // 0x0000000181662DF0-0x0000000181662E70
	}
}
