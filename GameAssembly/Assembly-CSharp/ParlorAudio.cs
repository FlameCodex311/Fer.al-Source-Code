/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ParlorAudio : MonoBehaviour // TypeDefIndex: 13094
{
	// Fields
	private static ParlorAudio _instance; // 0x00
	[Tooltip] // 0x00000001800E1DB0-0x00000001800E1DE0
	public FeralAudioInfo parlorGameMusic; // 0x20
	[Tooltip] // 0x00000001800E1ED0-0x00000001800E1F00
	public FeralAudioInfo parlorGameSelection; // 0x28
	[Space] // 0x00000001800E2020-0x00000001800E2070
	[Tooltip] // 0x00000001800E2020-0x00000001800E2070
	public FeralAudioInfo stingerWin; // 0x30
	[Tooltip] // 0x00000001800E21F0-0x00000001800E2220
	public FeralAudioInfo stingerFail; // 0x38
	[Tooltip] // 0x00000001800E23E0-0x00000001800E2410
	public FeralAudioInfo boardRollout; // 0x40
	[Tooltip] // 0x00000001800E25A0-0x00000001800E25D0
	public FeralAudioInfo boardRollUp; // 0x48
	[Tooltip] // 0x00000001800E2790-0x00000001800E27C0
	public FeralAudioInfo likesCounter; // 0x50
	[Tooltip] // 0x00000001800E2950-0x00000001800E2980
	public FeralAudioInfo crystalsZipping; // 0x58

	// Properties
	internal static GameObject AudioGO { get; } // 0x000000018116BCF0-0x000000018116BD80 

	// Constructors
	public ParlorAudio(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Awake(); // 0x000000018116B8B0-0x000000018116B8F0
	internal static void PlayMusic_ParlorGameMusic(bool inPlay); // 0x000000018116BAB0-0x000000018116BB60
	internal static void PlayMusic_ParlorGameSelection(bool inPlay); // 0x000000018116BB60-0x000000018116BC10
	internal static void PlayStingerWin(); // 0x000000018116BC80-0x000000018116BCF0
	internal static void PlayStingerFail(); // 0x000000018116BC10-0x000000018116BC80
	internal static void PlayBoardRollout(); // 0x000000018116B960-0x000000018116B9D0
	internal static void PlayBoardRollUp(); // 0x000000018116B8F0-0x000000018116B960
	internal static void PlayLikesCounter(); // 0x000000018116BA40-0x000000018116BAB0
	internal static void PlayCrystalsZipping(); // 0x000000018116B9D0-0x000000018116BA40
}

