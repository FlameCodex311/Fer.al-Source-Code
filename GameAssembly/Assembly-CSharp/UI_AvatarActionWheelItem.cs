/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_AvatarActionWheelItem : MonoBehaviour // TypeDefIndex: 13866
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _button; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _iconImage; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_Tooltip _tooltip; // 0x30
	private AvatarActionDefComponent _avatarAction; // 0x38

	// Constructors
	public UI_AvatarActionWheelItem(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void Setup(AvatarActionDefComponent inAvatarAction); // 0x000000018051DB00-0x000000018051DCF0
	public void BtnClicked_Emote(); // 0x000000018051DAD0-0x000000018051DB00
}

