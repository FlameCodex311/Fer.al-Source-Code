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
	public class AsyncParticleTrigger : AsyncTriggerBase // TypeDefIndex: 8825
	{
		// Fields
		private AsyncTriggerPromise<GameObject> onParticleCollision; // 0x30
		private AsyncTriggerPromiseDictionary<GameObject> onParticleCollisions; // 0x38
	
		// Constructors
		public AsyncParticleTrigger(); // 0x0000000180E10460-0x0000000180E104C0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E10310-0x0000000180E10380
		private void OnParticleCollision(GameObject other); // 0x0000000180E10400-0x0000000180E10460
		public UniTask<GameObject> OnParticleCollisionAsync(CancellationToken cancellationToken = default); // 0x0000000180E10380-0x0000000180E10400
	}
}
