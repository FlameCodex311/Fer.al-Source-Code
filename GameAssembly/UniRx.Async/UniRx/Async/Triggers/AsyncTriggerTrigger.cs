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
	public class AsyncTriggerTrigger : AsyncTriggerBase // TypeDefIndex: 8851
	{
		// Fields
		private AsyncTriggerPromise<Collider> onTriggerEnter; // 0x30
		private AsyncTriggerPromiseDictionary<Collider> onTriggerEnters; // 0x38
		private AsyncTriggerPromise<Collider> onTriggerExit; // 0x40
		private AsyncTriggerPromiseDictionary<Collider> onTriggerExits; // 0x48
		private AsyncTriggerPromise<Collider> onTriggerStay; // 0x50
		private AsyncTriggerPromiseDictionary<Collider> onTriggerStays; // 0x58
	
		// Constructors
		public AsyncTriggerTrigger(); // 0x0000000180E143B0-0x0000000180E146B0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E14060-0x0000000180E14110
		private void OnTriggerEnter(Collider other); // 0x0000000180E14190-0x0000000180E141F0
		public UniTask<Collider> OnTriggerEnterAsync(CancellationToken cancellationToken = default); // 0x0000000180E14110-0x0000000180E14190
		private void OnTriggerExit(Collider other); // 0x0000000180E14270-0x0000000180E142D0
		public UniTask<Collider> OnTriggerExitAsync(CancellationToken cancellationToken = default); // 0x0000000180E141F0-0x0000000180E14270
		private void OnTriggerStay(Collider other); // 0x0000000180E14350-0x0000000180E143B0
		public UniTask<Collider> OnTriggerStayAsync(CancellationToken cancellationToken = default); // 0x0000000180E142D0-0x0000000180E14350
	}
}
