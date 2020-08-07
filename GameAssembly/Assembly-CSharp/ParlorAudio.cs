/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ParlorAudio : MonoBehaviour // TypeDefIndex: 10759
{
	// Fields
	private static ParlorAudio _instance; // 0x00
	[Tooltip] // 0x000000018027BCC0-0x000000018027BCF0
	public FeralAudioInfo parlorGameMusic; // 0x20
	[Tooltip] // 0x000000018027BEE0-0x000000018027BF10
	public FeralAudioInfo parlorGameSelection; // 0x28
	[Space] // 0x000000018027C040-0x000000018027C090
	[Tooltip] // 0x000000018027C040-0x000000018027C090
	public FeralAudioInfo stingerWin; // 0x30
	[Tooltip] // 0x000000018027C360-0x000000018027C390
	public FeralAudioInfo stingerFail; // 0x38
	[Tooltip] // 0x000000018027C520-0x000000018027C550
	public FeralAudioInfo boardRollout; // 0x40
	[Tooltip] // 0x000000018027C670-0x000000018027C6A0
	public FeralAudioInfo boardRollUp; // 0x48
	[Tooltip] // 0x000000018027C8B0-0x000000018027C8E0
	public FeralAudioInfo likesCounter; // 0x50
	[Tooltip] // 0x000000018027CB40-0x000000018027CB70
	public FeralAudioInfo crystalsZipping; // 0x58

	// Properties
	internal static GameObject AudioGO { get; } // 0x00000001804D8BB0-0x00000001804D8C40 

	// Constructors
	public ParlorAudio(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Awake(); // 0x00000001804D8770-0x00000001804D87B0
	internal static void PlayMusic_ParlorGameMusic(bool inPlay); // 0x00000001804D8970-0x00000001804D8A20
	internal static void PlayMusic_ParlorGameSelection(bool inPlay); // 0x00000001804D8A20-0x00000001804D8AD0
	internal static void PlayStingerWin(); // 0x00000001804D8B40-0x00000001804D8BB0
	internal static void PlayStingerFail(); // 0x00000001804D8AD0-0x00000001804D8B40
	internal static void PlayBoardRollout(); // 0x00000001804D8820-0x00000001804D8890
	internal static void PlayBoardRollUp(); // 0x00000001804D87B0-0x00000001804D8820
	internal static void PlayLikesCounter(); // 0x00000001804D8900-0x00000001804D8970
	internal static void PlayCrystalsZipping(); // 0x00000001804D8890-0x00000001804D8900
}

