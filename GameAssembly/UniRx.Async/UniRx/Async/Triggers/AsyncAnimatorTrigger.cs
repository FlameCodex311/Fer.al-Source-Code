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

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent] // 0x00000001800B36B0-0x00000001800B36C0
	public class AsyncAnimatorTrigger : AsyncTriggerBase // TypeDefIndex: 8638
	{
		// Fields
		private AsyncTriggerPromise<int> onAnimatorIK; // 0x30
		private AsyncTriggerPromiseDictionary<int> onAnimatorIKs; // 0x38
		private AsyncTriggerPromise<AsyncUnit> onAnimatorMove; // 0x40
		private AsyncTriggerPromiseDictionary<AsyncUnit> onAnimatorMoves; // 0x48
	
		// Constructors
		public AsyncAnimatorTrigger(); // 0x000000018165DBD0-0x000000018165DC30
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x000000018165D940-0x000000018165D9D0
		private void OnAnimatorIK(int layerIndex); // 0x000000018165DA50-0x000000018165DAB0
		public UniTask<int> OnAnimatorIKAsync(CancellationToken cancellationToken = default); // 0x000000018165D9D0-0x000000018165DA50
		private void OnAnimatorMove(); // 0x000000018165DB30-0x000000018165DBD0
		public UniTask OnAnimatorMoveAsync(CancellationToken cancellationToken = default); // 0x000000018165DAB0-0x000000018165DB30
	}
}
