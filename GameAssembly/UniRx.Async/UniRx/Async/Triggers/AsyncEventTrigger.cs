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
using UnityEngine.EventSystems;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent] // 0x00000001800B36B0-0x00000001800B36C0
	public class AsyncEventTrigger : AsyncTriggerBase // TypeDefIndex: 8652
	{
		// Fields
		private AsyncTriggerPromise<BaseEventData> onDeselect; // 0x30
		private AsyncTriggerPromiseDictionary<BaseEventData> onDeselects; // 0x38
		private AsyncTriggerPromise<AxisEventData> onMove; // 0x40
		private AsyncTriggerPromiseDictionary<AxisEventData> onMoves; // 0x48
		private AsyncTriggerPromise<PointerEventData> onPointerDown; // 0x50
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerDowns; // 0x58
		private AsyncTriggerPromise<PointerEventData> onPointerEnter; // 0x60
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerEnters; // 0x68
		private AsyncTriggerPromise<PointerEventData> onPointerExit; // 0x70
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerExits; // 0x78
		private AsyncTriggerPromise<PointerEventData> onPointerUp; // 0x80
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerUps; // 0x88
		private AsyncTriggerPromise<BaseEventData> onSelect; // 0x90
		private AsyncTriggerPromiseDictionary<BaseEventData> onSelects; // 0x98
		private AsyncTriggerPromise<PointerEventData> onPointerClick; // 0xA0
		private AsyncTriggerPromiseDictionary<PointerEventData> onPointerClicks; // 0xA8
		private AsyncTriggerPromise<BaseEventData> onSubmit; // 0xB0
		private AsyncTriggerPromiseDictionary<BaseEventData> onSubmits; // 0xB8
		private AsyncTriggerPromise<PointerEventData> onDrag; // 0xC0
		private AsyncTriggerPromiseDictionary<PointerEventData> onDrags; // 0xC8
		private AsyncTriggerPromise<PointerEventData> onBeginDrag; // 0xD0
		private AsyncTriggerPromiseDictionary<PointerEventData> onBeginDrags; // 0xD8
		private AsyncTriggerPromise<PointerEventData> onEndDrag; // 0xE0
		private AsyncTriggerPromiseDictionary<PointerEventData> onEndDrags; // 0xE8
		private AsyncTriggerPromise<PointerEventData> onDrop; // 0xF0
		private AsyncTriggerPromiseDictionary<PointerEventData> onDrops; // 0xF8
		private AsyncTriggerPromise<BaseEventData> onUpdateSelected; // 0x100
		private AsyncTriggerPromiseDictionary<BaseEventData> onUpdateSelecteds; // 0x108
		private AsyncTriggerPromise<PointerEventData> onInitializePotentialDrag; // 0x110
		private AsyncTriggerPromiseDictionary<PointerEventData> onInitializePotentialDrags; // 0x118
		private AsyncTriggerPromise<BaseEventData> onCancel; // 0x120
		private AsyncTriggerPromiseDictionary<BaseEventData> onCancels; // 0x128
		private AsyncTriggerPromise<PointerEventData> onScroll; // 0x130
		private AsyncTriggerPromiseDictionary<PointerEventData> onScrolls; // 0x138
	
		// Constructors
		public AsyncEventTrigger(); // 0x00000001816613B0-0x0000000181661410
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x000000018165F830-0x00000001816604D0
		private void OnDeselect(BaseEventData eventData); // 0x0000000181660710-0x0000000181660770
		public UniTask<BaseEventData> OnDeselectAsync(CancellationToken cancellationToken = default); // 0x0000000181660690-0x0000000181660710
		private void OnMove(AxisEventData eventData); // 0x0000000181660B70-0x0000000181660BD0
		public UniTask<AxisEventData> OnMoveAsync(CancellationToken cancellationToken = default); // 0x0000000181660AF0-0x0000000181660B70
		private void OnPointerDown(PointerEventData eventData); // 0x0000000181660D30-0x0000000181660D90
		public UniTask<PointerEventData> OnPointerDownAsync(CancellationToken cancellationToken = default); // 0x0000000181660CB0-0x0000000181660D30
		private void OnPointerEnter(PointerEventData eventData); // 0x0000000181660E10-0x0000000181660E70
		public UniTask<PointerEventData> OnPointerEnterAsync(CancellationToken cancellationToken = default); // 0x0000000181660D90-0x0000000181660E10
		private void OnPointerExit(PointerEventData eventData); // 0x0000000181660EF0-0x0000000181660F50
		public UniTask<PointerEventData> OnPointerExitAsync(CancellationToken cancellationToken = default); // 0x0000000181660E70-0x0000000181660EF0
		private void OnPointerUp(PointerEventData eventData); // 0x0000000181660FD0-0x0000000181661030
		public UniTask<PointerEventData> OnPointerUpAsync(CancellationToken cancellationToken = default); // 0x0000000181660F50-0x0000000181660FD0
		private void OnSelect(BaseEventData eventData); // 0x0000000181661190-0x00000001816611F0
		public UniTask<BaseEventData> OnSelectAsync(CancellationToken cancellationToken = default); // 0x0000000181661110-0x0000000181661190
		private void OnPointerClick(PointerEventData eventData); // 0x0000000181660C50-0x0000000181660CB0
		public UniTask<PointerEventData> OnPointerClickAsync(CancellationToken cancellationToken = default); // 0x0000000181660BD0-0x0000000181660C50
		private void OnSubmit(BaseEventData eventData); // 0x0000000181661270-0x00000001816612D0
		public UniTask<BaseEventData> OnSubmitAsync(CancellationToken cancellationToken = default); // 0x00000001816611F0-0x0000000181661270
		private void OnDrag(PointerEventData eventData); // 0x00000001816607F0-0x0000000181660850
		public UniTask<PointerEventData> OnDragAsync(CancellationToken cancellationToken = default); // 0x0000000181660770-0x00000001816607F0
		private void OnBeginDrag(PointerEventData eventData); // 0x0000000181660550-0x00000001816605B0
		public UniTask<PointerEventData> OnBeginDragAsync(CancellationToken cancellationToken = default); // 0x00000001816604D0-0x0000000181660550
		private void OnEndDrag(PointerEventData eventData); // 0x00000001816609B0-0x0000000181660A10
		public UniTask<PointerEventData> OnEndDragAsync(CancellationToken cancellationToken = default); // 0x0000000181660930-0x00000001816609B0
		private void OnDrop(PointerEventData eventData); // 0x00000001816608D0-0x0000000181660930
		public UniTask<PointerEventData> OnDropAsync(CancellationToken cancellationToken = default); // 0x0000000181660850-0x00000001816608D0
		private void OnUpdateSelected(BaseEventData eventData); // 0x0000000181661350-0x00000001816613B0
		public UniTask<BaseEventData> OnUpdateSelectedAsync(CancellationToken cancellationToken = default); // 0x00000001816612D0-0x0000000181661350
		private void OnInitializePotentialDrag(PointerEventData eventData); // 0x0000000181660A90-0x0000000181660AF0
		public UniTask<PointerEventData> OnInitializePotentialDragAsync(CancellationToken cancellationToken = default); // 0x0000000181660A10-0x0000000181660A90
		private void OnCancel(BaseEventData eventData); // 0x0000000181660630-0x0000000181660690
		public UniTask<BaseEventData> OnCancelAsync(CancellationToken cancellationToken = default); // 0x00000001816605B0-0x0000000181660630
		private void OnScroll(PointerEventData eventData); // 0x00000001816610B0-0x0000000181661110
		public UniTask<PointerEventData> OnScrollAsync(CancellationToken cancellationToken = default); // 0x0000000181661030-0x00000001816610B0
	}
}
