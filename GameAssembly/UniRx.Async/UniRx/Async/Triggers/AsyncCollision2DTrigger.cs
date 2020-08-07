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
	public class AsyncCollision2DTrigger : AsyncTriggerBase // TypeDefIndex: 8810
	{
		// Fields
		private AsyncTriggerPromise<Collision2D> onCollisionEnter2D; // 0x30
		private AsyncTriggerPromiseDictionary<Collision2D> onCollisionEnter2Ds; // 0x38
		private AsyncTriggerPromise<Collision2D> onCollisionExit2D; // 0x40
		private AsyncTriggerPromiseDictionary<Collision2D> onCollisionExit2Ds; // 0x48
		private AsyncTriggerPromise<Collision2D> onCollisionStay2D; // 0x50
		private AsyncTriggerPromiseDictionary<Collision2D> onCollisionStay2Ds; // 0x58
	
		// Constructors
		public AsyncCollision2DTrigger(); // 0x0000000180E0BE40-0x0000000180E0BEA0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E0BAF0-0x0000000180E0BBA0
		private void OnCollisionEnter2D(Collision2D coll); // 0x0000000180E0BC20-0x0000000180E0BC80
		public UniTask<Collision2D> OnCollisionEnter2DAsync(CancellationToken cancellationToken = default); // 0x0000000180E0BBA0-0x0000000180E0BC20
		private void OnCollisionExit2D(Collision2D coll); // 0x0000000180E0BD00-0x0000000180E0BD60
		public UniTask<Collision2D> OnCollisionExit2DAsync(CancellationToken cancellationToken = default); // 0x0000000180E0BC80-0x0000000180E0BD00
		private void OnCollisionStay2D(Collision2D coll); // 0x0000000180E0BDE0-0x0000000180E0BE40
		public UniTask<Collision2D> OnCollisionStay2DAsync(CancellationToken cancellationToken = default); // 0x0000000180E0BD60-0x0000000180E0BDE0
	}
}
