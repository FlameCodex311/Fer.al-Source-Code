/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async;
using UnityEngine;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Triggers
{
	public static class AsyncTriggerExtensions // TypeDefIndex: 8684
	{
		// Methods
		private static T GetOrAddComponent<T>(GameObject gameObject)
			where T : Component;
	
		// Extension methods
		public static UniTask OnDestroyAsync(this GameObject gameObject); // 0x0000000181666810-0x0000000181666860
		public static UniTask OnDestroyAsync(this Component component); // 0x00000001816667A0-0x0000000181666810
		public static CancellationToken GetCancellationTokenOnDestroy(this GameObject gameObject); // 0x00000001816666E0-0x0000000181666730
		public static CancellationToken GetCancellationTokenOnDestroy(this Component component); // 0x0000000181666730-0x00000001816667A0
		public static UniTask StartAsync(this GameObject gameObject); // 0x0000000181666860-0x00000001816668B0
		public static UniTask StartAsync(this Component component); // 0x00000001816668B0-0x0000000181666920
		public static UniTask AwakeAsync(this GameObject gameObject); // 0x0000000181664FA0-0x0000000181664FF0
		public static UniTask AwakeAsync(this Component component); // 0x0000000181664FF0-0x0000000181665060
		public static AsyncAnimatorTrigger GetAsyncAnimatorTrigger(this GameObject gameObject); // 0x0000000181665060-0x00000001816650A0
		public static AsyncAnimatorTrigger GetAsyncAnimatorTrigger(this Component component); // 0x00000001816650A0-0x0000000181665100
		public static AsyncAwakeTrigger GetAsyncAwakeTrigger(this GameObject gameObject); // 0x0000000181665100-0x0000000181665140
		public static AsyncAwakeTrigger GetAsyncAwakeTrigger(this Component component); // 0x0000000181665140-0x00000001816651A0
		public static AsyncBeginDragTrigger GetAsyncBeginDragTrigger(this GameObject gameObject); // 0x00000001816651A0-0x00000001816651E0
		public static AsyncBeginDragTrigger GetAsyncBeginDragTrigger(this Component component); // 0x00000001816651E0-0x0000000181665240
		public static AsyncCancelTrigger GetAsyncCancelTrigger(this GameObject gameObject); // 0x0000000181665240-0x0000000181665280
		public static AsyncCancelTrigger GetAsyncCancelTrigger(this Component component); // 0x0000000181665280-0x00000001816652E0
		public static AsyncCanvasGroupChangedTrigger GetAsyncCanvasGroupChangedTrigger(this GameObject gameObject); // 0x0000000181665340-0x0000000181665380
		public static AsyncCanvasGroupChangedTrigger GetAsyncCanvasGroupChangedTrigger(this Component component); // 0x00000001816652E0-0x0000000181665340
		public static AsyncCollision2DTrigger GetAsyncCollision2DTrigger(this GameObject gameObject); // 0x0000000181665380-0x00000001816653C0
		public static AsyncCollision2DTrigger GetAsyncCollision2DTrigger(this Component component); // 0x00000001816653C0-0x0000000181665420
		public static AsyncCollisionTrigger GetAsyncCollisionTrigger(this GameObject gameObject); // 0x0000000181665480-0x00000001816654C0
		public static AsyncCollisionTrigger GetAsyncCollisionTrigger(this Component component); // 0x0000000181665420-0x0000000181665480
		public static AsyncDeselectTrigger GetAsyncDeselectTrigger(this GameObject gameObject); // 0x00000001816654C0-0x0000000181665500
		public static AsyncDeselectTrigger GetAsyncDeselectTrigger(this Component component); // 0x0000000181665500-0x0000000181665560
		public static AsyncDestroyTrigger GetAsyncDestroyTrigger(this GameObject gameObject); // 0x00000001816655C0-0x0000000181665600
		public static AsyncDestroyTrigger GetAsyncDestroyTrigger(this Component component); // 0x0000000181665560-0x00000001816655C0
		public static AsyncDragTrigger GetAsyncDragTrigger(this GameObject gameObject); // 0x0000000181665600-0x0000000181665640
		public static AsyncDragTrigger GetAsyncDragTrigger(this Component component); // 0x0000000181665640-0x00000001816656A0
		public static AsyncDropTrigger GetAsyncDropTrigger(this GameObject gameObject); // 0x00000001816656A0-0x00000001816656E0
		public static AsyncDropTrigger GetAsyncDropTrigger(this Component component); // 0x00000001816656E0-0x0000000181665740
		public static AsyncEnableDisableTrigger GetAsyncEnableDisableTrigger(this GameObject gameObject); // 0x0000000181665740-0x0000000181665780
		public static AsyncEnableDisableTrigger GetAsyncEnableDisableTrigger(this Component component); // 0x0000000181665780-0x00000001816657E0
		public static AsyncEndDragTrigger GetAsyncEndDragTrigger(this GameObject gameObject); // 0x0000000181665840-0x0000000181665880
		public static AsyncEndDragTrigger GetAsyncEndDragTrigger(this Component component); // 0x00000001816657E0-0x0000000181665840
		public static AsyncFixedUpdateTrigger GetAsyncFixedUpdateTrigger(this GameObject gameObject); // 0x00000001816658E0-0x0000000181665920
		public static AsyncFixedUpdateTrigger GetAsyncFixedUpdateTrigger(this Component component); // 0x0000000181665880-0x00000001816658E0
		public static AsyncInitializePotentialDragTrigger GetAsyncInitializePotentialDragTrigger(this GameObject gameObject); // 0x0000000181665980-0x00000001816659C0
		public static AsyncInitializePotentialDragTrigger GetAsyncInitializePotentialDragTrigger(this Component component); // 0x0000000181665920-0x0000000181665980
		public static AsyncJointTrigger GetAsyncJointTrigger(this GameObject gameObject); // 0x0000000181665A20-0x0000000181665A60
		public static AsyncJointTrigger GetAsyncJointTrigger(this Component component); // 0x00000001816659C0-0x0000000181665A20
		public static AsyncLateUpdateTrigger GetAsyncLateUpdateTrigger(this GameObject gameObject); // 0x0000000181665AC0-0x0000000181665B00
		public static AsyncLateUpdateTrigger GetAsyncLateUpdateTrigger(this Component component); // 0x0000000181665A60-0x0000000181665AC0
		public static AsyncMouseTrigger GetAsyncMouseTrigger(this GameObject gameObject); // 0x0000000181665B00-0x0000000181665B40
		public static AsyncMouseTrigger GetAsyncMouseTrigger(this Component component); // 0x0000000181665B40-0x0000000181665BA0
		public static AsyncMoveTrigger GetAsyncMoveTrigger(this GameObject gameObject); // 0x0000000181665C00-0x0000000181665C40
		public static AsyncMoveTrigger GetAsyncMoveTrigger(this Component component); // 0x0000000181665BA0-0x0000000181665C00
		public static AsyncParticleTrigger GetAsyncParticleTrigger(this GameObject gameObject); // 0x0000000181665C40-0x0000000181665C80
		public static AsyncParticleTrigger GetAsyncParticleTrigger(this Component component); // 0x0000000181665C80-0x0000000181665CE0
		public static AsyncPointerClickTrigger GetAsyncPointerClickTrigger(this GameObject gameObject); // 0x0000000181665D40-0x0000000181665D80
		public static AsyncPointerClickTrigger GetAsyncPointerClickTrigger(this Component component); // 0x0000000181665CE0-0x0000000181665D40
		public static AsyncPointerDownTrigger GetAsyncPointerDownTrigger(this GameObject gameObject); // 0x0000000181665DE0-0x0000000181665E20
		public static AsyncPointerDownTrigger GetAsyncPointerDownTrigger(this Component component); // 0x0000000181665D80-0x0000000181665DE0
		public static AsyncPointerEnterTrigger GetAsyncPointerEnterTrigger(this GameObject gameObject); // 0x0000000181665E20-0x0000000181665E60
		public static AsyncPointerEnterTrigger GetAsyncPointerEnterTrigger(this Component component); // 0x0000000181665E60-0x0000000181665EC0
		public static AsyncPointerExitTrigger GetAsyncPointerExitTrigger(this GameObject gameObject); // 0x0000000181665EC0-0x0000000181665F00
		public static AsyncPointerExitTrigger GetAsyncPointerExitTrigger(this Component component); // 0x0000000181665F00-0x0000000181665F60
		public static AsyncPointerUpTrigger GetAsyncPointerUpTrigger(this GameObject gameObject); // 0x0000000181665F60-0x0000000181665FA0
		public static AsyncPointerUpTrigger GetAsyncPointerUpTrigger(this Component component); // 0x0000000181665FA0-0x0000000181666000
		public static AsyncRectTransformTrigger GetAsyncRectTransformTrigger(this GameObject gameObject); // 0x0000000181666060-0x00000001816660A0
		public static AsyncRectTransformTrigger GetAsyncRectTransformTrigger(this Component component); // 0x0000000181666000-0x0000000181666060
		public static AsyncScrollTrigger GetAsyncScrollTrigger(this GameObject gameObject); // 0x0000000181666100-0x0000000181666140
		public static AsyncScrollTrigger GetAsyncScrollTrigger(this Component component); // 0x00000001816660A0-0x0000000181666100
		public static AsyncSelectTrigger GetAsyncSelectTrigger(this GameObject gameObject); // 0x0000000181666140-0x0000000181666180
		public static AsyncSelectTrigger GetAsyncSelectTrigger(this Component component); // 0x0000000181666180-0x00000001816661E0
		public static AsyncStartTrigger GetAsyncStartTrigger(this GameObject gameObject); // 0x00000001816661E0-0x0000000181666220
		public static AsyncStartTrigger GetAsyncStartTrigger(this Component component); // 0x0000000181666220-0x0000000181666280
		public static AsyncSubmitTrigger GetAsyncSubmitTrigger(this GameObject gameObject); // 0x00000001816662E0-0x0000000181666320
		public static AsyncSubmitTrigger GetAsyncSubmitTrigger(this Component component); // 0x0000000181666280-0x00000001816662E0
		public static AsyncTransformChangedTrigger GetAsyncTransformChangedTrigger(this GameObject gameObject); // 0x0000000181666380-0x00000001816663C0
		public static AsyncTransformChangedTrigger GetAsyncTransformChangedTrigger(this Component component); // 0x0000000181666320-0x0000000181666380
		public static AsyncTrigger2DTrigger GetAsyncTrigger2DTrigger(this GameObject gameObject); // 0x00000001816663C0-0x0000000181666400
		public static AsyncTrigger2DTrigger GetAsyncTrigger2DTrigger(this Component component); // 0x0000000181666400-0x0000000181666460
		public static AsyncTriggerTrigger GetAsyncTriggerTrigger(this GameObject gameObject); // 0x0000000181666460-0x00000001816664A0
		public static AsyncTriggerTrigger GetAsyncTriggerTrigger(this Component component); // 0x00000001816664A0-0x0000000181666500
		public static AsyncUpdateSelectedTrigger GetAsyncUpdateSelectedTrigger(this GameObject gameObject); // 0x0000000181666560-0x00000001816665A0
		public static AsyncUpdateSelectedTrigger GetAsyncUpdateSelectedTrigger(this Component component); // 0x0000000181666500-0x0000000181666560
		public static AsyncUpdateTrigger GetAsyncUpdateTrigger(this GameObject gameObject); // 0x00000001816665A0-0x00000001816665E0
		public static AsyncUpdateTrigger GetAsyncUpdateTrigger(this Component component); // 0x00000001816665E0-0x0000000181666640
		public static AsyncVisibleTrigger GetAsyncVisibleTrigger(this GameObject gameObject); // 0x00000001816666A0-0x00000001816666E0
		public static AsyncVisibleTrigger GetAsyncVisibleTrigger(this Component component); // 0x0000000181666640-0x00000001816666A0
	}
}
