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
	public class AsyncPointerDownTrigger : AsyncTriggerBase, IPointerDownHandler // TypeDefIndex: 8827
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onPointerDown; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerDowns; // 0x38
	
		// Constructors
		public AsyncPointerDownTrigger(); // 0x0000000180E107C0-0x0000000180E10820
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E10670-0x0000000180E106E0
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData); // 0x0000000180E10760-0x0000000180E107C0
		public UniTask<PointerEventData> OnPointerDownAsync(CancellationToken cancellationToken = default); // 0x0000000180E106E0-0x0000000180E10760
	}
}
