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
	public class AsyncCollision2DTrigger : AsyncTriggerBase // TypeDefIndex: 8644
	{
		// Fields
		private AsyncTriggerPromise<Collision2D> onCollisionEnter2D; // 0x30
		private AsyncTriggerPromiseDictionary<Collision2D> onCollisionEnter2Ds; // 0x38
		private AsyncTriggerPromise<Collision2D> onCollisionExit2D; // 0x40
		private AsyncTriggerPromiseDictionary<Collision2D> onCollisionExit2Ds; // 0x48
		private AsyncTriggerPromise<Collision2D> onCollisionStay2D; // 0x50
		private AsyncTriggerPromiseDictionary<Collision2D> onCollisionStay2Ds; // 0x58
	
		// Constructors
		public AsyncCollision2DTrigger(); // 0x000000018165E5D0-0x000000018165E630
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x000000018165E280-0x000000018165E330
		private void OnCollisionEnter2D(Collision2D coll); // 0x000000018165E3B0-0x000000018165E410
		public UniTask<Collision2D> OnCollisionEnter2DAsync(CancellationToken cancellationToken = default); // 0x000000018165E330-0x000000018165E3B0
		private void OnCollisionExit2D(Collision2D coll); // 0x000000018165E490-0x000000018165E4F0
		public UniTask<Collision2D> OnCollisionExit2DAsync(CancellationToken cancellationToken = default); // 0x000000018165E410-0x000000018165E490
		private void OnCollisionStay2D(Collision2D coll); // 0x000000018165E570-0x000000018165E5D0
		public UniTask<Collision2D> OnCollisionStay2DAsync(CancellationToken cancellationToken = default); // 0x000000018165E4F0-0x000000018165E570
	}
}
