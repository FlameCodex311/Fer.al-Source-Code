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
	public class AsyncTrigger2DTrigger : AsyncTriggerBase // TypeDefIndex: 8838
	{
		// Fields
		private AsyncTriggerPromise<Collider2D> onTriggerEnter2D; // 0x30
		private AsyncTriggerPromiseDictionary<Collider2D> onTriggerEnter2Ds; // 0x38
		private AsyncTriggerPromise<Collider2D> onTriggerExit2D; // 0x40
		private AsyncTriggerPromiseDictionary<Collider2D> onTriggerExit2Ds; // 0x48
		private AsyncTriggerPromise<Collider2D> onTriggerStay2D; // 0x50
		private AsyncTriggerPromiseDictionary<Collider2D> onTriggerStay2Ds; // 0x58
	
		// Constructors
		public AsyncTrigger2DTrigger(); // 0x0000000180E11E10-0x0000000180E11E70
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E11AC0-0x0000000180E11B70
		private void OnTriggerEnter2D(Collider2D other); // 0x0000000180E11BF0-0x0000000180E11C50
		public UniTask<Collider2D> OnTriggerEnter2DAsync(CancellationToken cancellationToken = default); // 0x0000000180E11B70-0x0000000180E11BF0
		private void OnTriggerExit2D(Collider2D other); // 0x0000000180E11CD0-0x0000000180E11D30
		public UniTask<Collider2D> OnTriggerExit2DAsync(CancellationToken cancellationToken = default); // 0x0000000180E11C50-0x0000000180E11CD0
		private void OnTriggerStay2D(Collider2D other); // 0x0000000180E11DB0-0x0000000180E11E10
		public UniTask<Collider2D> OnTriggerStay2DAsync(CancellationToken cancellationToken = default); // 0x0000000180E11D30-0x0000000180E11DB0
	}
}
