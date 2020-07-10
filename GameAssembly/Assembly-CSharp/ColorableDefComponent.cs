/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartComponent] // 0x00000001800BDA10-0x00000001800BDA40
public class ColorableDefComponent : DefComponent, IItemDefComponent // TypeDefIndex: 10259
{
	// Fields
	[ChartHSV] // 0x00000001800B5960-0x00000001800B5970
	public HSVColor color1HSVDefault; // 0x18
	[ChartHSV] // 0x00000001800B5960-0x00000001800B5970
	public HSVColor color2HSVDefault; // 0x50
	[ChartHSV] // 0x00000001800B5960-0x00000001800B5970
	public HSVColor color3HSVDefault; // 0x88
	[ChartHSV] // 0x00000001800B5960-0x00000001800B5970
	public HSVColor color4HSVDefault; // 0xC0
	[ChartInt] // 0x00000001800B5960-0x00000001800B5970
	public int channelCount; // 0xF8

	// Constructors
	public ColorableDefComponent(); // 0x0000000180363710-0x0000000180363720

	// Methods
	public void OnClientOnlyItemCreated(Item item); // 0x0000000181470F50-0x0000000181470FA0
}

