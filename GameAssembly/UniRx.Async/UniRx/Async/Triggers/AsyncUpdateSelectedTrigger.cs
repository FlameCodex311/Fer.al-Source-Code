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
	public class AsyncUpdateSelectedTrigger : AsyncTriggerBase, IUpdateSelectedHandler // TypeDefIndex: 8686
	{
		// Fields
		private AsyncTriggerPromise<BaseEventData> onUpdateSelected; // 0x30
		private AsyncTriggerPromiseDictionary<BaseEventData> onUpdateSelecteds; // 0x38
	
		// Constructors
		public AsyncUpdateSelectedTrigger(); // 0x0000000181667700-0x0000000181667760
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x00000001816675B0-0x0000000181667620
		void IUpdateSelectedHandler.OnUpdateSelected(BaseEventData eventData); // 0x00000001816676A0-0x0000000181667700
		public UniTask<BaseEventData> OnUpdateSelectedAsync(CancellationToken cancellationToken = default); // 0x0000000181667620-0x00000001816676A0
	}
}
