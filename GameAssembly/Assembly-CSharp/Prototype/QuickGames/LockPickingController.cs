/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class LockPickingController : QuickGamesBase // TypeDefIndex: 14881
	{
		// Fields
		public bool initializeFromSettings; // 0xF0
		public QGEChestSettings settings; // 0xF8
		public NetworkedObjectInfo usePickNetworkObject; // 0x100
		public ObscuredInt totalPicks; // 0x108
		public GameObject pickPrefab; // 0x120
		public GameObject ringPrefab; // 0x128
		public GameObject levelHolderPrefab; // 0x130
		public List<LockPickingLevel> levels; // 0x138
		[Header] // 0x00000001802136B0-0x00000001802136E0
		public Image foregroundPickHolderImage; // 0x140
		public Image foregroundPickImage; // 0x148
		public Image foregroundCloseButtonImage; // 0x150
		public WWTextMeshProUGUI foregroundPickCountText; // 0x158
		public WWButton closeButton; // 0x160
		public GameObject background; // 0x168
		public GameObject board; // 0x170
		[Header] // 0x000000018023EFE0-0x000000018023F010
		public FeralAudioInfo openGameSfx; // 0x178
		public FeralAudioInfo closeGameSfx; // 0x180
		public FeralAudioInfo lockPickMusic; // 0x188
		public FeralAudioInfo bronzeLockpickMusic; // 0x190
		public FeralAudioInfo silverLockpickMusic; // 0x198
		public FeralAudioInfo goldLockpickMusic; // 0x1A0
		public FeralAudioInfo lifeLostSfx; // 0x1A8
		public FeralAudioInfo lockPickedSfx; // 0x1B0
		public FeralAudioInfo fadeRingsSfx; // 0x1B8
		public FeralAudioInfo treasureSfx; // 0x1C0
		public List<FeralAudioInfo> ringSuccessSfx; // 0x1C8
		private RectTransform boardRectTransform; // 0x1D0
		private GameObject locks; // 0x1D8
		private RectTransform locksRectTransform; // 0x1E0
		private List<GameObject> levelHolders; // 0x1E8
		private GameObject pick; // 0x1F0
		private LockPickingLockPickController pickController; // 0x1F8
		private Vector2 pickVelocity; // 0x200
		private List<LockPickingRingController> ringControllers; // 0x208
		private List<LockPickingRingController> oldRingControllers; // 0x210
		private LockPickingLevel currentLevel; // 0x218
		private LockPickingChestType chestType; // 0x268
		private int currRingIndex; // 0x26C
		private GameObject oldLevelHolder; // 0x270
		private GameObject backgroundCenter; // 0x278
		private Image backgroundCenterImage; // 0x280
		private bool levelTransitioning; // 0x288
		private bool allLocksOpen; // 0x289
		private bool _incrementLevelOnLevelComplete; // 0x28A
		private bool _incrementalRewards; // 0x28B
		private float _startLocksRectPosX; // 0x28C
		private int _currentRound; // 0x290
		private FeralAudioInfo _playedMusic; // 0x298
		private PlayerCameraMode _savedPlayerCameraMode; // 0x2A0
		private int _inputBlockers; // 0x2A4
		private Color centerColorA; // 0x2A8
		private Color centerColorB; // 0x2B8
		private float centerFadeTime; // 0x2C8
		private float elapsedCenterFadeTime; // 0x2CC
		private Vector2 boardPosA; // 0x2D0
		private Vector2 boardPosB; // 0x2D8
		private float boardPanTime; // 0x2E0
		private float elapsedTime; // 0x2E4
	
		// Properties
		public bool InputBlocked { get; } // 0x0000000180988660-0x0000000180988670 
	
		// Nested types
		[Serializable]
		public struct LockPickingLevel // TypeDefIndex: 14882
		{
			// Fields
			public Sprite background; // 0x00
			public Sprite center; // 0x08
			public GameObject centerUnlockFx; // 0x10
			public Sprite pickHolder; // 0x18
			public Sprite closeButton; // 0x20
			public GameObject lockGroup; // 0x28
			public List<WWImage> locks; // 0x30
			public List<GameObject> unlockFx; // 0x38
			public Sprite lockedSprite; // 0x40
			public Sprite unlockedSprite; // 0x48
	
			// Methods
			public void SetLockState(int inIndex, bool locked = true /* Metadata: 0x007BB01D */); // 0x0000000180027240-0x0000000180027250
			public void ShowUnlockFx(int inIndex); // 0x0000000180027250-0x00000001800275B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass62_0 // TypeDefIndex: 14883
		{
			// Fields
			public LockPickingRingController ring; // 0x10
	
			// Constructors
			public <>c__DisplayClass62_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <QuickGameUpdate>b__2(); // 0x00000001809970A0-0x00000001809970C0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CompleteLevel>d__66 : IEnumerator<object> // TypeDefIndex: 14884
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingController <>4__this; // 0x20
			private int <nextLevelIndex>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <CompleteLevel>d__66(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180991660-0x0000000180991BF0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180991BF0-0x0000000180991C40
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass67_0 // TypeDefIndex: 14885
		{
			// Fields
			public bool showingLosePopup; // 0x10
			public LockPickingController <>4__this; // 0x18
	
			// Constructors
			public <>c__DisplayClass67_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <CompleteGame>b__0(); // 0x00000001809970C0-0x00000001809970F0
			internal bool <CompleteGame>b__1(); // 0x00000001803FD450-0x00000001803FD460
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CompleteGame>d__67 : IEnumerator<object> // TypeDefIndex: 14886
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingController <>4__this; // 0x20
			private <>c__DisplayClass67_0 <>8__1; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <CompleteGame>d__67(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001809912D0-0x0000000180991610
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180991610-0x0000000180991660
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__68 : IEnumerator<object> // TypeDefIndex: 14887
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__68(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001809964A0-0x00000001809966A0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001809966A0-0x00000001809966F0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AnimateLocksFading>d__69 : IEnumerator<object> // TypeDefIndex: 14888
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AnimateLocksFading>d__69(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180990940-0x0000000180990E40
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180990E40-0x0000000180990E90
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AnimateCenterFading>d__74 : IEnumerator<object> // TypeDefIndex: 14889
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AnimateCenterFading>d__74(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180990340-0x0000000180990470
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180990470-0x00000001809904C0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AnimateBoardPan>d__79 : IEnumerator<object> // TypeDefIndex: 14890
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AnimateBoardPan>d__79(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x000000018098FF40-0x00000001809900C0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001809900C0-0x0000000180990110
		}
	
		// Constructors
		public LockPickingController(); // 0x00000001809885F0-0x0000000180988660
	
		// Methods
		public override void MStart(); // 0x0000000180987110-0x00000001809875C0
		public override void MOnDestroy(); // 0x0000000180986ED0-0x0000000180987110
		private void OnBackButton(); // 0x0000000180985F70-0x0000000180986010
		private void Initialize(); // 0x0000000180986EA0-0x0000000180986ED0
		private void InitializeFromSettings(QGEChestSettings inSettings); // 0x0000000180986170-0x0000000180986290
		private void InitializeLevelHolders(); // 0x0000000180986290-0x0000000180986480
		private void InitializeLevel(LockPickingChestType inChestType); // 0x0000000180986480-0x0000000180986CD0
		private void InitializePick(); // 0x0000000180986CD0-0x0000000180986EA0
		private void DestroyOldLevel(); // 0x00000001809860D0-0x0000000180986170
		public override void QuickGameUpdate(); // 0x00000001809879A0-0x0000000180987EF0
		public void PassedRing(LockPickingRingController ringController); // 0x0000000180987720-0x0000000180987850
		public int PickHitRing(); // 0x0000000180987850-0x00000001809879A0
		public void UsePick(); // 0x0000000180988440-0x00000001809885F0
		[IteratorStateMachine] // 0x0000000180246140-0x0000000180246190
		private IEnumerator CompleteLevel(); // 0x0000000180986070-0x00000001809860D0
		[IteratorStateMachine] // 0x0000000180246350-0x00000001802463A0
		private IEnumerator CompleteGame(); // 0x0000000180986010-0x0000000180986070
		[IteratorStateMachine] // 0x0000000180246640-0x0000000180246690
		public override IEnumerator ShowResults(); // 0x00000001809881D0-0x0000000180988230
		[IteratorStateMachine] // 0x0000000180246890-0x00000001802468E0
		private IEnumerator AnimateLocksFading(); // 0x0000000180985F10-0x0000000180985F70
		[IteratorStateMachine] // 0x0000000180246BF0-0x0000000180246C40
		private IEnumerator AnimateCenterFading(); // 0x0000000180985EB0-0x0000000180985F10
		[IteratorStateMachine] // 0x0000000180247180-0x00000001802471D0
		private IEnumerator AnimateBoardPan(); // 0x0000000180985E50-0x0000000180985EB0
		public void SetPickCountText(int inCount, bool doFx = true /* Metadata: 0x007BB01C */); // 0x0000000180987EF0-0x00000001809881D0
		public void BtnClicked_Close(); // 0x0000000180985F70-0x0000000180986010
		private void OnWindowOpened(WindowOpenedMessage inMessage); // 0x0000000180987690-0x0000000180987720
		private void OnWindowClosed(WindowClosedMessage inMessage); // 0x00000001809875C0-0x0000000180987690
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <MStart>b__53_0(); // 0x0000000180988260-0x0000000180988380
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <InitializeFromSettings>b__57_0(); // 0x0000000180988250-0x0000000180988260
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <QuickGameUpdate>b__62_0(); // 0x0000000180988380-0x00000001809883B0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <QuickGameUpdate>b__62_1(); // 0x00000001809883B0-0x00000001809883E0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180982AE0-0x0000000180982AF0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <SetPickCountText>b__80_0(); // 0x00000001809883E0-0x0000000180988410
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <SetPickCountText>b__80_1(string text); // 0x0000000180988410-0x0000000180988440
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <BtnClicked_Close>b__81_0(bool answer); // 0x0000000180988230-0x0000000180988250
	}
}
