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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CodeBreakerGame : CasualGame<CodeBreakerGame> // TypeDefIndex: 12869
{
	// Fields
	[RootSelectorCompact] // 0x00000001800FF260-0x00000001800FF2C0
	public string levelDefId; // 0x28
	public CodeBreakerLevelGenerator levelGenerator; // 0x30
	public CodeBreakerUI ui; // 0x38
	public BeetleController beetleController; // 0x40
	public IngredientWheel ingredientWheel; // 0x48
	public GameObject mixNoneCorrectFx; // 0x50
	public GameObject mixSomeIncorrectPositionFx; // 0x58
	public GameObject mixSomeCorrectPositionFx; // 0x60
	public GameObject mixAllCorrectFx; // 0x68
	public ObscuredInt currentLevel; // 0x70
	[Header] // 0x0000000180139D20-0x0000000180139D50
	public CachedUserVar tutorialUserVar; // 0x88
	public CachedUserVar levelsUnlockedUserVar; // 0x90
	public CachedUserVar levelScoresUserVar; // 0x98
	private float _levelTimer; // 0xA0
	private Dictionary<int, bool> _seenMissMargueriteDialogs; // 0xA8
	private int _spawnerReadyCount; // 0xB0
	private int _pausedCount; // 0xB4
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Code <SecretCode>k__BackingField; // 0xB8
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private int <TryCount>k__BackingField; // 0xC0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <LevelRunning>k__BackingField; // 0xC4
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <PlayerUsedDuplicates>k__BackingField; // 0xC5
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private CodeBreakerDefComponent <gameData>k__BackingField; // 0xC8
	[Header] // 0x00000001800FF680-0x00000001800FF6B0
	public bool debugClearProgressOnStart; // 0xD0
	public int debugGoToLevelIndex; // 0xD4
	public bool debugShowForcedTutorial; // 0xD8

	// Properties
	public new bool Paused { get; } // 0x0000000181270520-0x0000000181270530 
	public bool HasSeenTutorial { get; set; } // 0x0000000181270D30-0x0000000181270D60 0x0000000181270E20-0x0000000181270E50
	public long UnlockedLevelCount { get; set; } // 0x0000000181270DF0-0x0000000181270E20 0x0000000181270E70-0x0000000181270EA0
	public Code SecretCode { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001803ED9C0-0x00000001803ED9D0 0x00000001803D8F00-0x00000001803D8F10
	public int TryCount { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804288C0-0x00000001804288D0 0x00000001804EA430-0x00000001804EA440
	public bool LevelRunning { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181270D60-0x0000000181270D70 0x0000000181270E50-0x0000000181270E60
	public bool PlayerUsedDuplicates { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181270DE0-0x0000000181270DF0 0x0000000181270E60-0x0000000181270E70
	public int LevelTimer { get; } // 0x0000000181270D70-0x0000000181270DE0 
	public CodeBreakerDefComponent gameData { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804A2590-0x00000001804A25A0 0x00000001804A22E0-0x00000001804A22F0

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12870
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__47_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000181282010-0x0000000181282070
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Start>b__47_0(); // 0x0000000181281AE0-0x0000000181281B70
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <ShowAttemptFX>d__58 : IEnumerator<object> // TypeDefIndex: 12871
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GameObject inAttemptFx; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <ShowAttemptFX>d__58(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181281050-0x0000000181281130
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181281130-0x0000000181281180
	}

	// Constructors
	public CodeBreakerGame(); // 0x0000000181270C80-0x0000000181270D30

	// Methods
	private void Start(); // 0x00000001812702B0-0x00000001812703E0
	protected override void OnWindowOpened(WindowOpenedMessage inMessage); // 0x000000018126FF60-0x00000001812700A0
	protected override void OnWindowClosed(WindowClosedMessage inMessage); // 0x000000018126FE20-0x000000018126FF60
	private void Update(); // 0x0000000181270B00-0x0000000181270C80
	protected override void OnDestroy(); // 0x000000018126F230-0x000000018126F390
	public void StartGame(); // 0x0000000181270180-0x00000001812702B0
	private bool ShouldShowTutorial(); // 0x00000001812700F0-0x0000000181270120
	public void ExitGame(); // 0x000000018116CFB0-0x000000018116CFC0
	private void OnGamePaused(CodeBreakerGamePausedMessage inMessage); // 0x000000018126F390-0x000000018126F430
	private void OnSpawnerReady(SpawnerReadyMessage inMessage); // 0x000000018126F450-0x000000018126F460
	private void OnTryCode(TryCodeMessage inMessage); // 0x000000018126F460-0x000000018126FE20
	[IteratorStateMachine] // 0x000000018013B000-0x000000018013B050
	private IEnumerator ShowAttemptFX(GameObject inAttemptFx); // 0x0000000181270120-0x0000000181270180
	private void HandleWin(); // 0x000000018126EEF0-0x000000018126F230
	private void HandleLose(); // 0x000000018126ED30-0x000000018126EEF0
	private void OnLevelStarted(CodeBreakerLevelStartMessage inMessage); // 0x000000018126F430-0x000000018126F450
	public void GoToNextLevel(); // 0x000000018126E840-0x000000018126E880
	public void GoToPrevLevel(); // 0x000000018126E880-0x000000018126E900
	public void ReplayLevel(); // 0x00000001812700A0-0x00000001812700E0
	public void RestartGame(); // 0x00000001812700E0-0x00000001812700F0
	public void GoToTutorialLevel(); // 0x000000018126E900-0x000000018126ED30
	public void GoToLevel(int inLevelIndex); // 0x000000018126E290-0x000000018126E840
	public void GoToLevelSelect(); // 0x000000018126E1E0-0x000000018126E290
	public void ClearLevel(); // 0x000000018126E180-0x000000018126E1D0
	public void TutorialFinished(); // 0x00000001812703E0-0x0000000181270490
	[DeMethodButton] // 0x000000018013C430-0x000000018013C490
	private void DebugClearProgress(); // 0x00000001803581E0-0x00000001803581F0
	[DeMethodButton] // 0x000000018013C690-0x000000018013C6F0
	private void DebugUnlockAllLevels(); // 0x00000001803581E0-0x00000001803581F0
	[DeMethodButton] // 0x000000018013C8E0-0x000000018013C940
	private void DebugGoToLevel(); // 0x000000018126E1D0-0x000000018126E1E0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__47_1(); // 0x0000000181270970-0x0000000181270B00
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnTryCode>b__57_0(); // 0x0000000181270880-0x0000000181270920
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <OnTryCode>b__57_1(); // 0x00000001812705D0-0x00000001812705E0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnTryCode>b__57_2(); // 0x0000000181270920-0x0000000181270970
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <HandleWin>b__59_0(); // 0x0000000181270520-0x0000000181270530
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <HandleWin>b__59_1(); // 0x00000001812706B0-0x0000000181270750
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <HandleWin>b__59_2(); // 0x00000001812705D0-0x00000001812705E0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <HandleWin>b__59_3(); // 0x0000000181270750-0x0000000181270880
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <HandleLose>b__60_0(); // 0x0000000181270520-0x0000000181270530
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <HandleLose>b__60_1(); // 0x0000000181270530-0x00000001812705D0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <HandleLose>b__60_2(); // 0x00000001812705D0-0x00000001812705E0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <HandleLose>b__60_3(); // 0x00000001812705E0-0x00000001812706B0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <GoToLevel>b__67_0(); // 0x0000000181270490-0x00000001812704C0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <GoToLevel>b__67_1(); // 0x00000001812704C0-0x0000000181270520
}

