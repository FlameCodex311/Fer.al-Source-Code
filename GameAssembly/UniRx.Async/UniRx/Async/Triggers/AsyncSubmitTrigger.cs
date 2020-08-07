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
	public class AsyncSubmitTrigger : AsyncTriggerBase, ISubmitHandler // TypeDefIndex: 8836
	{
		// Fields
		private AsyncTriggerPromise<BaseEventData> onSubmit; // 0x30
		private AsyncTriggerPromiseDictionary<BaseEventData> onSubmits; // 0x38
	
		// Constructors
		public AsyncSubmitTrigger(); // 0x0000000180E115F0-0x0000000180E11650
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E114A0-0x0000000180E11510
		void ISubmitHandler.OnSubmit(BaseEventData eventData); // 0x0000000180E11590-0x0000000180E115F0
		public UniTask<BaseEventData> OnSubmitAsync(CancellationToken cancellationToken = default); // 0x0000000180E11510-0x0000000180E11590
	}
}
