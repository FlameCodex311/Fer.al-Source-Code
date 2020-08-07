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

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class AsyncEventTrigger : AsyncTriggerBase // TypeDefIndex: 8818
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
		public AsyncEventTrigger(); // 0x0000000180E0EB50-0x0000000180E0EBB0
	
		// Methods
		protected override IEnumerable<ICancelablePromise> GetPromises(); // 0x0000000180E0D090-0x0000000180E0DC70
		private void OnDeselect(BaseEventData eventData); // 0x0000000180E0DEB0-0x0000000180E0DF10
		public UniTask<BaseEventData> OnDeselectAsync(CancellationToken cancellationToken = default); // 0x0000000180E0DE30-0x0000000180E0DEB0
		private void OnMove(AxisEventData eventData); // 0x0000000180E0E310-0x0000000180E0E370
		public UniTask<AxisEventData> OnMoveAsync(CancellationToken cancellationToken = default); // 0x0000000180E0E290-0x0000000180E0E310
		private void OnPointerDown(PointerEventData eventData); // 0x0000000180E0E4D0-0x0000000180E0E530
		public UniTask<PointerEventData> OnPointerDownAsync(CancellationToken cancellationToken = default); // 0x0000000180E0E450-0x0000000180E0E4D0
		private void OnPointerEnter(PointerEventData eventData); // 0x0000000180E0E5B0-0x0000000180E0E610
		public UniTask<PointerEventData> OnPointerEnterAsync(CancellationToken cancellationToken = default); // 0x0000000180E0E530-0x0000000180E0E5B0
		private void OnPointerExit(PointerEventData eventData); // 0x0000000180E0E690-0x0000000180E0E6F0
		public UniTask<PointerEventData> OnPointerExitAsync(CancellationToken cancellationToken = default); // 0x0000000180E0E610-0x0000000180E0E690
		private void OnPointerUp(PointerEventData eventData); // 0x0000000180E0E770-0x0000000180E0E7D0
		public UniTask<PointerEventData> OnPointerUpAsync(CancellationToken cancellationToken = default); // 0x0000000180E0E6F0-0x0000000180E0E770
		private void OnSelect(BaseEventData eventData); // 0x0000000180E0E930-0x0000000180E0E990
		public UniTask<BaseEventData> OnSelectAsync(CancellationToken cancellationToken = default); // 0x0000000180E0E8B0-0x0000000180E0E930
		private void OnPointerClick(PointerEventData eventData); // 0x0000000180E0E3F0-0x0000000180E0E450
		public UniTask<PointerEventData> OnPointerClickAsync(CancellationToken cancellationToken = default); // 0x0000000180E0E370-0x0000000180E0E3F0
		private void OnSubmit(BaseEventData eventData); // 0x0000000180E0EA10-0x0000000180E0EA70
		public UniTask<BaseEventData> OnSubmitAsync(CancellationToken cancellationToken = default); // 0x0000000180E0E990-0x0000000180E0EA10
		private void OnDrag(PointerEventData eventData); // 0x0000000180E0DF90-0x0000000180E0DFF0
		public UniTask<PointerEventData> OnDragAsync(CancellationToken cancellationToken = default); // 0x0000000180E0DF10-0x0000000180E0DF90
		private void OnBeginDrag(PointerEventData eventData); // 0x0000000180E0DCF0-0x0000000180E0DD50
		public UniTask<PointerEventData> OnBeginDragAsync(CancellationToken cancellationToken = default); // 0x0000000180E0DC70-0x0000000180E0DCF0
		private void OnEndDrag(PointerEventData eventData); // 0x0000000180E0E150-0x0000000180E0E1B0
		public UniTask<PointerEventData> OnEndDragAsync(CancellationToken cancellationToken = default); // 0x0000000180E0E0D0-0x0000000180E0E150
		private void OnDrop(PointerEventData eventData); // 0x0000000180E0E070-0x0000000180E0E0D0
		public UniTask<PointerEventData> OnDropAsync(CancellationToken cancellationToken = default); // 0x0000000180E0DFF0-0x0000000180E0E070
		private void OnUpdateSelected(BaseEventData eventData); // 0x0000000180E0EAF0-0x0000000180E0EB50
		public UniTask<BaseEventData> OnUpdateSelectedAsync(CancellationToken cancellationToken = default); // 0x0000000180E0EA70-0x0000000180E0EAF0
		private void OnInitializePotentialDrag(PointerEventData eventData); // 0x0000000180E0E230-0x0000000180E0E290
		public UniTask<PointerEventData> OnInitializePotentialDragAsync(CancellationToken cancellationToken = default); // 0x0000000180E0E1B0-0x0000000180E0E230
		private void OnCancel(BaseEventData eventData); // 0x0000000180E0DDD0-0x0000000180E0DE30
		public UniTask<BaseEventData> OnCancelAsync(CancellationToken cancellationToken = default); // 0x0000000180E0DD50-0x0000000180E0DDD0
		private void OnScroll(PointerEventData eventData); // 0x0000000180E0E850-0x0000000180E0E8B0
		public UniTask<PointerEventData> OnScrollAsync(CancellationToken cancellationToken = default); // 0x0000000180E0E7D0-0x0000000180E0E850
	}
}
