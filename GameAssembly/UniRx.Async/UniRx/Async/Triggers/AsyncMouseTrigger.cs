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
	public class AsyncMouseTrigger : AsyncTriggerBase // TypeDefIndex: 8823
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
		public AsyncMouseTrigger(); // 0x0000000180E10100-0x0000000180E10160
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E0F3F0-0x0000000180E0F920
		private void OnMouseDown(); // 0x0000000180E0F9A0-0x0000000180E0FA40
		public UniTask OnMouseDownAsync(CancellationToken cancellationToken = default); // 0x0000000180E0F920-0x0000000180E0F9A0
		private void OnMouseDrag(); // 0x0000000180E0FAC0-0x0000000180E0FB60
		public UniTask OnMouseDragAsync(CancellationToken cancellationToken = default); // 0x0000000180E0FA40-0x0000000180E0FAC0
		private void OnMouseEnter(); // 0x0000000180E0FBE0-0x0000000180E0FC80
		public UniTask OnMouseEnterAsync(CancellationToken cancellationToken = default); // 0x0000000180E0FB60-0x0000000180E0FBE0
		private void OnMouseExit(); // 0x0000000180E0FD00-0x0000000180E0FDA0
		public UniTask OnMouseExitAsync(CancellationToken cancellationToken = default); // 0x0000000180E0FC80-0x0000000180E0FD00
		private void OnMouseOver(); // 0x0000000180E0FE20-0x0000000180E0FEC0
		public UniTask OnMouseOverAsync(CancellationToken cancellationToken = default); // 0x0000000180E0FDA0-0x0000000180E0FE20
		private void OnMouseUp(); // 0x0000000180E10060-0x0000000180E10100
		public UniTask OnMouseUpAsync(CancellationToken cancellationToken = default); // 0x0000000180E0FFE0-0x0000000180E10060
		private void OnMouseUpAsButton(); // 0x0000000180E0FF40-0x0000000180E0FFE0
		public UniTask OnMouseUpAsButtonAsync(CancellationToken cancellationToken = default); // 0x0000000180E0FEC0-0x0000000180E0FF40
	}
}
