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
	public class AsyncPointerExitTrigger : AsyncTriggerBase, IPointerExitHandler // TypeDefIndex: 8829
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onPointerExit; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerExits; // 0x38
	
		// Constructors
		public AsyncPointerExitTrigger(); // 0x0000000180E10B20-0x0000000180E10B80
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E109D0-0x0000000180E10A40
		void IPointerExitHandler.OnPointerExit(PointerEventData eventData); // 0x0000000180E10AC0-0x0000000180E10B20
		public UniTask<PointerEventData> OnPointerExitAsync(CancellationToken cancellationToken = default); // 0x0000000180E10A40-0x0000000180E10AC0
	}
}
