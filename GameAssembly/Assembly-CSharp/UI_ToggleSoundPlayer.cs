/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RequireComponent] // 0x000000018024C990-0x000000018024C9E0
public class UI_ToggleSoundPlayer : MonoBehaviour // TypeDefIndex: 13960
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _button; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _audioInfoOn; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _audioInfoOff; // 0x30

	// Constructors
	public UI_ToggleSoundPlayer(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Reset(); // 0x00000001806395B0-0x00000001806395F0
	private void Awake(); // 0x00000001806393F0-0x00000001806394D0
	private void OnDestroy(); // 0x00000001806394D0-0x0000000180639570
	private void OnToggle(bool inIsOn); // 0x0000000180639570-0x00000001806395B0
}

