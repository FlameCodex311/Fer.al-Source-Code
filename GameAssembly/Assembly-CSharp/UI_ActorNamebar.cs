/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ActorNamebar : UI_ScreenSpaceTransform // TypeDefIndex: 12281
{
	// Fields
	public WWTextMeshProUGUI namebarText; // 0xC0
	private ActorBase _targetActor; // 0xC8

	// Properties
	public ActorBase TargetActor { get; set; } // 0x00000001804A2590-0x00000001804A25A0 0x00000001804A22E0-0x00000001804A22F0

	// Constructors
	public UI_ActorNamebar(); // 0x0000000180FB2F00-0x0000000180FB2F10

	// Methods
	public override void MOnDestroy(); // 0x000000018036B6C0-0x000000018036B6D0
	public override void MStart(); // 0x0000000180FB8B50-0x0000000180FB8BD0
	public void UpdateNamebarText(); // 0x0000000180FB8BD0-0x0000000180FB8C20
}

