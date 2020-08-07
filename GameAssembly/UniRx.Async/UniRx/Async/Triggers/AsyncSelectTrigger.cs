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
	public class AsyncSelectTrigger : AsyncTriggerBase, ISelectHandler // TypeDefIndex: 8833
	{
		// Fields
		private AsyncTriggerPromise<BaseEventData> onSelect; // 0x30
		private AsyncTriggerPromiseDictionary<BaseEventData> onSelects; // 0x38
	
		// Constructors
		public AsyncSelectTrigger(); // 0x0000000180E11360-0x0000000180E113C0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E11210-0x0000000180E11280
		void ISelectHandler.OnSelect(BaseEventData eventData); // 0x0000000180E11300-0x0000000180E11360
		public UniTask<BaseEventData> OnSelectAsync(CancellationToken cancellationToken = default); // 0x0000000180E11280-0x0000000180E11300
	}
}
