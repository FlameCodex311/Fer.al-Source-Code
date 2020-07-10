/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class RunesAudio : MonoBehaviour // TypeDefIndex: 13157
{
	// Fields
	private static RunesAudio _instance; // 0x00
	public FeralAudioInfo gameMusic; // 0x20
	public FeralAudioInfo splashMusic; // 0x28
	public FeralAudioInfo gameOverStinger; // 0x30
	[Space] // 0x00000001800FEB30-0x00000001800FEB50
	public FeralAudioInfo uiPopupStinger; // 0x38
	public FeralAudioInfo uiButtonOK; // 0x40
	public FeralAudioInfo uiButtonStart; // 0x48
	public FeralAudioInfo uiButtonExit; // 0x50
	public FeralAudioInfo uiButtonNext; // 0x58
	public FeralAudioInfo uiRewardRecieved; // 0x60
	public FeralAudioInfo uiForcedTutorialPopup; // 0x68
	public FeralAudioInfo uiForcedTutorialContinue; // 0x70
	[Space] // 0x00000001800FEB30-0x00000001800FEB50
	public FeralAudioInfo bombAvailable; // 0x78
	public FeralAudioInfo bombPickedUp; // 0x80
	public FeralAudioInfo bombPlaced; // 0x88
	[Space] // 0x00000001800FEB30-0x00000001800FEB50
	public FeralAudioInfo runeGroupSpawned; // 0x90
	public FeralAudioInfo runeGroupPickedUp; // 0x98
	public FeralAudioInfo runeGroupSinglePlaced; // 0xA0
	public FeralAudioInfo runeGroupDoublePlaced; // 0xA8
	public FeralAudioInfo runeGroupTriplePlaced; // 0xB0
	public FeralAudioInfo runeGroupReturnToSpawn; // 0xB8
	public FeralAudioInfo runeGroupRotateTiles; // 0xC0
	public FeralAudioInfo runeGroupWiggle; // 0xC8
	public FeralAudioInfo runeGroupDespawned; // 0xD0
	[Space] // 0x00000001800FEB30-0x00000001800FEB50
	public FeralAudioInfo pointsComboMultiplier; // 0xD8
	public FeralAudioInfo runeIconMove; // 0xE0
	public FeralAudioInfo runeIconRestore; // 0xE8
	[Space] // 0x00000001800FEB30-0x00000001800FEB50
	public FeralAudioInfo cycloneSpawned; // 0xF0
	public FeralAudioInfo cyclonePickedUp; // 0xF8
	public FeralAudioInfo cyclonePlaced; // 0x100
	public FeralAudioInfo cycloneCollectionFinished; // 0x108
	public FeralAudioInfo cycloneLiftedUpTile; // 0x110
	public FeralAudioInfo cycloneCollectedTile; // 0x118
	[Space] // 0x00000001800FEB30-0x00000001800FEB50
	public FeralAudioInfo meterFilledFlame; // 0x120
	public FeralAudioInfo meterFilledFlora; // 0x128
	public FeralAudioInfo meterFilledMiasma; // 0x130
	public FeralAudioInfo powerupMeterFillingLoop; // 0x138

	// Properties
	public static GameObject AudioGO { get; } // 0x0000000180FD5140-0x0000000180FD51D0 

	// Constructors
	public RunesAudio(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Awake(); // 0x0000000180FD3630-0x0000000180FD3670
	public static void PlayGameMusic(); // 0x0000000180FD3CA0-0x0000000180FD3D50
	public static void StopGameMusic(); // 0x0000000180FD4F30-0x0000000180FD4FE0
	public static void PlaySplashMusic(); // 0x0000000180FD4900-0x0000000180FD49B0
	public static void StopSplashMusic(); // 0x0000000180FD5090-0x0000000180FD5140
	public static void PlayGameOverStinger(); // 0x0000000180FD3D50-0x0000000180FD3E00
	public static void PlayUiPopupStinger(); // 0x0000000180FD4DD0-0x0000000180FD4E80
	public static void PlayUiButtonOK(); // 0x0000000180FD4C70-0x0000000180FD4D20
	public static void PlayUiButtonStart(); // 0x0000000180FD4D20-0x0000000180FD4DD0
	public static void PlayUiButtonExit(); // 0x0000000180FD4B10-0x0000000180FD4BC0
	public static void PlayUiButtonNext(); // 0x0000000180FD4BC0-0x0000000180FD4C70
	public static void PlayUIForcedTutorialPopup(); // 0x0000000180FD4A60-0x0000000180FD4B10
	public static void PlayUIForcedTutorialContinue(); // 0x0000000180FD49B0-0x0000000180FD4A60
	public static void PlayBombAvailable(); // 0x0000000180FD3670-0x0000000180FD3720
	public static void PlayBombPickedUp(); // 0x0000000180FD3720-0x0000000180FD37D0
	public static void PlayBombPlaced(); // 0x0000000180FD37D0-0x0000000180FD3880
	public static void PlayRuneGroupSpawned(); // 0x0000000180FD4590-0x0000000180FD4640
	public static void PlayRuneGroupPickedUp(); // 0x0000000180FD42D0-0x0000000180FD4380
	public static void PlayRuneGroupSinglePlaced(); // 0x0000000180FD44E0-0x0000000180FD4590
	public static void PlayRuneGroupDoublePlaced(); // 0x0000000180FD4220-0x0000000180FD42D0
	public static void PlayRuneGroupTriplePlaced(); // 0x0000000180FD4640-0x0000000180FD46F0
	public static void PlayRuneGroupReturnToSpawn(); // 0x0000000180FD4380-0x0000000180FD4430
	public static void PlayRuneGroupRotateTiles(); // 0x0000000180FD4430-0x0000000180FD44E0
	public static void PlayRuneGroupWiggle(); // 0x0000000180FD46F0-0x0000000180FD47A0
	public static void PlayRuneGroupDespawned(); // 0x0000000180FD4170-0x0000000180FD4220
	public static void PlayCycloneSpawned(); // 0x0000000180FD3BF0-0x0000000180FD3CA0
	public static void PlayCyclonePickedUp(); // 0x0000000180FD3A90-0x0000000180FD3B40
	public static void PlayCyclonePlaced(); // 0x0000000180FD3B40-0x0000000180FD3BF0
	public static void PlayCycloneFinished(); // 0x0000000180FD3930-0x0000000180FD39E0
	public static void PlayCycloneLiftedUpTile(); // 0x0000000180FD39E0-0x0000000180FD3A90
	public static void PlayCycloneCollectedTile(); // 0x0000000180FD3880-0x0000000180FD3930
	public static void PlayMeterFilledFlame(); // 0x0000000180FD3E00-0x0000000180FD3EB0
	public static void PlayMeterFilledFlora(); // 0x0000000180FD3EB0-0x0000000180FD3F60
	public static void PlayMeterFilledMiasma(); // 0x0000000180FD3F60-0x0000000180FD4010
	public static void PlayPowerupMeterFillingLoop(); // 0x0000000180FD40C0-0x0000000180FD4170
	public static void StopPowerupMeterFillingLoop(); // 0x0000000180FD4FE0-0x0000000180FD5090
	public static void PlayPointsComboMultiplier(); // 0x0000000180FD4010-0x0000000180FD40C0
	public static void PlayRuneIconMove(); // 0x0000000180FD47A0-0x0000000180FD4850
	public static void PlayRuneIconRestore(); // 0x0000000180FD4850-0x0000000180FD4900
	public static void PlayUiRewardReceived(); // 0x0000000180FD4E80-0x0000000180FD4F30
}

