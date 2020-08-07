/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_TooltipToggle : UI_Tooltip // TypeDefIndex: 13965
{
	// Fields
	[RootSelector] // 0x000000018024E060-0x000000018024E0E0
	[SerializeField] // 0x000000018024E060-0x000000018024E0E0
	private string _localizationDefIdOn; // 0x90
	[RootSelector] // 0x000000018024E290-0x000000018024E310
	[SerializeField] // 0x000000018024E290-0x000000018024E310
	private string _localizationDefIdOff; // 0x98
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _button; // 0xA0

	// Constructors
	public UI_TooltipToggle(); // 0x000000018063B920-0x000000018063B9A0

	// Methods
	public override void MStart(); // 0x000000018063B720-0x000000018063B850
	public override void MOnDestroy(); // 0x000000018063B5E0-0x000000018063B720
	protected override void Reset(); // 0x000000018063B880-0x000000018063B920
	private void OnButtonToggled(bool inIsOn); // 0x000000018063B850-0x000000018063B880
}

