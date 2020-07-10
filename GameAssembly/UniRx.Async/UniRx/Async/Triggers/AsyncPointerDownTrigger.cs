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
	public class AsyncPointerDownTrigger : AsyncTriggerBase, IPointerDownHandler // TypeDefIndex: 8661
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onPointerDown; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerDowns; // 0x38
	
		// Constructors
		public AsyncPointerDownTrigger(); // 0x0000000181663080-0x00000001816630E0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000181662F30-0x0000000181662FA0
		void IPointerDownHandler.OnPointerDown(PointerEventData eventData); // 0x0000000181663020-0x0000000181663080
		public UniTask<PointerEventData> OnPointerDownAsync(CancellationToken cancellationToken = default); // 0x0000000181662FA0-0x0000000181663020
	}
}
