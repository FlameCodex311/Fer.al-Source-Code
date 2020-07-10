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
	public class AsyncScrollTrigger : AsyncTriggerBase, IScrollHandler // TypeDefIndex: 8666
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onScroll; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onScrolls; // 0x38
	
		// Constructors
		public AsyncScrollTrigger(); // 0x0000000181663A70-0x0000000181663AD0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000181663920-0x0000000181663990
		void IScrollHandler.OnScroll(PointerEventData eventData); // 0x0000000181663A10-0x0000000181663A70
		public UniTask<PointerEventData> OnScrollAsync(CancellationToken cancellationToken = default); // 0x0000000181663990-0x0000000181663A10
	}
}
