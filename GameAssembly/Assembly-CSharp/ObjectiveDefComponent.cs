/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
[ChartComponent] // 0x0000000180168830-0x0000000180168860
public class ObjectiveDefComponent : DefComponent // TypeDefIndex: 10202
{
	// Fields
	[ChartDef] // 0x0000000180168A20-0x0000000180168AB0
	public string localizedTitleDefID; // 0x18
	private LocalizationDef _localizedTitleDef; // 0x20
	[ChartDef] // 0x0000000180168CE0-0x0000000180168D60
	[ChartList] // 0x0000000180168CE0-0x0000000180168D60
	public ChartDefList taskDefs; // 0x28
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool isFinalObjective; // 0x30

	// Properties
	public LocalizationDef LocalizedTitle { get; } // 0x0000000180E969E0-0x0000000180E96A90 

	// Constructors
	public ObjectiveDefComponent(); // 0x0000000180E96980-0x0000000180E969E0
}

