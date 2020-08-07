/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ActorNamebar : UI_ScreenSpaceTransform // TypeDefIndex: 13865
{
	// Fields
	public WWTextMeshProUGUI namebarText; // 0xC0
	private ActorBase _targetActor; // 0xC8

	// Properties
	public ActorBase TargetActor { get; set; } // 0x00000001804AF400-0x00000001804AF410 0x00000001804AF520-0x00000001804AF530

	// Constructors
	public UI_ActorNamebar(); // 0x0000000180517EC0-0x0000000180517ED0

	// Methods
	public override void MOnDestroy(); // 0x0000000180373240-0x0000000180373250
	public override void MStart(); // 0x000000018051DA00-0x000000018051DA80
	public void UpdateNamebarText(); // 0x000000018051DA80-0x000000018051DAD0
}

