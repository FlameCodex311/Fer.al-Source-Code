/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RequireComponent] // 0x0000000180156FF0-0x0000000180157040
public class UI_ToggleSoundPlayer : MonoBehaviour // TypeDefIndex: 12375
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _button; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _audioInfoOn; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _audioInfoOff; // 0x30

	// Constructors
	public UI_ToggleSoundPlayer(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Reset(); // 0x0000000180F98BB0-0x0000000180F98BF0
	private void Awake(); // 0x0000000180F989F0-0x0000000180F98AD0
	private void OnDestroy(); // 0x0000000180F98AD0-0x0000000180F98B70
	private void OnToggle(bool inIsOn); // 0x0000000180F98B70-0x0000000180F98BB0
}

