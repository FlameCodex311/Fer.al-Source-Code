/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using DG.DeInspektor.Attributes;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CodeBreakerGame : CasualGame<CodeBreakerGame> // TypeDefIndex: 10527
{
	// Fields
	[RootSelectorCompact] // 0x00000001801D1BA0-0x00000001801D1C00
	public string levelDefId; // 0x30
	public CodeBreakerLevelGenerator levelGenerator; // 0x38
	public CodeBreakerUI ui; // 0x40
	public BeetleController beetleController; // 0x48
	public IngredientWheel ingredientWheel; // 0x50
	public GameObject mixNoneCorrectFx; // 0x58
	public GameObject mixSomeIncorrectPositionFx; // 0x60
	public GameObject mixSomeCorrectPositionFx; // 0x68
	public GameObject mixAllCorrectFx; // 0x70
	public ObscuredInt currentLevel; // 0x78
	[Header] // 0x0000000180213CE0-0x0000000180213D10
	public CachedUserVar tutorialUserVar; // 0x90
	public CachedUserVar levelsUnlockedUserVar; // 0x98
	public CachedUserVar levelScoresUserVar; // 0xA0
	private float _levelTimer; // 0xA8
	private bool _waitingForLevelStart; // 0xAC
	private Dictionary<int, bool> _seenMissMargueriteDialogs; // 0xB0
	private int _spawnerReadyCount; // 0xB8
	private int _pausedCount; // 0xBC
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Code <TutorialSecretCode>k__BackingField; // 0xC0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int <TryCount>k__BackingField; // 0xC8
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <LevelRunning>k__BackingField; // 0xCC
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <PlayerUsedDuplicates>k__BackingField; // 0xCD
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CodeBreakerDefComponent <gameData>k__BackingField; // 0xD0
	private Code _lastGuessCode; // 0xD8
	[Header] // 0x00000001801D1FE0-0x00000001801D2010
	public int debugGoToLevelIndex; // 0xE0
	public bool debugShowForcedTutorial; // 0xE4

	// Properties
	public new bool Paused { get; } // 0x0000000180529340-0x0000000180529350 
	public bool HasSeenTutorial { get; set; } // 0x0000000180529290-0x00000001805292C0 0x00000001805293B0-0x00000001805293E0
	public long UnlockedLevelCount { get; } // 0x0000000180529370-0x00000001805293A0 
	public Code TutorialSecretCode { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180529360-0x0000000180529370 0x0000000180529410-0x0000000180529420
	public int TryCount { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804E4DD0-0x00000001804E4DE0 0x0000000180529400-0x0000000180529410
	public bool LevelRunning { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001805292C0-0x00000001805292D0 0x00000001805293E0-0x00000001805293F0
	public bool PlayerUsedDuplicates { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180529350-0x0000000180529360 0x00000001805293F0-0x0000000180529400
	public int LevelTimer { get; } // 0x00000001805292D0-0x0000000180529340 
	public CodeBreakerDefComponent gameData { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001805293A0-0x00000001805293B0 0x0000000180529420-0x0000000180529430

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10528
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__47_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180538AE0-0x0000000180538B40
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Start>b__47_0(); // 0x00000001805382F0-0x0000000180538380
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <ShowAttemptFX>d__59 : IEnumerator<object> // TypeDefIndex: 10529
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GameObject inAttemptFx; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <ShowAttemptFX>d__59(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180538170-0x0000000180538250
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180538250-0x00000001805382A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass60_0 // TypeDefIndex: 10530
	{
		// Fields
		public CodeBreakerGame <>4__this; // 0x10
		public int inIngredientScore; // 0x18
		public int inTimeScore; // 0x1C
		public int inFirstGuessBonus; // 0x20
		public int inLastIngredientBonus; // 0x24
		public Func<bool> <>9__2; // 0x28
		public Action <>9__3; // 0x30

		// Constructors
		public <>c__DisplayClass60_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <HandleWin>b__0(); // 0x00000001805385E0-0x0000000180538610
		internal void <HandleWin>b__1(); // 0x0000000180538610-0x00000001805386E0
		internal bool <HandleWin>b__2(); // 0x00000001805386E0-0x0000000180538710
		internal void <HandleWin>b__3(); // 0x0000000180538710-0x00000001805388A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass61_0 // TypeDefIndex: 10531
	{
		// Fields
		public CodeBreakerGame <>4__this; // 0x10
		public Code inSecretCode; // 0x18
		public Func<bool> <>9__2; // 0x20
		public Action <>9__3; // 0x28

		// Constructors
		public <>c__DisplayClass61_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <HandleLose>b__0(); // 0x00000001805385E0-0x0000000180538610
		internal void <HandleLose>b__1(); // 0x00000001805388A0-0x0000000180538970
		internal bool <HandleLose>b__2(); // 0x00000001805386E0-0x0000000180538710
		internal void <HandleLose>b__3(); // 0x0000000180538970-0x0000000180538A80
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <WaitForLevelStart>d__78 : IEnumerator<object> // TypeDefIndex: 10532
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CodeBreakerGame <>4__this; // 0x20
		private float <timeOutTimer>5__2; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <WaitForLevelStart>d__78(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180538C00-0x0000000180538D60
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180538D60-0x0000000180538DB0
	}

	// Constructors
	public CodeBreakerGame(); // 0x00000001805291E0-0x0000000180529290

	// Methods
	private void Start(); // 0x0000000180528B00-0x0000000180528C30
	protected override void OnWindowOpened(WindowOpenedMessage inMessage); // 0x00000001805283A0-0x00000001805284E0
	protected override void OnWindowClosed(WindowClosedMessage inMessage); // 0x0000000180528260-0x00000001805283A0
	private void Update(); // 0x0000000180529000-0x0000000180529180
	protected override void OnDestroy(); // 0x0000000180527B00-0x0000000180527C60
	public void StartGame(); // 0x00000001805289D0-0x0000000180528B00
	private bool ShouldShowTutorial(); // 0x0000000180528940-0x0000000180528970
	public void ExitGame(); // 0x00000001804D9E70-0x00000001804D9E80
	private void OnGamePaused(CodeBreakerGamePausedMessage inMessage); // 0x0000000180527C60-0x0000000180527CF0
	private void OnSpawnerReady(SpawnerReadyMessage inMessage); // 0x0000000180528230-0x0000000180528240
	private void OnTryCode(TryCodeMessage inMessage); // 0x0000000180528240-0x0000000180528260
	private void OnHintRecieved(Code inGuessCode, CodeHint inGuessHints); // 0x0000000180527CF0-0x0000000180528210
	[IteratorStateMachine] // 0x00000001802159A0-0x00000001802159F0
	private IEnumerator ShowAttemptFX(GameObject inAttemptFx); // 0x0000000180528970-0x00000001805289D0
	private void HandleWin(int inIngredientScore, int inTimeScore, int inFirstGuessBonus, int inLastIngredientBonus); // 0x0000000180527330-0x0000000180527640
	private void HandleLose(Code inSecretCode); // 0x0000000180527130-0x0000000180527330
	private void OnLevelStarted(CodeBreakerLevelStartMessage inMessage); // 0x0000000180528210-0x0000000180528230
	public void GoToNextLevel(); // 0x0000000180526AE0-0x0000000180526B20
	public void GoToPrevLevel(); // 0x0000000180526B20-0x0000000180526BA0
	public void ReplayLevel(); // 0x00000001805284E0-0x0000000180528520
	public void RestartGame(); // 0x0000000180528520-0x0000000180528530
	public void GoToTutorialLevel(); // 0x0000000180526BA0-0x0000000180526FB0
	public void GoToLevel(int inLevelIndex); // 0x0000000180526960-0x0000000180526AE0
	private void InternalGoToLevel(int inLevelIndex); // 0x0000000180527640-0x0000000180527B00
	public void GoToLevelSelect(); // 0x00000001805268B0-0x0000000180526960
	public void ClearLevel(); // 0x0000000180526850-0x00000001805268A0
	public void TutorialFinished(); // 0x0000000180528C30-0x0000000180528CE0
	[CasualGameCommand] // 0x0000000180215CD0-0x0000000180215D00
	private void HandleGameCommandLevelStart(CodeBreakerGoToLevelMessage inMessage); // 0x00000001805270C0-0x00000001805270F0
	[CasualGameCommand] // 0x0000000180215F00-0x0000000180215F30
	private void HandleGameCommandHint(CodeBreakerHintMessage inMessage); // 0x0000000180526FB0-0x00000001805270A0
	[CasualGameCommand] // 0x00000001802160F0-0x0000000180216120
	private void HandleGameCommandLevelWin(CodeBreakerLevelWinMessage inMessage); // 0x00000001805270F0-0x0000000180527130
	[CasualGameCommand] // 0x00000001802162D0-0x0000000180216300
	private void HandleGameCommandLevelLose(CodeBreakerLevelLoseMessage inMessage); // 0x00000001805270A0-0x00000001805270C0
	private void SendGameCommandStartLevel(int inLevelIndex); // 0x00000001805287C0-0x0000000180528940
	[IteratorStateMachine] // 0x0000000180216450-0x00000001802164A0
	private IEnumerator WaitForLevelStart(); // 0x0000000180529180-0x00000001805291E0
	private void SendGameCommandGuess(Code inCode); // 0x0000000180528530-0x00000001805287C0
	[DeMethodButton] // 0x0000000180216650-0x00000001802166B0
	private void DebugGoToLevel(); // 0x00000001805268A0-0x00000001805268B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__47_1(); // 0x0000000180528E70-0x0000000180529000
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnHintRecieved>b__58_0(); // 0x0000000180528D70-0x0000000180528E10
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <OnHintRecieved>b__58_1(); // 0x0000000180528E10-0x0000000180528E20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnHintRecieved>b__58_2(); // 0x0000000180528E20-0x0000000180528E70
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <InternalGoToLevel>b__69_0(); // 0x0000000180528CE0-0x0000000180528D10
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <InternalGoToLevel>b__69_1(); // 0x0000000180528D10-0x0000000180528D70
}

