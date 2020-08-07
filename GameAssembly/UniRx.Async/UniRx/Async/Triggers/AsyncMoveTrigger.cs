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
	public class AsyncMoveTrigger : AsyncTriggerBase, IMoveHandler // TypeDefIndex: 8824
	{
		// Fields
		private AsyncTriggerPromise<AxisEventData> onMove; // 0x30
		private AsyncTriggerPromiseDictionary<AxisEventData> onMoves; // 0x38
	
		// Constructors
		public AsyncMoveTrigger(); // 0x0000000180E102B0-0x0000000180E10310
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E10160-0x0000000180E101D0
		void IMoveHandler.OnMove(AxisEventData eventData); // 0x0000000180E10250-0x0000000180E102B0
		public UniTask<AxisEventData> OnMoveAsync(CancellationToken cancellationToken = default); // 0x0000000180E101D0-0x0000000180E10250
	}
}
