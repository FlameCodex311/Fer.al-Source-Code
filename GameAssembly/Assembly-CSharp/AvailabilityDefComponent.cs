/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ChartComponent] // 0x00000001800C0E00-0x00000001800C0E30
public class AvailabilityDefComponent : DefComponent // TypeDefIndex: 10266
{
	// Fields
	[ChartDef] // 0x00000001800C0FF0-0x00000001800C1070
	public ChartDef dateOverrideRef; // 0x18
	[ChartDate] // 0x00000001800B5960-0x00000001800B5970
	public ChartDate chartDateAvailability; // 0x20

	// Constructors
	public AvailabilityDefComponent(); // 0x000000018103EA50-0x000000018103EAD0

	// Methods
	[ChartSearch] // 0x00000001800C15F0-0x00000001800C1620
	public static bool AvailabileNowSearch(DefComponent inDefComponent, string inSearch); // 0x000000018103E8C0-0x000000018103E980
	[ChartSearch] // 0x00000001800C17C0-0x00000001800C17F0
	public static bool AvailabilitySearch(DefComponent inDefComponent, string inSearch); // 0x000000018103E980-0x000000018103EA50
}

