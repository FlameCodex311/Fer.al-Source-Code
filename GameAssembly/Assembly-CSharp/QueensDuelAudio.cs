/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class QueensDuelAudio : MonoBehaviour // TypeDefIndex: 13104
{
	// Fields
	private bool _playOneAudio; // 0x20
	private static QueensDuelAudio _instance; // 0x00
	[Tooltip] // 0x00000001800E5FF0-0x00000001800E6020
	public FeralAudioInfo attackButton; // 0x28
	[Tooltip] // 0x00000001800E6160-0x00000001800E6190
	public FeralAudioInfo invalidDropSlide; // 0x30
	[Tooltip] // 0x00000001800E63E0-0x00000001800E6410
	public FeralAudioInfo groupPickup; // 0x38
	[Tooltip] // 0x00000001800E6530-0x00000001800E6560
	public FeralAudioInfo singlePickup; // 0x40
	[Tooltip] // 0x00000001800E6750-0x00000001800E6780
	public FeralAudioInfo rotateRise; // 0x48
	[Tooltip] // 0x00000001800E6850-0x00000001800E6880
	public FeralAudioInfo rotateLoop; // 0x50
	[Tooltip] // 0x00000001800E6910-0x00000001800E6940
	public FeralAudioInfo rotateLower; // 0x58
	private static bool _canPlayDrop; // 0x08
	[Tooltip] // 0x00000001800E6AA0-0x00000001800E6AD0
	public FeralAudioInfo groupDrop; // 0x60
	[Tooltip] // 0x00000001800E6C60-0x00000001800E6C90
	public FeralAudioInfo singleDrop; // 0x68
	[Tooltip] // 0x00000001800E6CF0-0x00000001800E6D20
	public FeralAudioInfo selectionKeep; // 0x70
	[Tooltip] // 0x00000001800E6E00-0x00000001800E6E30
	public FeralAudioInfo wallAppear; // 0x78
	[Tooltip] // 0x00000001800E8230-0x00000001800E8260
	public FeralAudioInfo wallDisappear; // 0x80
	[Tooltip] // 0x00000001800E8380-0x00000001800E83B0
	public FeralAudioInfo wallLoop; // 0x88
	[Tooltip] // 0x00000001800E87E0-0x00000001800E8810
	public FeralAudioInfo attackEffect; // 0x90

	// Properties
	public static GameObject AudioGO { get; } // 0x00000001815F6110-0x00000001815F61E0 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 13105
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action <>9__19_0; // 0x08
		public static Action <>9__34_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001816080B0-0x0000000181608110
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <PlayRotateLower>b__19_0(); // 0x0000000181607E70-0x0000000181607ED0
		internal void <PlayOne>b__34_0(); // 0x0000000181607E00-0x0000000181607E70
	}

	// Constructors
	public QueensDuelAudio(); // 0x0000000180E095D0-0x0000000180E095E0
	static QueensDuelAudio(); // 0x00000001815F60D0-0x00000001815F6110

	// Methods
	private void Awake(); // 0x00000001815F5430-0x00000001815F5490
	public static void PlayAttackButton(); // 0x00000001815F5490-0x00000001815F5520
	public static void PlayInvalidDropSlide(); // 0x00000001815F5730-0x00000001815F57E0
	public static void PlayGroupPickup(); // 0x00000001815F5680-0x00000001815F5730
	public static void PlaySinglePickup(); // 0x00000001815F5E10-0x00000001815F5EA0
	public static void PlayRotateRise(); // 0x00000001815F5C40-0x00000001815F5CF0
	public static void PlayRotateLoop(bool inPlay); // 0x00000001815F5990-0x00000001815F5A90
	public static void PlayRotateLower(); // 0x00000001815F5A90-0x00000001815F5C40
	public static void PlayGroupDrop(); // 0x00000001815F55D0-0x00000001815F5680
	public static void PlaySingleDrop(); // 0x00000001815F5D80-0x00000001815F5E10
	public static void PlaySelectionKeep(); // 0x00000001815F5CF0-0x00000001815F5D80
	public static void PlayWallAppear(); // 0x00000001815F5EA0-0x00000001815F5F30
	public static void PlayWallDisappear(); // 0x00000001815F5F30-0x00000001815F5FD0
	public static void PlayWallLoop(bool inPlay); // 0x00000001815F5FD0-0x00000001815F60D0
	public static void PlayAttackEffect(); // 0x00000001815F5520-0x00000001815F55D0
	public static void PlayOne(Action<GameObject> inAudioEffectPlay); // 0x00000001815F57E0-0x00000001815F5990
}

