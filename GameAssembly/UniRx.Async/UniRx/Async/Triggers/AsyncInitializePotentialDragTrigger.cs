﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent] // 0x00000001800B36B0-0x00000001800B36C0
	public class AsyncInitializePotentialDragTrigger : AsyncTriggerBase, IInitializePotentialDragHandler // TypeDefIndex: 8654
	{
		// Fields
		private AsyncTriggerPromise<PointerEventData> onInitializePotentialDrag; // 0x30
		private AsyncTriggerPromiseDictionary<PointerEventData> onInitializePotentialDrags; // 0x38
	
		// Constructors
		public AsyncInitializePotentialDragTrigger(); // 0x0000000181661750-0x00000001816617B0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000181661600-0x0000000181661670
		void IInitializePotentialDragHandler.OnInitializePotentialDrag(PointerEventData eventData); // 0x00000001816616F0-0x0000000181661750
		public UniTask<PointerEventData> OnInitializePotentialDragAsync(CancellationToken cancellationToken = default); // 0x0000000181661670-0x00000001816616F0
	}
}
