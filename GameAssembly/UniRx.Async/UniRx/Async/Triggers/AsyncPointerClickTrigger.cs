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
	public class AsyncPointerClickTrigger : AsyncTriggerBase, IPointerClickHandler // TypeDefIndex: 8826
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onPointerClick; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerClicks; // 0x38
	
		// Constructors
		public AsyncPointerClickTrigger(); // 0x0000000180E10610-0x0000000180E10670
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E104C0-0x0000000180E10530
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData); // 0x0000000180E105B0-0x0000000180E10610
		public UniTask<PointerEventData> OnPointerClickAsync(CancellationToken cancellationToken = default); // 0x0000000180E10530-0x0000000180E105B0
	}
}
