/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_AvatarActionWheelItem : MonoBehaviour // TypeDefIndex: 12282
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _button; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _iconImage; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_Tooltip _tooltip; // 0x30
	private AvatarActionDefComponent _avatarAction; // 0x38

	// Constructors
	public UI_AvatarActionWheelItem(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public void Setup(AvatarActionDefComponent inAvatarAction); // 0x0000000180FB8C50-0x0000000180FB8E40
	public void BtnClicked_Emote(); // 0x0000000180FB8C20-0x0000000180FB8C50
}

