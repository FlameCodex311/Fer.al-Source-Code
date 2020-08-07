/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class ActorInfoDecalEntry // TypeDefIndex: 12407
{
	// Fields
	[ChartDef] // 0x000000018028FBA0-0x000000018028FCA0
	[RootSelector] // 0x000000018028FBA0-0x000000018028FCA0
	public string defID; // 0x10
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool isDefault; // 0x18
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool disabled; // 0x19
	public Action<bool> OnDecalVisibilityChanged; // 0x20
	[ChartVector2] // 0x00000001801DE450-0x00000001801DE460
	public StringSerializableVector2 position; // 0x28
	[ChartVector2] // 0x00000001801DE450-0x00000001801DE460
	public StringSerializableVector2 mirroredPosition; // 0x30
	[ChartHSV] // 0x00000001801DE450-0x00000001801DE460
	public HSVColor color1HSV; // 0x38
	[ChartString] // 0x00000001801DE450-0x00000001801DE460
	public string rotation; // 0x70
	[ChartString] // 0x00000001801DE450-0x00000001801DE460
	public string rotationCompensation; // 0x78
	[ChartString] // 0x00000001801DE450-0x00000001801DE460
	public string mirrorRotationCompensation; // 0x80
	[ChartString] // 0x00000001801DE450-0x00000001801DE460
	public string scale; // 0x88
	[NonSerialized]
	public float alpha; // 0x90
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool flipX; // 0x94
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool flipY; // 0x95
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool mirror; // 0x96

	// Properties
	public float Rotation { get; set; } // 0x00000001821D8DF0-0x00000001821D8E00 0x00000001821D8E50-0x00000001821D8E70
	public float RotationCompensation { get; set; } // 0x00000001821D8DE0-0x00000001821D8DF0 0x00000001821D8E30-0x00000001821D8E50
	public float MirrorRotationCompensation { get; set; } // 0x00000001821D8DD0-0x00000001821D8DE0 0x00000001821D8E10-0x00000001821D8E30
	public float Scale { get; set; } // 0x00000001821D8E00-0x00000001821D8E10 0x00000001821D8E70-0x00000001821D8E90
	public bool IsEye { get; } // 0x00000001821D8D90-0x00000001821D8DD0 

	// Constructors
	public ActorInfoDecalEntry(); // 0x00000001821D8C60-0x00000001821D8D90
}

