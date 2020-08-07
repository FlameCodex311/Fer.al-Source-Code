/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartComponent] // 0x0000000180251D90-0x0000000180251DC0
public class DefaultColorsDefComponent : DefComponent // TypeDefIndex: 11751
{
	// Fields
	[ChartHSV] // 0x0000000180203CA0-0x0000000180203CD0
	[ChartList] // 0x0000000180203CA0-0x0000000180203CD0
	public List<HSVColor> defaultColors; // 0x18
	[ChartButton] // 0x0000000180252170-0x00000001802521D0
	private bool buttonGetColorsFromCustomizer; // 0x20

	// Constructors
	public DefaultColorsDefComponent(); // 0x000000018055FB60-0x000000018055FBC0

	// Methods
	public void ApplyColorsToRenderer(Renderer inTargetRenderer); // 0x000000018055F7D0-0x000000018055F990
	public void ApplyColorsToMaterial(Material inMaterial); // 0x000000018055F640-0x000000018055F7D0
	public void PullColorsFromCurrentLook(PropertyEditor.DefEntry inDefEntry); // 0x000000018055F990-0x000000018055FB60
}

