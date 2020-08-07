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
	public class AsyncScrollTrigger : AsyncTriggerBase, IScrollHandler // TypeDefIndex: 8832
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onScroll; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onScrolls; // 0x38
	
		// Constructors
		public AsyncScrollTrigger(); // 0x0000000180E111B0-0x0000000180E11210
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E11060-0x0000000180E110D0
		void IScrollHandler.OnScroll(PointerEventData eventData); // 0x0000000180E11150-0x0000000180E111B0
		public UniTask<PointerEventData> OnScrollAsync(CancellationToken cancellationToken = default); // 0x0000000180E110D0-0x0000000180E11150
	}
}
