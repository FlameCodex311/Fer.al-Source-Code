/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class QuestDefTask // TypeDefIndex: 11640
{
	// Fields
	[ChartDef] // 0x0000000180238BD0-0x0000000180238C40
	public string imageDefId; // 0x10
	private ImageDefComponent _imageDef; // 0x18
	[ChartDef] // 0x0000000180239160-0x00000001802391F0
	public string localizedDescriptionDefID; // 0x20
	private LocalizationDef _localizedDescriptionDef; // 0x28
	[ChartInt] // 0x00000001801DE450-0x00000001801DE460
	public int targetProgress; // 0x30
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool showProgressText; // 0x34

	// Properties
	public ImageDefComponent Image { get; } // 0x00000001806496E0-0x0000000180649780 
	public LocalizationDef LocalizedDescription { get; } // 0x0000000180649780-0x0000000180649830 

	// Constructors
	public QuestDefTask(); // 0x00000001806496D0-0x00000001806496E0
}

