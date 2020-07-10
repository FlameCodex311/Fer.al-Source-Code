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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class LockPickingController : QuickGamesBase // TypeDefIndex: 16139
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
		[Header] // 0x0000000180126FD0-0x0000000180127000
		public Image foregroundPickHolderImage; // 0x140
		public Image foregroundPickImage; // 0x148
		public Image foregroundCloseButtonImage; // 0x150
		public WWTextMeshProUGUI foregroundPickCountText; // 0x158
		public WWButton closeButton; // 0x160
		public GameObject background; // 0x168
		public GameObject board; // 0x170
		[Header] // 0x0000000180127080-0x00000001801270B0
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
		public bool InputBlocked { get; } // 0x00000001813F11F0-0x00000001813F1200 
	
		// Nested types
		[Serializable]
		public struct LockPickingLevel // TypeDefIndex: 16140
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
			public void SetLockState(int inIndex, bool locked = true /* Metadata: 0x0078542B */); // 0x00000001802226C0-0x00000001802226D0
			public void ShowUnlockFx(int inIndex); // 0x00000001802226D0-0x0000000180222700
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass62_0 // TypeDefIndex: 16141
		{
			// Fields
			public LockPickingRingController ring; // 0x10
	
			// Constructors
			public <>c__DisplayClass62_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <QuickGameUpdate>b__2(); // 0x0000000181400F20-0x0000000181400F40
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CompleteLevel>d__66 : IEnumerator<object> // TypeDefIndex: 16142
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingController <>4__this; // 0x20
			private int <nextLevelIndex>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <CompleteLevel>d__66(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FA360-0x00000001813FA910
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FA910-0x00000001813FA960
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass67_0 // TypeDefIndex: 16143
		{
			// Fields
			public bool showingLosePopup; // 0x10
			public LockPickingController <>4__this; // 0x18
	
			// Constructors
			public <>c__DisplayClass67_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <CompleteGame>b__0(); // 0x0000000181400F40-0x0000000181400F70
			internal bool <CompleteGame>b__1(); // 0x0000000180375540-0x0000000180375550
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CompleteGame>d__67 : IEnumerator<object> // TypeDefIndex: 16144
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingController <>4__this; // 0x20
			private <>c__DisplayClass67_0 <>8__1; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <CompleteGame>d__67(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813F9FC0-0x00000001813FA310
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FA310-0x00000001813FA360
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__68 : IEnumerator<object> // TypeDefIndex: 16145
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__68(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181400290-0x00000001814004A0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001814004A0-0x00000001814004F0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AnimateLocksFading>d__69 : IEnumerator<object> // TypeDefIndex: 16146
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AnimateLocksFading>d__69(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813F9610-0x00000001813F9B20
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813F9B20-0x00000001813F9B70
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AnimateCenterFading>d__74 : IEnumerator<object> // TypeDefIndex: 16147
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AnimateCenterFading>d__74(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813F9000-0x00000001813F9140
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813F9140-0x00000001813F9190
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AnimateBoardPan>d__79 : IEnumerator<object> // TypeDefIndex: 16148
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LockPickingController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AnimateBoardPan>d__79(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813F8C00-0x00000001813F8D80
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813F8D80-0x00000001813F8DD0
		}
	
		// Constructors
		public LockPickingController(); // 0x00000001813F1180-0x00000001813F11F0
	
		// Methods
		public override void MStart(); // 0x00000001813EFC40-0x00000001813F0100
		public override void MOnDestroy(); // 0x00000001813EFA00-0x00000001813EFC40
		private void OnBackButton(); // 0x00000001813EEA70-0x00000001813EEB10
		private void Initialize(); // 0x00000001813EF9D0-0x00000001813EFA00
		private void InitializeFromSettings(QGEChestSettings inSettings); // 0x00000001813EEC70-0x00000001813EED90
		private void InitializeLevelHolders(); // 0x00000001813EED90-0x00000001813EEF80
		private void InitializeLevel(LockPickingChestType inChestType); // 0x00000001813EEF80-0x00000001813EF800
		private void InitializePick(); // 0x00000001813EF800-0x00000001813EF9D0
		private void DestroyOldLevel(); // 0x00000001813EEBD0-0x00000001813EEC70
		public override void QuickGameUpdate(); // 0x00000001813F0500-0x00000001813F0A70
		public void PassedRing(LockPickingRingController ringController); // 0x00000001813F0270-0x00000001813F03B0
		public int PickHitRing(); // 0x00000001813F03B0-0x00000001813F0500
		public void UsePick(); // 0x00000001813F0FD0-0x00000001813F1180
		[IteratorStateMachine] // 0x0000000180127210-0x0000000180127260
		private IEnumerator CompleteLevel(); // 0x00000001813EEB70-0x00000001813EEBD0
		[IteratorStateMachine] // 0x0000000180127510-0x0000000180127560
		private IEnumerator CompleteGame(); // 0x00000001813EEB10-0x00000001813EEB70
		[IteratorStateMachine] // 0x0000000180127760-0x00000001801277B0
		public override IEnumerator ShowResults(); // 0x00000001813F0D50-0x00000001813F0DB0
		[IteratorStateMachine] // 0x00000001801279A0-0x00000001801279F0
		private IEnumerator AnimateLocksFading(); // 0x00000001813EEA10-0x00000001813EEA70
		[IteratorStateMachine] // 0x0000000180127C40-0x0000000180127C90
		private IEnumerator AnimateCenterFading(); // 0x00000001813EE9B0-0x00000001813EEA10
		[IteratorStateMachine] // 0x0000000180127ED0-0x0000000180127F20
		private IEnumerator AnimateBoardPan(); // 0x00000001813EE950-0x00000001813EE9B0
		public void SetPickCountText(int inCount, bool doFx = true /* Metadata: 0x0078542A */); // 0x00000001813F0A70-0x00000001813F0D50
		public void BtnClicked_Close(); // 0x00000001813EEA70-0x00000001813EEB10
		private void OnWindowOpened(WindowOpenedMessage inMessage); // 0x00000001813F01D0-0x00000001813F0270
		private void OnWindowClosed(WindowClosedMessage inMessage); // 0x00000001813F0100-0x00000001813F01D0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <MStart>b__53_0(); // 0x00000001813F0DE0-0x00000001813F0F00
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <InitializeFromSettings>b__57_0(); // 0x00000001813F0DD0-0x00000001813F0DE0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <QuickGameUpdate>b__62_0(); // 0x00000001813F0F00-0x00000001813F0F30
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <QuickGameUpdate>b__62_1(); // 0x00000001813F0F30-0x00000001813F0F70
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181395900-0x0000000181395910
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <SetPickCountText>b__80_0(); // 0x00000001813F0F70-0x00000001813F0FA0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <SetPickCountText>b__80_1(string text); // 0x00000001813F0FA0-0x00000001813F0FD0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <BtnClicked_Close>b__81_0(bool answer); // 0x00000001813F0DB0-0x00000001813F0DD0
	}
}
