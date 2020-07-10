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
	public class AsyncParticleTrigger : AsyncTriggerBase // TypeDefIndex: 8659
	{
		// Fields
		private AsyncTriggerPromise<GameObject> onParticleCollision; // 0x30
		private AsyncTriggerPromiseDictionary<GameObject> onParticleCollisions; // 0x38
	
		// Constructors
		public AsyncParticleTrigger(); // 0x0000000181662D20-0x0000000181662D80
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000181662BD0-0x0000000181662C40
		private void OnParticleCollision(GameObject other); // 0x0000000181662CC0-0x0000000181662D20
		public UniTask<GameObject> OnParticleCollisionAsync(CancellationToken cancellationToken = default); // 0x0000000181662C40-0x0000000181662CC0
	}
}
