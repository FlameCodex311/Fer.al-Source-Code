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
	public class AsyncMoveTrigger : AsyncTriggerBase, IMoveHandler // TypeDefIndex: 8658
	{
		// Fields
		private AsyncTriggerPromise<AxisEventData> onMove; // 0x30
		private AsyncTriggerPromiseDictionary<AxisEventData> onMoves; // 0x38
	
		// Constructors
		public AsyncMoveTrigger(); // 0x0000000181662B70-0x0000000181662BD0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000181662A20-0x0000000181662A90
		void IMoveHandler.OnMove(AxisEventData eventData); // 0x0000000181662B10-0x0000000181662B70
		public UniTask<AxisEventData> OnMoveAsync(CancellationToken cancellationToken = default); // 0x0000000181662A90-0x0000000181662B10
	}
}
