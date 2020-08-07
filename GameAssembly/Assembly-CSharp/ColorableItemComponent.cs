/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class ColorableItemComponent : ItemComponent // TypeDefIndex: 11995
{
	// Fields
	public HSVColor color1HSV; // 0x20
	public HSVColor color2HSV; // 0x58
	public HSVColor color3HSV; // 0x90
	public HSVColor color4HSV; // 0xC8
	private ColorableDefComponent _defComponent; // 0x100

	// Properties
	private ColorableDefComponent DefComponent { get; } // 0x000000018077DC30-0x000000018077DC90 
	public int AvailableChannels { get; } // 0x000000018077D810-0x000000018077D890 
	public HSVColor Color1HSVDefault { get; } // 0x000000018077D890-0x000000018077D970 
	public HSVColor Color2HSVDefault { get; } // 0x000000018077D970-0x000000018077DA50 
	public HSVColor Color3HSVDefault { get; } // 0x000000018077DA50-0x000000018077DB40 
	public HSVColor Color4HSVDefault { get; } // 0x000000018077DB40-0x000000018077DC30 

	// Constructors
	public ColorableItemComponent(); // 0x000000018077D660-0x000000018077D810

	// Methods
	public HSVColor GetDefaultColor(int inChannelIndex); // 0x000000018077CD10-0x000000018077D010
	public HSVColor GetColor(int inChannelIndex); // 0x000000018077CBE0-0x000000018077CD10
	public void SetColor(HSVColor inColor, int inChannelIndex); // 0x000000018077D4D0-0x000000018077D660
	public void ApplyColorsToMaterial(Material inMaterial); // 0x000000018077C6B0-0x000000018077C830
	public void ApplyColorsToRenderer(Renderer inTargetRenderer); // 0x000000018077C830-0x000000018077CA40
	public void SetAndApplyColor(HSVColor inColor, int inChannelIndex, Renderer inTargetRenderer = null); // 0x000000018077D310-0x000000018077D4D0
	public static void PreviewColorsOnRenderer(List<HSVColor> inColors, Renderer inTargetRenderer); // 0x000000018077D010-0x000000018077D310
	public static ColorableItemComponent CreateFromDef(BaseDef inDef); // 0x000000018077CA40-0x000000018077CBE0
}

