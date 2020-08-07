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
	public class AsyncCollisionTrigger : AsyncTriggerBase // TypeDefIndex: 8811
	{
		// Fields
		private AsyncTriggerPromise<Collision> onCollisionEnter; // 0x30
		private AsyncTriggerPromiseDictionary<Collision> onCollisionEnters; // 0x38
		private AsyncTriggerPromise<Collision> onCollisionExit; // 0x40
		private AsyncTriggerPromiseDictionary<Collision> onCollisionExits; // 0x48
		private AsyncTriggerPromise<Collision> onCollisionStay; // 0x50
		private AsyncTriggerPromiseDictionary<Collision> onCollisionStays; // 0x58
	
		// Constructors
		public AsyncCollisionTrigger(); // 0x0000000180E0C1F0-0x0000000180E0C250
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E0BEA0-0x0000000180E0BF50
		private void OnCollisionEnter(Collision collision); // 0x0000000180E0BFD0-0x0000000180E0C030
		public UniTask<Collision> OnCollisionEnterAsync(CancellationToken cancellationToken = default); // 0x0000000180E0BF50-0x0000000180E0BFD0
		private void OnCollisionExit(Collision collisionInfo); // 0x0000000180E0C0B0-0x0000000180E0C110
		public UniTask<Collision> OnCollisionExitAsync(CancellationToken cancellationToken = default); // 0x0000000180E0C030-0x0000000180E0C0B0
		private void OnCollisionStay(Collision collisionInfo); // 0x0000000180E0C190-0x0000000180E0C1F0
		public UniTask<Collision> OnCollisionStayAsync(CancellationToken cancellationToken = default); // 0x0000000180E0C110-0x0000000180E0C190
	}
}
