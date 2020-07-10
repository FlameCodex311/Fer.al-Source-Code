/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class RunesGame : CasualGame<RunesGame> // TypeDefIndex: 13158
{
	// Fields
	[RootSelectorCompact] // 0x00000001800FF260-0x00000001800FF2C0
	public string levelDefId; // 0x28
	public RunesGameBoard gameBoard; // 0x30
	public RunesUI ui; // 0x38
	[Header] // 0x00000001800FF4E0-0x00000001800FF510
	public CachedUserVar highScoreUserVar; // 0x40
	public CachedUserVar tutorialSeenUserVar; // 0x48
	[Header] // 0x00000001800FF680-0x00000001800FF6B0
	public bool debugForceTutorial; // 0x50
	private MinigameRewardDefComponent _rewardDefComponent; // 0x58
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private RunesDataDefComponent <gameData>k__BackingField; // 0x60
	public List<RunesReward> _runeTypeRewards; // 0x68
	private const string kShownTutorialKey = "WhatTheHex_ShownTutorial"; // Metadata: 0x0078371C

	// Properties
	public RunesDataDefComponent gameData { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B40-0x0000000180369B50 0x00000001803A27E0-0x00000001803A27F0
	public bool HasShownTutorial { get; set; } // 0x0000000180FDE9F0-0x0000000180FDEA20 0x0000000180FDEA20-0x0000000180FDEA50

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 13159
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__16_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180FE4360-0x0000000180FE47B0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Start>b__16_0(); // 0x0000000180FE3E80-0x0000000180FE3F80
	}

	// Constructors
	public RunesGame(); // 0x0000000180FDE990-0x0000000180FDE9F0

	// Methods
	private void Start(); // 0x0000000180FDE6B0-0x0000000180FDE800
	protected override void OnDestroy(); // 0x0000000180FDDB60-0x0000000180FDDC40
	private void OnMinigamePrizeGiven(MinigamePrizeGiven msg); // 0x0000000180FDDE20-0x0000000180FDE060
	private void OnMinigamePrizeSelected(MinigamePrizeSelected msg); // 0x0000000180FDE060-0x0000000180FDE0C0
	private void SetupGameData(); // 0x0000000180FDE350-0x0000000180FDE410
	public void PlayGame(bool tutorialOn); // 0x0000000180FDE1E0-0x0000000180FDE2C0
	private void StartGame(); // 0x0000000180FDE410-0x0000000180FDE6B0
	public void ExitGame(); // 0x0000000180FCE640-0x0000000180FCE690
	public void OnGameOver(); // 0x0000000180FDDC40-0x0000000180FDDE00
	public void OnScoreUpdated(int inScore); // 0x0000000180FDE1C0-0x0000000180FDE1E0
	public void OnHighScoreUpdated(long inHighScore); // 0x0000000180FDDE00-0x0000000180FDDE20
	public void OnRuneLevelProgressUpdated(RuneType inRuneType, int inProgress, int inDeltaProgress, int inLevelThreshold, int inLevelIndex); // 0x0000000180FDE0C0-0x0000000180FDE0F0
	public void OnRuneLevelUp(RuneType inRuneType, int inLevel); // 0x0000000180FDE0F0-0x0000000180FDE1C0
	public void GetNextPrizeForRuneType(RuneType inRuneType, int inLevel); // 0x0000000180FDD9E0-0x0000000180FDDA40
	public void RedeemPrizeForRuneType(RuneType inRuneType, int inLevel); // 0x0000000180FDE2C0-0x0000000180FDE330
	private int LevelToRewardIndex(RuneType inRuneType, int inLevel); // 0x0000000180FDDA60-0x0000000180FDDB60
	private int RuneTypeToIndex(RuneType inRuneType); // 0x0000000180FDE330-0x0000000180FDE350
	private RuneType IndexToRuneType(int inIndex); // 0x0000000180FDDA40-0x0000000180FDDA60
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__16_1(); // 0x0000000180FDE810-0x0000000180FDE990
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <PlayGame>b__21_0(); // 0x000000018075F790-0x000000018075F7A0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <PlayGame>b__21_1(); // 0x0000000180FDE800-0x0000000180FDE810
}

