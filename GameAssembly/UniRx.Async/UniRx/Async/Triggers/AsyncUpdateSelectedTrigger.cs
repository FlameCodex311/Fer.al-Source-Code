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
	public class AsyncUpdateSelectedTrigger : AsyncTriggerBase, IUpdateSelectedHandler // TypeDefIndex: 8852
	{
		// Fields
		private AsyncTriggerPromise<BaseEventData> onUpdateSelected; // 0x30
		private AsyncTriggerPromiseDictionary<BaseEventData> onUpdateSelecteds; // 0x38
	
		// Constructors
		public AsyncUpdateSelectedTrigger(); // 0x0000000181AC4B00-0x0000000181AC4B60
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000181AC49B0-0x0000000181AC4A20
		void IUpdateSelectedHandler.OnUpdateSelected(BaseEventData eventData); // 0x0000000181AC4AA0-0x0000000181AC4B00
		public UniTask<BaseEventData> OnUpdateSelectedAsync(CancellationToken cancellationToken = default); // 0x0000000181AC4A20-0x0000000181AC4AA0
	}
}
