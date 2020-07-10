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
	public class AsyncDropTrigger : AsyncTriggerBase, IDropHandler // TypeDefIndex: 8649
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onDrop; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onDrops; // 0x38
	
		// Constructors
		public AsyncDropTrigger(); // 0x000000018165F2F0-0x000000018165F350
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x000000018165F1A0-0x000000018165F210
		void IDropHandler.OnDrop(PointerEventData eventData); // 0x000000018165F290-0x000000018165F2F0
		public UniTask<PointerEventData> OnDropAsync(CancellationToken cancellationToken = default); // 0x000000018165F210-0x000000018165F290
	}
}
