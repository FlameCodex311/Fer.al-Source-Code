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
	public class AsyncDropTrigger : AsyncTriggerBase, IDropHandler // TypeDefIndex: 8815
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onDrop; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onDrops; // 0x38
	
		// Constructors
		public AsyncDropTrigger(); // 0x0000000180E0CB50-0x0000000180E0CBB0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E0CA00-0x0000000180E0CA70
		void IDropHandler.OnDrop(PointerEventData eventData); // 0x0000000180E0CAF0-0x0000000180E0CB50
		public UniTask<PointerEventData> OnDropAsync(CancellationToken cancellationToken = default); // 0x0000000180E0CA70-0x0000000180E0CAF0
	}
}
