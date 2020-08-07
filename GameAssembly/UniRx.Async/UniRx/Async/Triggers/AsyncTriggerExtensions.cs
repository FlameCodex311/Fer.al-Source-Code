/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;
using UnityEngine;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Triggers
{
	public static class AsyncTriggerExtensions // TypeDefIndex: 8850
	{
		// Methods
		private static T GetOrAddComponent<T>(GameObject gameObject)
			where T : Component;
	
		// Extension methods
		public static UniTask OnDestroyAsync(this GameObject gameObject); // 0x0000000180E13F50-0x0000000180E13FA0
		public static UniTask OnDestroyAsync(this Component component); // 0x0000000180E13EE0-0x0000000180E13F50
		public static CancellationToken GetCancellationTokenOnDestroy(this GameObject gameObject); // 0x0000000180E13E20-0x0000000180E13E70
		public static CancellationToken GetCancellationTokenOnDestroy(this Component component); // 0x0000000180E13E70-0x0000000180E13EE0
		public static UniTask StartAsync(this GameObject gameObject); // 0x0000000180E13FA0-0x0000000180E13FF0
		public static UniTask StartAsync(this Component component); // 0x0000000180E13FF0-0x0000000180E14060
		public static UniTask AwakeAsync(this GameObject gameObject); // 0x0000000180E126E0-0x0000000180E12730
		public static UniTask AwakeAsync(this Component component); // 0x0000000180E12730-0x0000000180E127A0
		public static AsyncAnimatorTrigger GetAsyncAnimatorTrigger(this GameObject gameObject); // 0x0000000180E127A0-0x0000000180E127E0
		public static AsyncAnimatorTrigger GetAsyncAnimatorTrigger(this Component component); // 0x0000000180E127E0-0x0000000180E12840
		public static AsyncAwakeTrigger GetAsyncAwakeTrigger(this GameObject gameObject); // 0x0000000180E12840-0x0000000180E12880
		public static AsyncAwakeTrigger GetAsyncAwakeTrigger(this Component component); // 0x0000000180E12880-0x0000000180E128E0
		public static AsyncBeginDragTrigger GetAsyncBeginDragTrigger(this GameObject gameObject); // 0x0000000180E128E0-0x0000000180E12920
		public static AsyncBeginDragTrigger GetAsyncBeginDragTrigger(this Component component); // 0x0000000180E12920-0x0000000180E12980
		public static AsyncCancelTrigger GetAsyncCancelTrigger(this GameObject gameObject); // 0x0000000180E12980-0x0000000180E129C0
		public static AsyncCancelTrigger GetAsyncCancelTrigger(this Component component); // 0x0000000180E129C0-0x0000000180E12A20
		public static AsyncCanvasGroupChangedTrigger GetAsyncCanvasGroupChangedTrigger(this GameObject gameObject); // 0x0000000180E12A80-0x0000000180E12AC0
		public static AsyncCanvasGroupChangedTrigger GetAsyncCanvasGroupChangedTrigger(this Component component); // 0x0000000180E12A20-0x0000000180E12A80
		public static AsyncCollision2DTrigger GetAsyncCollision2DTrigger(this GameObject gameObject); // 0x0000000180E12AC0-0x0000000180E12B00
		public static AsyncCollision2DTrigger GetAsyncCollision2DTrigger(this Component component); // 0x0000000180E12B00-0x0000000180E12B60
		public static AsyncCollisionTrigger GetAsyncCollisionTrigger(this GameObject gameObject); // 0x0000000180E12BC0-0x0000000180E12C00
		public static AsyncCollisionTrigger GetAsyncCollisionTrigger(this Component component); // 0x0000000180E12B60-0x0000000180E12BC0
		public static AsyncDeselectTrigger GetAsyncDeselectTrigger(this GameObject gameObject); // 0x0000000180E12C00-0x0000000180E12C40
		public static AsyncDeselectTrigger GetAsyncDeselectTrigger(this Component component); // 0x0000000180E12C40-0x0000000180E12CA0
		public static AsyncDestroyTrigger GetAsyncDestroyTrigger(this GameObject gameObject); // 0x0000000180E12D00-0x0000000180E12D40
		public static AsyncDestroyTrigger GetAsyncDestroyTrigger(this Component component); // 0x0000000180E12CA0-0x0000000180E12D00
		public static AsyncDragTrigger GetAsyncDragTrigger(this GameObject gameObject); // 0x0000000180E12D40-0x0000000180E12D80
		public static AsyncDragTrigger GetAsyncDragTrigger(this Component component); // 0x0000000180E12D80-0x0000000180E12DE0
		public static AsyncDropTrigger GetAsyncDropTrigger(this GameObject gameObject); // 0x0000000180E12DE0-0x0000000180E12E20
		public static AsyncDropTrigger GetAsyncDropTrigger(this Component component); // 0x0000000180E12E20-0x0000000180E12E80
		public static AsyncEnableDisableTrigger GetAsyncEnableDisableTrigger(this GameObject gameObject); // 0x0000000180E12E80-0x0000000180E12EC0
		public static AsyncEnableDisableTrigger GetAsyncEnableDisableTrigger(this Component component); // 0x0000000180E12EC0-0x0000000180E12F20
		public static AsyncEndDragTrigger GetAsyncEndDragTrigger(this GameObject gameObject); // 0x0000000180E12F80-0x0000000180E12FC0
		public static AsyncEndDragTrigger GetAsyncEndDragTrigger(this Component component); // 0x0000000180E12F20-0x0000000180E12F80
		public static AsyncFixedUpdateTrigger GetAsyncFixedUpdateTrigger(this GameObject gameObject); // 0x0000000180E13020-0x0000000180E13060
		public static AsyncFixedUpdateTrigger GetAsyncFixedUpdateTrigger(this Component component); // 0x0000000180E12FC0-0x0000000180E13020
		public static AsyncInitializePotentialDragTrigger GetAsyncInitializePotentialDragTrigger(this GameObject gameObject); // 0x0000000180E130C0-0x0000000180E13100
		public static AsyncInitializePotentialDragTrigger GetAsyncInitializePotentialDragTrigger(this Component component); // 0x0000000180E13060-0x0000000180E130C0
		public static AsyncJointTrigger GetAsyncJointTrigger(this GameObject gameObject); // 0x0000000180E13160-0x0000000180E131A0
		public static AsyncJointTrigger GetAsyncJointTrigger(this Component component); // 0x0000000180E13100-0x0000000180E13160
		public static AsyncLateUpdateTrigger GetAsyncLateUpdateTrigger(this GameObject gameObject); // 0x0000000180E13200-0x0000000180E13240
		public static AsyncLateUpdateTrigger GetAsyncLateUpdateTrigger(this Component component); // 0x0000000180E131A0-0x0000000180E13200
		public static AsyncMouseTrigger GetAsyncMouseTrigger(this GameObject gameObject); // 0x0000000180E13240-0x0000000180E13280
		public static AsyncMouseTrigger GetAsyncMouseTrigger(this Component component); // 0x0000000180E13280-0x0000000180E132E0
		public static AsyncMoveTrigger GetAsyncMoveTrigger(this GameObject gameObject); // 0x0000000180E13340-0x0000000180E13380
		public static AsyncMoveTrigger GetAsyncMoveTrigger(this Component component); // 0x0000000180E132E0-0x0000000180E13340
		public static AsyncParticleTrigger GetAsyncParticleTrigger(this GameObject gameObject); // 0x0000000180E13380-0x0000000180E133C0
		public static AsyncParticleTrigger GetAsyncParticleTrigger(this Component component); // 0x0000000180E133C0-0x0000000180E13420
		public static AsyncPointerClickTrigger GetAsyncPointerClickTrigger(this GameObject gameObject); // 0x0000000180E13480-0x0000000180E134C0
		public static AsyncPointerClickTrigger GetAsyncPointerClickTrigger(this Component component); // 0x0000000180E13420-0x0000000180E13480
		public static AsyncPointerDownTrigger GetAsyncPointerDownTrigger(this GameObject gameObject); // 0x0000000180E13520-0x0000000180E13560
		public static AsyncPointerDownTrigger GetAsyncPointerDownTrigger(this Component component); // 0x0000000180E134C0-0x0000000180E13520
		public static AsyncPointerEnterTrigger GetAsyncPointerEnterTrigger(this GameObject gameObject); // 0x0000000180E13560-0x0000000180E135A0
		public static AsyncPointerEnterTrigger GetAsyncPointerEnterTrigger(this Component component); // 0x0000000180E135A0-0x0000000180E13600
		public static AsyncPointerExitTrigger GetAsyncPointerExitTrigger(this GameObject gameObject); // 0x0000000180E13600-0x0000000180E13640
		public static AsyncPointerExitTrigger GetAsyncPointerExitTrigger(this Component component); // 0x0000000180E13640-0x0000000180E136A0
		public static AsyncPointerUpTrigger GetAsyncPointerUpTrigger(this GameObject gameObject); // 0x0000000180E136A0-0x0000000180E136E0
		public static AsyncPointerUpTrigger GetAsyncPointerUpTrigger(this Component component); // 0x0000000180E136E0-0x0000000180E13740
		public static AsyncRectTransformTrigger GetAsyncRectTransformTrigger(this GameObject gameObject); // 0x0000000180E137A0-0x0000000180E137E0
		public static AsyncRectTransformTrigger GetAsyncRectTransformTrigger(this Component component); // 0x0000000180E13740-0x0000000180E137A0
		public static AsyncScrollTrigger GetAsyncScrollTrigger(this GameObject gameObject); // 0x0000000180E13840-0x0000000180E13880
		public static AsyncScrollTrigger GetAsyncScrollTrigger(this Component component); // 0x0000000180E137E0-0x0000000180E13840
		public static AsyncSelectTrigger GetAsyncSelectTrigger(this GameObject gameObject); // 0x0000000180E13880-0x0000000180E138C0
		public static AsyncSelectTrigger GetAsyncSelectTrigger(this Component component); // 0x0000000180E138C0-0x0000000180E13920
		public static AsyncStartTrigger GetAsyncStartTrigger(this GameObject gameObject); // 0x0000000180E13920-0x0000000180E13960
		public static AsyncStartTrigger GetAsyncStartTrigger(this Component component); // 0x0000000180E13960-0x0000000180E139C0
		public static AsyncSubmitTrigger GetAsyncSubmitTrigger(this GameObject gameObject); // 0x0000000180E13A20-0x0000000180E13A60
		public static AsyncSubmitTrigger GetAsyncSubmitTrigger(this Component component); // 0x0000000180E139C0-0x0000000180E13A20
		public static AsyncTransformChangedTrigger GetAsyncTransformChangedTrigger(this GameObject gameObject); // 0x0000000180E13AC0-0x0000000180E13B00
		public static AsyncTransformChangedTrigger GetAsyncTransformChangedTrigger(this Component component); // 0x0000000180E13A60-0x0000000180E13AC0
		public static AsyncTrigger2DTrigger GetAsyncTrigger2DTrigger(this GameObject gameObject); // 0x0000000180E13B00-0x0000000180E13B40
		public static AsyncTrigger2DTrigger GetAsyncTrigger2DTrigger(this Component component); // 0x0000000180E13B40-0x0000000180E13BA0
		public static AsyncTriggerTrigger GetAsyncTriggerTrigger(this GameObject gameObject); // 0x0000000180E13BA0-0x0000000180E13BE0
		public static AsyncTriggerTrigger GetAsyncTriggerTrigger(this Component component); // 0x0000000180E13BE0-0x0000000180E13C40
		public static AsyncUpdateSelectedTrigger GetAsyncUpdateSelectedTrigger(this GameObject gameObject); // 0x0000000180E13CA0-0x0000000180E13CE0
		public static AsyncUpdateSelectedTrigger GetAsyncUpdateSelectedTrigger(this Component component); // 0x0000000180E13C40-0x0000000180E13CA0
		public static AsyncUpdateTrigger GetAsyncUpdateTrigger(this GameObject gameObject); // 0x0000000180E13CE0-0x0000000180E13D20
		public static AsyncUpdateTrigger GetAsyncUpdateTrigger(this Component component); // 0x0000000180E13D20-0x0000000180E13D80
		public static AsyncVisibleTrigger GetAsyncVisibleTrigger(this GameObject gameObject); // 0x0000000180E13DE0-0x0000000180E13E20
		public static AsyncVisibleTrigger GetAsyncVisibleTrigger(this Component component); // 0x0000000180E13D80-0x0000000180E13DE0
	}
}
