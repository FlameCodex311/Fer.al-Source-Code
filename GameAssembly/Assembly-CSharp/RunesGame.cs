/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class RunesGame : CasualGame<RunesGame> // TypeDefIndex: 10823
{
	// Fields
	[RootSelectorCompact] // 0x00000001801D1BA0-0x00000001801D1C00
	public string levelDefId; // 0x30
	public RunesGameBoard gameBoard; // 0x38
	public RunesUI ui; // 0x40
	[Header] // 0x00000001801D1DA0-0x00000001801D1DD0
	public CachedUserVar highScoreUserVar; // 0x48
	public CachedUserVar tutorialSeenUserVar; // 0x50
	[Header] // 0x00000001801D1FE0-0x00000001801D2010
	public bool debugForceTutorial; // 0x58
	private MinigameRewardDefComponent _rewardDefComponent; // 0x60
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RunesDataDefComponent <gameData>k__BackingField; // 0x68
	public List<RunesReward> _runeTypeRewards; // 0x70
	private const string kShownTutorialKey = "WhatTheHex_ShownTutorial"; // Metadata: 0x0077C1D7

	// Properties
	public RunesDataDefComponent gameData { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803765E0-0x00000001803765F0 0x00000001804ADAC0-0x00000001804ADAD0
	public bool HasShownTutorial { get; set; } // 0x000000018073A6B0-0x000000018073A6E0 0x000000018073A6E0-0x000000018073A710

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10824
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__16_0; // 0x08

		// Constructors
		static <>c(); // 0x000000018074A7C0-0x000000018074A820
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Start>b__16_0(); // 0x00000001807497C0-0x00000001807498C0
	}

	// Constructors
	public RunesGame(); // 0x000000018073A650-0x000000018073A6B0

	// Methods
	private void Start(); // 0x000000018073A260-0x000000018073A4B0
	protected override void OnDestroy(); // 0x00000001807394A0-0x0000000180739580
	private void OnMinigamePrizeGiven(MinigamePrizeGiven msg); // 0x00000001807397F0-0x0000000180739A20
	private void OnMinigamePrizeSelected(MinigamePrizeSelected msg); // 0x0000000180739A20-0x0000000180739AA0
	private void SetupGameData(); // 0x0000000180739E30-0x0000000180739EF0
	public void PlayGame(bool tutorialOn); // 0x0000000180739CC0-0x0000000180739DA0
	private void StartGame(); // 0x0000000180739EF0-0x000000018073A260
	public void ExitGame(); // 0x00000001804D9E70-0x00000001804D9E80
	public void OnGameOver(); // 0x0000000180739580-0x0000000180739740
	public void OnScoreUpdated(int inScore); // 0x0000000180739C10-0x0000000180739CC0
	public void OnHighScoreUpdated(long inHighScore); // 0x0000000180739740-0x00000001807397F0
	public void OnRuneLevelProgressUpdated(RuneType inRuneType, int inProgress, int inDeltaProgress, int inLevelThreshold, int inLevelIndex); // 0x0000000180739AA0-0x0000000180739B40
	public void OnRuneLevelUp(RuneType inRuneType, int inLevel); // 0x0000000180739B40-0x0000000180739C10
	public void GetNextPrizeForRuneType(RuneType inRuneType, int inLevel); // 0x0000000180739320-0x0000000180739380
	public void RedeemPrizeForRuneType(RuneType inRuneType, int inLevel); // 0x0000000180739DA0-0x0000000180739E10
	private int LevelToRewardIndex(RuneType inRuneType, int inLevel); // 0x00000001807393A0-0x00000001807394A0
	private int RuneTypeToIndex(RuneType inRuneType); // 0x0000000180739E10-0x0000000180739E30
	private RuneType IndexToRuneType(int inIndex); // 0x0000000180739380-0x00000001807393A0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__16_1(); // 0x000000018073A4D0-0x000000018073A650
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <PlayGame>b__21_0(); // 0x000000018073A4B0-0x000000018073A4C0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <PlayGame>b__21_1(); // 0x000000018073A4C0-0x000000018073A4D0
}

