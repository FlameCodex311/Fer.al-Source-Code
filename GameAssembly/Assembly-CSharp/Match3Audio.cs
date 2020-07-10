/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Match3Audio : MonoBehaviour // TypeDefIndex: 12949
{
	// Fields
	private static Match3Audio _instance; // 0x00
	[Header] // 0x0000000180153750-0x0000000180153780
	public FeralAudioInfo gameMusic; // 0x20
	public FeralAudioInfo splashMusic; // 0x28
	[Header] // 0x0000000180126FD0-0x0000000180127000
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
	[Header] // 0x00000001801399F0-0x0000000180139A20
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
	public static GameObject AudioGO { get; } // 0x00000001816BEFD0-0x00000001816BF060 

	// Constructors
	public Match3Audio(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Awake(); // 0x00000001816BD620-0x00000001816BD660
	public static void PlayGameMusic(); // 0x00000001816BDD40-0x00000001816BDDF0
	public static void StopGameMusic(); // 0x00000001816BED10-0x00000001816BEDC0
	public static void PlaySplashMusic(); // 0x00000001816BE8F0-0x00000001816BE9A0
	public static void StopSplashMusic(); // 0x00000001816BEF20-0x00000001816BEFD0
	public static void PlayPopupOpen(); // 0x00000001816BE210-0x00000001816BE2C0
	public static void PlayContinueButton(); // 0x00000001816BD9D0-0x00000001816BDA80
	public static void PlayLevelScoreMeterFill(); // 0x00000001816BE000-0x00000001816BE0B0
	public static void StopLevelScoreMeterFill(); // 0x00000001816BEDC0-0x00000001816BEE70
	public static void PlayPowerUpMeterFill(); // 0x00000001816BE370-0x00000001816BE420
	public static void StopPowerUpMeterFill(); // 0x00000001816BEE70-0x00000001816BEF20
	public static void PlayPuzzleGalleryButton(); // 0x00000001816BE580-0x00000001816BE630
	public static void PlayPuzzleBackButton(); // 0x00000001816BE420-0x00000001816BE4D0
	public static void PlaySelectPuzzlePiece(); // 0x00000001816BE630-0x00000001816BE6E0
	public static void PlayPlacedPuzzlePiece(); // 0x00000001816BE160-0x00000001816BE210
	public static void PlayPuzzleComplete(); // 0x00000001816BE4D0-0x00000001816BE580
	public static void PlaySelectPuzzlePortrait(); // 0x00000001816BE6E0-0x00000001816BE790
	public static void PlayLevelObjectivesShown(); // 0x00000001816BDF50-0x00000001816BE000
	public static void PlayStandardBirdRemoval(); // 0x00000001816BE9A0-0x00000001816BEA50
	public static void PlayMatchMade(); // 0x00000001816BE0B0-0x00000001816BE160
	public static void PlayBoosterActivated(BoosterType inType); // 0x00000001816BD660-0x00000001816BD7C0
	public static void PlayTileDropped(); // 0x00000001816BEC60-0x00000001816BED10
	public static void PlaySwapStarted(); // 0x00000001816BEB00-0x00000001816BEBB0
	public static void PlaySwapping(); // 0x00000001816BEBB0-0x00000001816BEC60
	public static void PlaySwapBack(); // 0x00000001816BEA50-0x00000001816BEB00
	public static void PlayPowerUpHatched(); // 0x00000001816BE2C0-0x00000001816BE370
	public static void PlayGameOver(); // 0x00000001816BDDF0-0x00000001816BDEA0
	public static void PlayLevelCompleted(); // 0x00000001816BDEA0-0x00000001816BDF50
	public static void PlayBoosterAdded(); // 0x00000001816BD7C0-0x00000001816BD870
	public static void PlayBoosterCombined(); // 0x00000001816BD870-0x00000001816BD920
	public static void PlayDizzyPowerupUsed(); // 0x00000001816BDA80-0x00000001816BDB30
	public static void PlayEggCracked(); // 0x00000001816BDBE0-0x00000001816BDC90
	public static void PlayEggSpawn(); // 0x00000001816BDC90-0x00000001816BDD40
	public static void PlaySpecialItemSpawn(); // 0x00000001816BE840-0x00000001816BE8F0
	public static void PlaySpecialItemRemoved(); // 0x00000001816BE790-0x00000001816BE840
	public static void PlayClearedByPeacock(); // 0x00000001816BD920-0x00000001816BD9D0
	public static void PlayDoublePeacock(); // 0x00000001816BDB30-0x00000001816BDBE0
}

