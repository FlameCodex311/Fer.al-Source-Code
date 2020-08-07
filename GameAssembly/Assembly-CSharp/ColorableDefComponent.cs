/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartComponent] // 0x0000000180251090-0x00000001802510C0
public class ColorableDefComponent : DefComponent, IItemDefComponent // TypeDefIndex: 11750
{
	// Fields
	[ChartHSV] // 0x00000001801DE450-0x00000001801DE460
	public HSVColor color1HSVDefault; // 0x18
	[ChartHSV] // 0x00000001801DE450-0x00000001801DE460
	public HSVColor color2HSVDefault; // 0x50
	[ChartHSV] // 0x00000001801DE450-0x00000001801DE460
	public HSVColor color3HSVDefault; // 0x88
	[ChartHSV] // 0x00000001801DE450-0x00000001801DE460
	public HSVColor color4HSVDefault; // 0xC0
	[ChartInt] // 0x00000001801DE450-0x00000001801DE460
	public int channelCount; // 0xF8

	// Constructors
	public ColorableDefComponent(); // 0x00000001803FB1F0-0x00000001803FB200

	// Methods
	public void OnClientOnlyItemCreated(Item item); // 0x000000018077C660-0x000000018077C6B0
}

