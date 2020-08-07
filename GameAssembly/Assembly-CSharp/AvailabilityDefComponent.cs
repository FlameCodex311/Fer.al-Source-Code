/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ChartComponent] // 0x0000000180253BB0-0x0000000180253BE0
public class AvailabilityDefComponent : DefComponent // TypeDefIndex: 11757
{
	// Fields
	[ChartDef] // 0x0000000180253CD0-0x0000000180253D50
	public ChartDef dateOverrideRef; // 0x18
	[ChartDate] // 0x00000001801DE450-0x00000001801DE460
	public ChartDate chartDateAvailability; // 0x20

	// Constructors
	public AvailabilityDefComponent(); // 0x0000000182157AB0-0x0000000182157B30

	// Methods
	[ChartSearch] // 0x00000001802542E0-0x0000000180254310
	public static bool AvailabileNowSearch(DefComponent inDefComponent, string inSearch); // 0x0000000182157920-0x00000001821579E0
	[ChartSearch] // 0x0000000180254490-0x00000001802544C0
	public static bool AvailabilitySearch(DefComponent inDefComponent, string inSearch); // 0x00000001821579E0-0x0000000182157AB0
}

