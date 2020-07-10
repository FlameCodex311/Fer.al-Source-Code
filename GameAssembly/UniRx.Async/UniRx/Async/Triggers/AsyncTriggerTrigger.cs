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
	public class AsyncTriggerTrigger : AsyncTriggerBase // TypeDefIndex: 8685
	{
		// Fields
		private AsyncTriggerPromise<Collider> onTriggerEnter; // 0x30
		private AsyncTriggerPromiseDictionary<Collider> onTriggerEnters; // 0x38
		private AsyncTriggerPromise<Collider> onTriggerExit; // 0x40
		private AsyncTriggerPromiseDictionary<Collider> onTriggerExits; // 0x48
		private AsyncTriggerPromise<Collider> onTriggerStay; // 0x50
		private AsyncTriggerPromiseDictionary<Collider> onTriggerStays; // 0x58
	
		// Constructors
		public AsyncTriggerTrigger(); // 0x0000000181666C70-0x0000000181666F70
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000181666920-0x00000001816669D0
		private void OnTriggerEnter(Collider other); // 0x0000000181666A50-0x0000000181666AB0
		public UniTask<Collider> OnTriggerEnterAsync(CancellationToken cancellationToken = default); // 0x00000001816669D0-0x0000000181666A50
		private void OnTriggerExit(Collider other); // 0x0000000181666B30-0x0000000181666B90
		public UniTask<Collider> OnTriggerExitAsync(CancellationToken cancellationToken = default); // 0x0000000181666AB0-0x0000000181666B30
		private void OnTriggerStay(Collider other); // 0x0000000181666C10-0x0000000181666C70
		public UniTask<Collider> OnTriggerStayAsync(CancellationToken cancellationToken = default); // 0x0000000181666B90-0x0000000181666C10
	}
}
