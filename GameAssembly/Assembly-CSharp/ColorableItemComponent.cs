/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class ColorableItemComponent : ItemComponent // TypeDefIndex: 10507
{
	// Fields
	public HSVColor color1HSV; // 0x20
	public HSVColor color2HSV; // 0x58
	public HSVColor color3HSV; // 0x90
	public HSVColor color4HSV; // 0xC8
	private ColorableDefComponent _defComponent; // 0x100

	// Properties
	private ColorableDefComponent DefComponent { get; } // 0x0000000181472530-0x0000000181472590 
	public int AvailableChannels { get; } // 0x0000000181472110-0x0000000181472190 
	public HSVColor Color1HSVDefault { get; } // 0x0000000181472190-0x0000000181472270 
	public HSVColor Color2HSVDefault { get; } // 0x0000000181472270-0x0000000181472350 
	public HSVColor Color3HSVDefault { get; } // 0x0000000181472350-0x0000000181472440 
	public HSVColor Color4HSVDefault { get; } // 0x0000000181472440-0x0000000181472530 

	// Constructors
	public ColorableItemComponent(); // 0x0000000181471F60-0x0000000181472110

	// Methods
	public HSVColor GetDefaultColor(int inChannelIndex); // 0x0000000181471600-0x0000000181471900
	public HSVColor GetColor(int inChannelIndex); // 0x00000001814714D0-0x0000000181471600
	public void SetColor(HSVColor inColor, int inChannelIndex); // 0x0000000181471DD0-0x0000000181471F60
	public void ApplyColorsToMaterial(Material inMaterial); // 0x0000000181470FA0-0x0000000181471120
	public void ApplyColorsToRenderer(Renderer inTargetRenderer); // 0x0000000181471120-0x0000000181471330
	public void SetAndApplyColor(HSVColor inColor, int inChannelIndex, Renderer inTargetRenderer = null); // 0x0000000181471C10-0x0000000181471DD0
	public static void PreviewColorsOnRenderer(List<HSVColor> inColors, Renderer inTargetRenderer); // 0x0000000181471900-0x0000000181471C10
	public static ColorableItemComponent CreateFromDef(BaseDef inDef); // 0x0000000181471330-0x00000001814714D0
}

