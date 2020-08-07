/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
[ChartComponent] // 0x0000000180245F50-0x0000000180245F80
public class TaskDefComponent : DefComponent // TypeDefIndex: 11714
{
	// Fields
	[ChartDef] // 0x00000001802460B0-0x0000000180246120
	public string imageDefId; // 0x18
	private ImageDefComponent _imageDef; // 0x20
	[ChartDef] // 0x00000001802463A0-0x0000000180246430
	public string localizedDescriptionDefID; // 0x28
	private LocalizationDef _localizedDescriptionDef; // 0x30
	[ChartInt] // 0x00000001801DE450-0x00000001801DE460
	public int targetProgress; // 0x38
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool showProgressText; // 0x3C

	// Properties
	public ImageDefComponent Image { get; } // 0x00000001809596A0-0x0000000180959720 
	public LocalizationDef LocalizedDescription { get; } // 0x0000000180959720-0x00000001809597D0 

	// Constructors
	public TaskDefComponent(); // 0x00000001803FB1F0-0x00000001803FB200
}

