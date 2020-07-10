/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class MoonPhasesAudio : MonoBehaviour // TypeDefIndex: 13044
{
	// Fields
	private static MoonPhasesAudio _instance; // 0x00
	[Tooltip] // 0x00000001800C6A30-0x00000001800C6A60
	public FeralAudioInfo tokenSpawn; // 0x20
	[Tooltip] // 0x00000001800C6BB0-0x00000001800C6BE0
	public FeralAudioInfo tilePlaced; // 0x28
	[Tooltip] // 0x00000001800C6DB0-0x00000001800C6DE0
	public FeralAudioInfo tileSelected; // 0x30
	[Tooltip] // 0x00000001800C6EA0-0x00000001800C6ED0
	public FeralAudioInfo tilesReturned; // 0x38
	[Tooltip] // 0x00000001800C7220-0x00000001800C7250
	public FeralAudioInfo crystalTokenLP; // 0x40
	[Tooltip] // 0x00000001800C7390-0x00000001800C73C0
	public FeralAudioInfo dealerTokenLP; // 0x48
	[Tooltip] // 0x00000001800C7640-0x00000001800C7670
	public FeralAudioInfo crystalTokenStart; // 0x50
	[Tooltip] // 0x00000001800C7970-0x00000001800C79A0
	public FeralAudioInfo dealerTokenStart; // 0x58
	[Tooltip] // 0x00000001800C7CA0-0x00000001800C7CD0
	public FeralAudioInfo crystalTokenStop; // 0x60
	[Tooltip] // 0x00000001800C7E60-0x00000001800C7E90
	public FeralAudioInfo dealerTokenStop; // 0x68

	// Properties
	public static GameObject AudioGO { get; } // 0x00000001810B94F0-0x00000001810B9580 

	// Constructors
	public MoonPhasesAudio(); // 0x0000000180407560-0x0000000180407570

	// Methods
	private void Awake(); // 0x00000001810B8D50-0x00000001810B8D90
	public void PlayTokenSpawn(); // 0x00000001810B9440-0x00000001810B94F0
	public static void PlayTilePlaced(); // 0x00000001810B9230-0x00000001810B92E0
	public static void PlayTileSelected(); // 0x00000001810B92E0-0x00000001810B9390
	public static void PlayTilesReturned(); // 0x00000001810B9390-0x00000001810B9440
	public static void PlayCrystalTokenLP(bool inPlay); // 0x00000001810B8D90-0x00000001810B8E80
	public static void PlayDealerTokenLP(bool inPlay); // 0x00000001810B8FE0-0x00000001810B90D0
	public static void PlayCrystalTokenStart(); // 0x00000001810B8E80-0x00000001810B8F30
	public static void PlayDealerTokenStart(); // 0x00000001810B90D0-0x00000001810B9180
	public static void PlayCrystalTokenStop(); // 0x00000001810B8F30-0x00000001810B8FE0
	public static void PlayDealerTokenStop(); // 0x00000001810B9180-0x00000001810B9230
}

