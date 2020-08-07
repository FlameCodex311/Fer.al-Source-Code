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

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class AsyncAnimatorTrigger : AsyncTriggerBase // TypeDefIndex: 8804
	{
		// Fields
		private AsyncTriggerPromise<int> onAnimatorIK; // 0x30
		private AsyncTriggerPromiseDictionary<int> onAnimatorIKs; // 0x38
		private AsyncTriggerPromise<AsyncUnit> onAnimatorMove; // 0x40
		private AsyncTriggerPromiseDictionary<AsyncUnit> onAnimatorMoves; // 0x48
	
		// Constructors
		public AsyncAnimatorTrigger(); // 0x0000000180E0B440-0x0000000180E0B4A0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E0B1B0-0x0000000180E0B240
		private void OnAnimatorIK(int layerIndex); // 0x0000000180E0B2C0-0x0000000180E0B320
		public UniTask<int> OnAnimatorIKAsync(CancellationToken cancellationToken = default); // 0x0000000180E0B240-0x0000000180E0B2C0
		private void OnAnimatorMove(); // 0x0000000180E0B3A0-0x0000000180E0B440
		public UniTask OnAnimatorMoveAsync(CancellationToken cancellationToken = default); // 0x0000000180E0B320-0x0000000180E0B3A0
	}
}
