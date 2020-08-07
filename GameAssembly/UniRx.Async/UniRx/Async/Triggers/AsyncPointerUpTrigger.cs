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
	public class AsyncPointerUpTrigger : AsyncTriggerBase, IPointerUpHandler // TypeDefIndex: 8830
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onPointerUp; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerUps; // 0x38
	
		// Constructors
		public AsyncPointerUpTrigger(); // 0x0000000180E10CD0-0x0000000180E10D30
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E10B80-0x0000000180E10BF0
		void IPointerUpHandler.OnPointerUp(PointerEventData eventData); // 0x0000000180E10C70-0x0000000180E10CD0
		public UniTask<PointerEventData> OnPointerUpAsync(CancellationToken cancellationToken = default); // 0x0000000180E10BF0-0x0000000180E10C70
	}
}
