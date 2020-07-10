/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class QuestMudMonsterAudio : MonoBehaviour // TypeDefIndex: 11674
{
	// Fields
	private static QuestMudMonsterAudio _instance; // 0x00
	public FeralAudioInfo musicDanger; // 0x20
	public FeralAudioInfo awareStinger; // 0x28

	// Properties
	public static GameObject AudioGO { get; } // 0x000000018100ADE0-0x000000018100AE70 

	// Constructors
	public QuestMudMonsterAudio(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Awake(); // 0x000000018100AC00-0x000000018100AC40
	public static void PlayMusic_Danger(bool inPlay); // 0x000000018100ACF0-0x000000018100ADE0
	public static void PlayAwareStinger(); // 0x000000018100AC40-0x000000018100ACF0
}

