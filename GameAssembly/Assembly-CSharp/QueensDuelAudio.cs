/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class QueensDuelAudio : MonoBehaviour // TypeDefIndex: 10769
{
	// Fields
	private bool _playOneAudio; // 0x20
	private static QueensDuelAudio _instance; // 0x00
	[Tooltip] // 0x0000000180280C30-0x0000000180280C60
	public FeralAudioInfo attackButton; // 0x28
	[Tooltip] // 0x0000000180280DA0-0x0000000180280DD0
	public FeralAudioInfo invalidDropSlide; // 0x30
	[Tooltip] // 0x0000000180280E00-0x0000000180280E30
	public FeralAudioInfo groupPickup; // 0x38
	[Tooltip] // 0x0000000180280F00-0x0000000180280F30
	public FeralAudioInfo singlePickup; // 0x40
	[Tooltip] // 0x0000000180281180-0x00000001802811B0
	public FeralAudioInfo rotateRise; // 0x48
	[Tooltip] // 0x0000000180281340-0x0000000180281370
	public FeralAudioInfo rotateLoop; // 0x50
	[Tooltip] // 0x00000001802815F0-0x0000000180281620
	public FeralAudioInfo rotateLower; // 0x58
	private static bool _canPlayDrop; // 0x08
	[Tooltip] // 0x0000000180281770-0x00000001802817A0
	public FeralAudioInfo groupDrop; // 0x60
	[Tooltip] // 0x00000001802818B0-0x00000001802818E0
	public FeralAudioInfo singleDrop; // 0x68
	[Tooltip] // 0x0000000180281A10-0x0000000180281A40
	public FeralAudioInfo selectionKeep; // 0x70
	[Tooltip] // 0x0000000180281C20-0x0000000180281C50
	public FeralAudioInfo wallAppear; // 0x78
	[Tooltip] // 0x0000000180281E20-0x0000000180281E50
	public FeralAudioInfo wallDisappear; // 0x80
	[Tooltip] // 0x0000000180281F40-0x0000000180281F70
	public FeralAudioInfo wallLoop; // 0x88
	[Tooltip] // 0x00000001802820D0-0x0000000180282100
	public FeralAudioInfo attackEffect; // 0x90

	// Properties
	public static GameObject AudioGO { get; } // 0x0000000180A33B60-0x0000000180A33C30 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10770
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action <>9__19_0; // 0x08
		public static Action <>9__34_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180A44520-0x0000000180A44580
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <PlayRotateLower>b__19_0(); // 0x0000000180A44350-0x0000000180A443B0
		internal void <PlayOne>b__34_0(); // 0x0000000180A442E0-0x0000000180A44350
	}

	// Constructors
	public QueensDuelAudio(); // 0x00000001803743C0-0x00000001803743D0
	static QueensDuelAudio(); // 0x0000000180A33B20-0x0000000180A33B60

	// Methods
	private void Awake(); // 0x0000000180A32E80-0x0000000180A32EE0
	public static void PlayAttackButton(); // 0x0000000180A32EE0-0x0000000180A32F70
	public static void PlayInvalidDropSlide(); // 0x0000000180A33180-0x0000000180A33230
	public static void PlayGroupPickup(); // 0x0000000180A330D0-0x0000000180A33180
	public static void PlaySinglePickup(); // 0x0000000180A33860-0x0000000180A338F0
	public static void PlayRotateRise(); // 0x0000000180A33690-0x0000000180A33740
	public static void PlayRotateLoop(bool inPlay); // 0x0000000180A333E0-0x0000000180A334E0
	public static void PlayRotateLower(); // 0x0000000180A334E0-0x0000000180A33690
	public static void PlayGroupDrop(); // 0x0000000180A33020-0x0000000180A330D0
	public static void PlaySingleDrop(); // 0x0000000180A337D0-0x0000000180A33860
	public static void PlaySelectionKeep(); // 0x0000000180A33740-0x0000000180A337D0
	public static void PlayWallAppear(); // 0x0000000180A338F0-0x0000000180A33980
	public static void PlayWallDisappear(); // 0x0000000180A33980-0x0000000180A33A20
	public static void PlayWallLoop(bool inPlay); // 0x0000000180A33A20-0x0000000180A33B20
	public static void PlayAttackEffect(); // 0x0000000180A32F70-0x0000000180A33020
	public static void PlayOne(Action<GameObject> inAudioEffectPlay); // 0x0000000180A33230-0x0000000180A333E0
}

