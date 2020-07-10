/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class QuestDefTask // TypeDefIndex: 10149
{
	// Fields
	[ChartDef] // 0x00000001801618D0-0x0000000180161940
	public string imageDefId; // 0x10
	private ImageDefComponent _imageDef; // 0x18
	[ChartDef] // 0x0000000180161C40-0x0000000180161CD0
	public string localizedDescriptionDefID; // 0x20
	private LocalizationDef _localizedDescriptionDef; // 0x28
	[ChartInt] // 0x00000001800B5960-0x00000001800B5970
	public int targetProgress; // 0x30
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool showProgressText; // 0x34

	// Properties
	public ImageDefComponent Image { get; } // 0x0000000181005A60-0x0000000181005B00 
	public LocalizationDef LocalizedDescription { get; } // 0x0000000181005B00-0x0000000181005BB0 

	// Constructors
	public QuestDefTask(); // 0x0000000181005A50-0x0000000181005A60
}

