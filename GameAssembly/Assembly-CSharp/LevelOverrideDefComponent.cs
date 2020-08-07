/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
[ChartComponent] // 0x0000000180209270-0x00000001802092A0
public class LevelOverrideDefComponent : DefComponent // TypeDefIndex: 11013
{
	// Fields
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool isAdditive; // 0x18
	[ChartString] // 0x00000001801DE450-0x00000001801DE460
	public string unityLevelName; // 0x20
	[ChartString] // 0x00000001801DE450-0x00000001801DE460
	public string musicTrackID; // 0x28
	[ChartList] // 0x0000000180203CA0-0x0000000180203CD0
	[ChartString] // 0x0000000180203CA0-0x0000000180203CD0
	public List<string> calendarRefs; // 0x30
	[ChartDef] // 0x0000000180209B80-0x0000000180209C00
	[ChartList] // 0x0000000180209B80-0x0000000180209C00
	public ChartDefList networkedObjects; // 0x38
	[NonSerialized]
	public List<AvailabilityDefComponent> _calendarDefComponents; // 0x40

	// Properties
	public bool IsAvailable { get; } // 0x0000000180C53830-0x0000000180C53960 

	// Constructors
	public LevelOverrideDefComponent(); // 0x0000000180C537D0-0x0000000180C53830
}

