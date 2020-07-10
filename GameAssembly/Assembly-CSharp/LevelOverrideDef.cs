/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class LevelOverrideDef : BundledDef // TypeDefIndex: 13344
{
	// Fields
	public bool isAdditive; // 0x60
	public string unityLevelName; // 0x68
	public string musicTrackID; // 0x70
	public List<string> calendarRefs; // 0x78
	[NonSerialized]
	public List<AvailabilityDefComponent> _calendarDefs; // 0x80

	// Properties
	public bool IsAvailable { get; } // 0x00000001812D0D70-0x00000001812D0EC0 

	// Constructors
	public LevelOverrideDef(); // 0x00000001812D0D10-0x00000001812D0D70

	// Methods
	public override void LoadEntry(); // 0x00000001812D0C70-0x00000001812D0D10
}

