/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_TooltipToggle : UI_Tooltip // TypeDefIndex: 12380
{
	// Fields
	[RootSelector] // 0x0000000180158910-0x0000000180158990
	[SerializeField] // 0x0000000180158910-0x0000000180158990
	private string _localizationDefIdOn; // 0x90
	[RootSelector] // 0x0000000180158C10-0x0000000180158C90
	[SerializeField] // 0x0000000180158C10-0x0000000180158C90
	private string _localizationDefIdOff; // 0x98
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralButton _button; // 0xA0

	// Constructors
	public UI_TooltipToggle(); // 0x0000000180F9B000-0x0000000180F9B080

	// Methods
	public override void MStart(); // 0x0000000180F9AE00-0x0000000180F9AF30
	public override void MOnDestroy(); // 0x0000000180F9ACB0-0x0000000180F9AE00
	protected override void Reset(); // 0x0000000180F9AF60-0x0000000180F9B000
	private void OnButtonToggled(bool inIsOn); // 0x0000000180F9AF30-0x0000000180F9AF60
}

