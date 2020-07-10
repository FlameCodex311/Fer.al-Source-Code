/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
[ChartComponent] // 0x0000000180171AD0-0x0000000180171B00
public class TaskDefComponent : DefComponent // TypeDefIndex: 10223
{
	// Fields
	[ChartDef] // 0x0000000180171D50-0x0000000180171DC0
	public string imageDefId; // 0x18
	private ImageDefComponent _imageDef; // 0x20
	[ChartDef] // 0x00000001801733A0-0x0000000180173430
	public string localizedDescriptionDefID; // 0x28
	private LocalizationDef _localizedDescriptionDef; // 0x30
	[ChartInt] // 0x00000001800B5960-0x00000001800B5970
	public int targetProgress; // 0x38
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool showProgressText; // 0x3C

	// Properties
	public ImageDefComponent Image { get; } // 0x0000000181209480-0x0000000181209500 
	public LocalizationDef LocalizedDescription { get; } // 0x0000000181209500-0x00000001812095B0 

	// Constructors
	public TaskDefComponent(); // 0x0000000180363710-0x0000000180363720
}

