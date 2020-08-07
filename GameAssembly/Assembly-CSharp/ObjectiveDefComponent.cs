/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
[ChartComponent] // 0x000000018023EA80-0x000000018023EAB0
public class ObjectiveDefComponent : DefComponent // TypeDefIndex: 11693
{
	// Fields
	[ChartDef] // 0x000000018023ED80-0x000000018023EE10
	public string localizedTitleDefID; // 0x18
	private LocalizationDef _localizedTitleDef; // 0x20
	[ChartDef] // 0x000000018023F050-0x000000018023F0D0
	[ChartList] // 0x000000018023F050-0x000000018023F0D0
	public ChartDefList taskDefs; // 0x28
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool isFinalObjective; // 0x30

	// Properties
	public LocalizationDef LocalizedTitle { get; } // 0x0000000180804A20-0x0000000180804AD0 

	// Constructors
	public ObjectiveDefComponent(); // 0x00000001808049C0-0x0000000180804A20
}

