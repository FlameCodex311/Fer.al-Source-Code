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
	public class AsyncMouseTrigger : AsyncTriggerBase // TypeDefIndex: 8657
	{
		// Fields
		private AsyncTriggerPromise<AsyncUnit> onMouseDown; // 0x30
		private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseDowns; // 0x38
		private AsyncTriggerPromise<AsyncUnit> onMouseDrag; // 0x40
		private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseDrags; // 0x48
		private AsyncTriggerPromise<AsyncUnit> onMouseEnter; // 0x50
		private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseEnters; // 0x58
		private AsyncTriggerPromise<AsyncUnit> onMouseExit; // 0x60
		private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseExits; // 0x68
		private AsyncTriggerPromise<AsyncUnit> onMouseOver; // 0x70
		private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseOvers; // 0x78
		private AsyncTriggerPromise<AsyncUnit> onMouseUp; // 0x80
		private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseUps; // 0x88
		private AsyncTriggerPromise<AsyncUnit> onMouseUpAsButton; // 0x90
		private AsyncTriggerPromiseDictionary<AsyncUnit> onMouseUpAsButtons; // 0x98
	
		// Constructors
		public AsyncMouseTrigger(); // 0x00000001816629C0-0x0000000181662A20
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000181661C50-0x00000001816621E0
		private void OnMouseDown(); // 0x0000000181662260-0x0000000181662300
		public UniTask OnMouseDownAsync(CancellationToken cancellationToken = default); // 0x00000001816621E0-0x0000000181662260
		private void OnMouseDrag(); // 0x0000000181662380-0x0000000181662420
		public UniTask OnMouseDragAsync(CancellationToken cancellationToken = default); // 0x0000000181662300-0x0000000181662380
		private void OnMouseEnter(); // 0x00000001816624A0-0x0000000181662540
		public UniTask OnMouseEnterAsync(CancellationToken cancellationToken = default); // 0x0000000181662420-0x00000001816624A0
		private void OnMouseExit(); // 0x00000001816625C0-0x0000000181662660
		public UniTask OnMouseExitAsync(CancellationToken cancellationToken = default); // 0x0000000181662540-0x00000001816625C0
		private void OnMouseOver(); // 0x00000001816626E0-0x0000000181662780
		public UniTask OnMouseOverAsync(CancellationToken cancellationToken = default); // 0x0000000181662660-0x00000001816626E0
		private void OnMouseUp(); // 0x0000000181662920-0x00000001816629C0
		public UniTask OnMouseUpAsync(CancellationToken cancellationToken = default); // 0x00000001816628A0-0x0000000181662920
		private void OnMouseUpAsButton(); // 0x0000000181662800-0x00000001816628A0
		public UniTask OnMouseUpAsButtonAsync(CancellationToken cancellationToken = default); // 0x0000000181662780-0x0000000181662800
	}
}
