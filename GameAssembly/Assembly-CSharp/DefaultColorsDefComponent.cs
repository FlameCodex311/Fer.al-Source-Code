/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartComponent] // 0x00000001800BF650-0x00000001800BF680
public class DefaultColorsDefComponent : DefComponent // TypeDefIndex: 10260
{
	// Fields
	[ChartHSV] // 0x00000001800BF800-0x00000001800BF830
	[ChartList] // 0x00000001800BF800-0x00000001800BF830
	public List<HSVColor> defaultColors; // 0x18
	[ChartButton] // 0x00000001800BFAF0-0x00000001800BFB50
	private bool buttonGetColorsFromCustomizer; // 0x20

	// Constructors
	public DefaultColorsDefComponent(); // 0x0000000181184280-0x00000001811842E0

	// Methods
	public void ApplyColorsToRenderer(Renderer inTargetRenderer); // 0x0000000181183EF0-0x00000001811840B0
	public void ApplyColorsToMaterial(Material inMaterial); // 0x0000000181183D60-0x0000000181183EF0
	public void PullColorsFromCurrentLook(PropertyEditor.DefEntry inDefEntry); // 0x00000001811840B0-0x0000000181184280
}

