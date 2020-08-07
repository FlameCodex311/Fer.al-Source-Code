/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class RunesAudio : MonoBehaviour // TypeDefIndex: 10822
{
	// Fields
	private static RunesAudio _instance; // 0x00
	public FeralAudioInfo gameMusic; // 0x20
	public FeralAudioInfo splashMusic; // 0x28
	public FeralAudioInfo gameOverStinger; // 0x30
	[Space] // 0x00000001801D1250-0x00000001801D1270
	public FeralAudioInfo uiPopupStinger; // 0x38
	public FeralAudioInfo uiButtonOK; // 0x40
	public FeralAudioInfo uiButtonStart; // 0x48
	public FeralAudioInfo uiButtonExit; // 0x50
	public FeralAudioInfo uiButtonNext; // 0x58
	public FeralAudioInfo uiRewardRecieved; // 0x60
	public FeralAudioInfo uiForcedTutorialPopup; // 0x68
	public FeralAudioInfo uiForcedTutorialContinue; // 0x70
	[Space] // 0x00000001801D1250-0x00000001801D1270
	public FeralAudioInfo bombAvailable; // 0x78
	public FeralAudioInfo bombPickedUp; // 0x80
	public FeralAudioInfo bombPlaced; // 0x88
	[Space] // 0x00000001801D1250-0x00000001801D1270
	public FeralAudioInfo runeGroupSpawned; // 0x90
	public FeralAudioInfo runeGroupPickedUp; // 0x98
	public FeralAudioInfo runeGroupSinglePlaced; // 0xA0
	public FeralAudioInfo runeGroupDoublePlaced; // 0xA8
	public FeralAudioInfo runeGroupTriplePlaced; // 0xB0
	public FeralAudioInfo runeGroupReturnToSpawn; // 0xB8
	public FeralAudioInfo runeGroupRotateTiles; // 0xC0
	public FeralAudioInfo runeGroupWiggle; // 0xC8
	public FeralAudioInfo runeGroupDespawned; // 0xD0
	[Space] // 0x00000001801D1250-0x00000001801D1270
	public FeralAudioInfo pointsComboMultiplier; // 0xD8
	public FeralAudioInfo runeIconMove; // 0xE0
	public FeralAudioInfo runeIconRestore; // 0xE8
	[Space] // 0x00000001801D1250-0x00000001801D1270
	public FeralAudioInfo cycloneSpawned; // 0xF0
	public FeralAudioInfo cyclonePickedUp; // 0xF8
	public FeralAudioInfo cyclonePlaced; // 0x100
	public FeralAudioInfo cycloneCollectionFinished; // 0x108
	public FeralAudioInfo cycloneLiftedUpTile; // 0x110
	public FeralAudioInfo cycloneCollectedTile; // 0x118
	[Space] // 0x00000001801D1250-0x00000001801D1270
	public FeralAudioInfo meterFilledFlame; // 0x120
	public FeralAudioInfo meterFilledFlora; // 0x128
	public FeralAudioInfo meterFilledMiasma; // 0x130
	public FeralAudioInfo powerupMeterFillingLoop; // 0x138

	// Properties
	public static GameObject AudioGO { get; } // 0x0000000180730B40-0x0000000180730BD0 

	// Constructors
	public RunesAudio(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Awake(); // 0x000000018072F030-0x000000018072F070
	public static void PlayGameMusic(); // 0x000000018072F6A0-0x000000018072F750
	public static void StopGameMusic(); // 0x0000000180730930-0x00000001807309E0
	public static void PlaySplashMusic(); // 0x0000000180730300-0x00000001807303B0
	public static void StopSplashMusic(); // 0x0000000180730A90-0x0000000180730B40
	public static void PlayGameOverStinger(); // 0x000000018072F750-0x000000018072F800
	public static void PlayUiPopupStinger(); // 0x00000001807307D0-0x0000000180730880
	public static void PlayUiButtonOK(); // 0x0000000180730670-0x0000000180730720
	public static void PlayUiButtonStart(); // 0x0000000180730720-0x00000001807307D0
	public static void PlayUiButtonExit(); // 0x0000000180730510-0x00000001807305C0
	public static void PlayUiButtonNext(); // 0x00000001807305C0-0x0000000180730670
	public static void PlayUIForcedTutorialPopup(); // 0x0000000180730460-0x0000000180730510
	public static void PlayUIForcedTutorialContinue(); // 0x00000001807303B0-0x0000000180730460
	public static void PlayBombAvailable(); // 0x000000018072F070-0x000000018072F120
	public static void PlayBombPickedUp(); // 0x000000018072F120-0x000000018072F1D0
	public static void PlayBombPlaced(); // 0x000000018072F1D0-0x000000018072F280
	public static void PlayRuneGroupSpawned(); // 0x000000018072FF90-0x0000000180730040
	public static void PlayRuneGroupPickedUp(); // 0x000000018072FCD0-0x000000018072FD80
	public static void PlayRuneGroupSinglePlaced(); // 0x000000018072FEE0-0x000000018072FF90
	public static void PlayRuneGroupDoublePlaced(); // 0x000000018072FC20-0x000000018072FCD0
	public static void PlayRuneGroupTriplePlaced(); // 0x0000000180730040-0x00000001807300F0
	public static void PlayRuneGroupReturnToSpawn(); // 0x000000018072FD80-0x000000018072FE30
	public static void PlayRuneGroupRotateTiles(); // 0x000000018072FE30-0x000000018072FEE0
	public static void PlayRuneGroupWiggle(); // 0x00000001807300F0-0x00000001807301A0
	public static void PlayRuneGroupDespawned(); // 0x000000018072FB70-0x000000018072FC20
	public static void PlayCycloneSpawned(); // 0x000000018072F5F0-0x000000018072F6A0
	public static void PlayCyclonePickedUp(); // 0x000000018072F490-0x000000018072F540
	public static void PlayCyclonePlaced(); // 0x000000018072F540-0x000000018072F5F0
	public static void PlayCycloneFinished(); // 0x000000018072F330-0x000000018072F3E0
	public static void PlayCycloneLiftedUpTile(); // 0x000000018072F3E0-0x000000018072F490
	public static void PlayCycloneCollectedTile(); // 0x000000018072F280-0x000000018072F330
	public static void PlayMeterFilledFlame(); // 0x000000018072F800-0x000000018072F8B0
	public static void PlayMeterFilledFlora(); // 0x000000018072F8B0-0x000000018072F960
	public static void PlayMeterFilledMiasma(); // 0x000000018072F960-0x000000018072FA10
	public static void PlayPowerupMeterFillingLoop(); // 0x000000018072FAC0-0x000000018072FB70
	public static void StopPowerupMeterFillingLoop(); // 0x00000001807309E0-0x0000000180730A90
	public static void PlayPointsComboMultiplier(); // 0x000000018072FA10-0x000000018072FAC0
	public static void PlayRuneIconMove(); // 0x00000001807301A0-0x0000000180730250
	public static void PlayRuneIconRestore(); // 0x0000000180730250-0x0000000180730300
	public static void PlayUiRewardReceived(); // 0x0000000180730880-0x0000000180730930
}

