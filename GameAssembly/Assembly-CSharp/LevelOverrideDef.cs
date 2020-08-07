/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class LevelOverrideDef : BundledDef // TypeDefIndex: 11015
{
	// Fields
	public bool isAdditive; // 0x60
	public string unityLevelName; // 0x68
	public string musicTrackID; // 0x70
	public List<string> calendarRefs; // 0x78
	[NonSerialized]
	public List<AvailabilityDefComponent> _calendarDefs; // 0x80

	// Properties
	public bool IsAvailable { get; } // 0x0000000180C53A60-0x0000000180C53BA0 

	// Constructors
	public LevelOverrideDef(); // 0x0000000180C53A00-0x0000000180C53A60

	// Methods
	public override void LoadEntry(); // 0x0000000180C53960-0x0000000180C53A00
}

