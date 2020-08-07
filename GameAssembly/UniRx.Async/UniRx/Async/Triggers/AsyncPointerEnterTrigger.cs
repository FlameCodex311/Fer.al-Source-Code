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
	public class AsyncPointerEnterTrigger : AsyncTriggerBase, IPointerEnterHandler // TypeDefIndex: 8828
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onPointerEnter; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerEnters; // 0x38
	
		// Constructors
		public AsyncPointerEnterTrigger(); // 0x0000000180E10970-0x0000000180E109D0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E10820-0x0000000180E10890
		void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData); // 0x0000000180E10910-0x0000000180E10970
		public UniTask<PointerEventData> OnPointerEnterAsync(CancellationToken cancellationToken = default); // 0x0000000180E10890-0x0000000180E10910
	}
}
