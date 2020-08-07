/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class QuestMudMonsterAudio : MonoBehaviour // TypeDefIndex: 13200
{
	// Fields
	private static QuestMudMonsterAudio _instance; // 0x00
	public FeralAudioInfo musicDanger; // 0x20
	public FeralAudioInfo awareStinger; // 0x28

	// Properties
	public static GameObject AudioGO { get; } // 0x000000018064E9C0-0x000000018064EA50 

	// Constructors
	public QuestMudMonsterAudio(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Awake(); // 0x000000018064E7E0-0x000000018064E820
	public static void PlayMusic_Danger(bool inPlay); // 0x000000018064E8D0-0x000000018064E9C0
	public static void PlayAwareStinger(); // 0x000000018064E820-0x000000018064E8D0
}

