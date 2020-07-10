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
	public class AsyncCollisionTrigger : AsyncTriggerBase // TypeDefIndex: 8645
	{
		// Fields
		private AsyncTriggerPromise<Collision> onCollisionEnter; // 0x30
		private AsyncTriggerPromiseDictionary<Collision> onCollisionEnters; // 0x38
		private AsyncTriggerPromise<Collision> onCollisionExit; // 0x40
		private AsyncTriggerPromiseDictionary<Collision> onCollisionExits; // 0x48
		private AsyncTriggerPromise<Collision> onCollisionStay; // 0x50
		private AsyncTriggerPromiseDictionary<Collision> onCollisionStays; // 0x58
	
		// Constructors
		public AsyncCollisionTrigger(); // 0x000000018165E980-0x000000018165E9E0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x000000018165E630-0x000000018165E6E0
		private void OnCollisionEnter(Collision collision); // 0x000000018165E760-0x000000018165E7C0
		public UniTask<Collision> OnCollisionEnterAsync(CancellationToken cancellationToken = default); // 0x000000018165E6E0-0x000000018165E760
		private void OnCollisionExit(Collision collisionInfo); // 0x000000018165E840-0x000000018165E8A0
		public UniTask<Collision> OnCollisionExitAsync(CancellationToken cancellationToken = default); // 0x000000018165E7C0-0x000000018165E840
		private void OnCollisionStay(Collision collisionInfo); // 0x000000018165E920-0x000000018165E980
		public UniTask<Collision> OnCollisionStayAsync(CancellationToken cancellationToken = default); // 0x000000018165E8A0-0x000000018165E920
	}
}
