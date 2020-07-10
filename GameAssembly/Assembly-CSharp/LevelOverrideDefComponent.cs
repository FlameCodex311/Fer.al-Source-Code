/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
[ChartComponent] // 0x000000018012D010-0x000000018012D040
public class LevelOverrideDefComponent : DefComponent // TypeDefIndex: 13342
{
	// Fields
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool isAdditive; // 0x18
	[ChartString] // 0x00000001800B5960-0x00000001800B5970
	public string unityLevelName; // 0x20
	[ChartString] // 0x00000001800B5960-0x00000001800B5970
	public string musicTrackID; // 0x28
	[ChartList] // 0x00000001800BF800-0x00000001800BF830
	[ChartString] // 0x00000001800BF800-0x00000001800BF830
	public List<string> calendarRefs; // 0x30
	[ChartDef] // 0x000000018012D720-0x000000018012D7A0
	[ChartList] // 0x000000018012D720-0x000000018012D7A0
	public ChartDefList networkedObjects; // 0x38
	[NonSerialized]
	public List<AvailabilityDefComponent> _calendarDefComponents; // 0x40

	// Properties
	public bool IsAvailable { get; } // 0x00000001812D0B40-0x00000001812D0C70 

	// Constructors
	public LevelOverrideDefComponent(); // 0x00000001812D0AE0-0x00000001812D0B40
}

