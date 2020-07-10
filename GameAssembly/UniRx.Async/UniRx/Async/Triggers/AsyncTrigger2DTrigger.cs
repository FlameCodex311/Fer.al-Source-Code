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
	public class AsyncTrigger2DTrigger : AsyncTriggerBase // TypeDefIndex: 8672
	{
		// Fields
		private AsyncTriggerPromise<Collider2D> onTriggerEnter2D; // 0x30
		private AsyncTriggerPromiseDictionary<Collider2D> onTriggerEnter2Ds; // 0x38
		private AsyncTriggerPromise<Collider2D> onTriggerExit2D; // 0x40
		private AsyncTriggerPromiseDictionary<Collider2D> onTriggerExit2Ds; // 0x48
		private AsyncTriggerPromise<Collider2D> onTriggerStay2D; // 0x50
		private AsyncTriggerPromiseDictionary<Collider2D> onTriggerStay2Ds; // 0x58
	
		// Constructors
		public AsyncTrigger2DTrigger(); // 0x00000001816646D0-0x0000000181664730
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000181664380-0x0000000181664430
		private void OnTriggerEnter2D(Collider2D other); // 0x00000001816644B0-0x0000000181664510
		public UniTask<Collider2D> OnTriggerEnter2DAsync(CancellationToken cancellationToken = default); // 0x0000000181664430-0x00000001816644B0
		private void OnTriggerExit2D(Collider2D other); // 0x0000000181664590-0x00000001816645F0
		public UniTask<Collider2D> OnTriggerExit2DAsync(CancellationToken cancellationToken = default); // 0x0000000181664510-0x0000000181664590
		private void OnTriggerStay2D(Collider2D other); // 0x0000000181664670-0x00000001816646D0
		public UniTask<Collider2D> OnTriggerStay2DAsync(CancellationToken cancellationToken = default); // 0x00000001816645F0-0x0000000181664670
	}
}
