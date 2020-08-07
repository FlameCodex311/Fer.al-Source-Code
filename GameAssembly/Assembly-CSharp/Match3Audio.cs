/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class Match3Audio : MonoBehaviour // TypeDefIndex: 10614
{
	// Fields
	private static Match3Audio _instance; // 0x00
	[Header] // 0x0000000180231E80-0x0000000180231EB0
	public FeralAudioInfo gameMusic; // 0x20
	public FeralAudioInfo splashMusic; // 0x28
	[Header] // 0x00000001802136B0-0x00000001802136E0
	public FeralAudioInfo popupOpen; // 0x30
	public FeralAudioInfo continueButton; // 0x38
	public FeralAudioInfo levelScoreMeterFill; // 0x40
	public FeralAudioInfo powerUpMeterFill; // 0x48
	public FeralAudioInfo puzzleGalleryButton; // 0x50
	public FeralAudioInfo backButton; // 0x58
	public FeralAudioInfo selectPuzzlePiece; // 0x60
	public FeralAudioInfo placedPuzzlePiece; // 0x68
	public FeralAudioInfo puzzleComplete; // 0x70
	public FeralAudioInfo selectPuzzlePortrait; // 0x78
	public FeralAudioInfo levelObjectivesShown; // 0x80
	[Header] // 0x00000001802138E0-0x0000000180213910
	public FeralAudioInfo standardBirdRemoval; // 0x88
	public FeralAudioInfo matchMade; // 0x90
	public FeralAudioInfo boosterActivated_Flyer; // 0x98
	public FeralAudioInfo boosterActivated_TwinTrouble; // 0xA0
	public FeralAudioInfo boosterActivated_Peacock; // 0xA8
	public FeralAudioInfo tileDrop; // 0xB0
	public FeralAudioInfo swapStarted; // 0xB8
	public FeralAudioInfo swapping; // 0xC0
	public FeralAudioInfo swapBack; // 0xC8
	public FeralAudioInfo powerUpHatched; // 0xD0
	public FeralAudioInfo gameOver; // 0xD8
	public FeralAudioInfo levelComplete; // 0xE0
	public FeralAudioInfo boosterAdded; // 0xE8
	public FeralAudioInfo boosterCombined; // 0xF0
	public FeralAudioInfo dizzyPowerupUsed; // 0xF8
	public FeralAudioInfo eggCracked; // 0x100
	public FeralAudioInfo eggSpawn; // 0x108
	public FeralAudioInfo specialItemSpawn; // 0x110
	public FeralAudioInfo specialItemRemoved; // 0x118
	public FeralAudioInfo clearedByPeacock; // 0x120
	public FeralAudioInfo doublePeacock; // 0x128

	// Properties
	public static GameObject AudioGO { get; } // 0x00000001804F8800-0x00000001804F8890 

	// Constructors
	public Match3Audio(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Awake(); // 0x00000001804F6E60-0x00000001804F6EA0
	public static void PlayGameMusic(); // 0x00000001804F7570-0x00000001804F7620
	public static void StopGameMusic(); // 0x00000001804F8540-0x00000001804F85F0
	public static void PlaySplashMusic(); // 0x00000001804F8120-0x00000001804F81D0
	public static void StopSplashMusic(); // 0x00000001804F8750-0x00000001804F8800
	public static void PlayPopupOpen(); // 0x00000001804F7A40-0x00000001804F7AF0
	public static void PlayContinueButton(); // 0x00000001804F7200-0x00000001804F72B0
	public static void PlayLevelScoreMeterFill(); // 0x00000001804F7830-0x00000001804F78E0
	public static void StopLevelScoreMeterFill(); // 0x00000001804F85F0-0x00000001804F86A0
	public static void PlayPowerUpMeterFill(); // 0x00000001804F7BA0-0x00000001804F7C50
	public static void StopPowerUpMeterFill(); // 0x00000001804F86A0-0x00000001804F8750
	public static void PlayPuzzleGalleryButton(); // 0x00000001804F7DB0-0x00000001804F7E60
	public static void PlayPuzzleBackButton(); // 0x00000001804F7C50-0x00000001804F7D00
	public static void PlaySelectPuzzlePiece(); // 0x00000001804F7E60-0x00000001804F7F10
	public static void PlayPlacedPuzzlePiece(); // 0x00000001804F7990-0x00000001804F7A40
	public static void PlayPuzzleComplete(); // 0x00000001804F7D00-0x00000001804F7DB0
	public static void PlaySelectPuzzlePortrait(); // 0x00000001804F7F10-0x00000001804F7FC0
	public static void PlayLevelObjectivesShown(); // 0x00000001804F7780-0x00000001804F7830
	public static void PlayStandardBirdRemoval(); // 0x00000001804F81D0-0x00000001804F8280
	public static void PlayMatchMade(); // 0x00000001804F78E0-0x00000001804F7990
	public static void PlayBoosterActivated(BoosterType inType); // 0x00000001804F6EA0-0x00000001804F6FF0
	public static void PlayTileDropped(); // 0x00000001804F8490-0x00000001804F8540
	public static void PlaySwapStarted(); // 0x00000001804F8330-0x00000001804F83E0
	public static void PlaySwapping(); // 0x00000001804F83E0-0x00000001804F8490
	public static void PlaySwapBack(); // 0x00000001804F8280-0x00000001804F8330
	public static void PlayPowerUpHatched(); // 0x00000001804F7AF0-0x00000001804F7BA0
	public static void PlayGameOver(); // 0x00000001804F7620-0x00000001804F76D0
	public static void PlayLevelCompleted(); // 0x00000001804F76D0-0x00000001804F7780
	public static void PlayBoosterAdded(); // 0x00000001804F6FF0-0x00000001804F70A0
	public static void PlayBoosterCombined(); // 0x00000001804F70A0-0x00000001804F7150
	public static void PlayDizzyPowerupUsed(); // 0x00000001804F72B0-0x00000001804F7360
	public static void PlayEggCracked(); // 0x00000001804F7410-0x00000001804F74C0
	public static void PlayEggSpawn(); // 0x00000001804F74C0-0x00000001804F7570
	public static void PlaySpecialItemSpawn(); // 0x00000001804F8070-0x00000001804F8120
	public static void PlaySpecialItemRemoved(); // 0x00000001804F7FC0-0x00000001804F8070
	public static void PlayClearedByPeacock(); // 0x00000001804F7150-0x00000001804F7200
	public static void PlayDoublePeacock(); // 0x00000001804F7360-0x00000001804F7410
}

