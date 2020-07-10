/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class ActorInfoDecalEntry // TypeDefIndex: 10884
{
	// Fields
	[ChartDef] // 0x00000001800EE220-0x00000001800EE320
	[RootSelector] // 0x00000001800EE220-0x00000001800EE320
	public string defID; // 0x10
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool isDefault; // 0x18
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool disabled; // 0x19
	public Action<bool> OnDecalVisibilityChanged; // 0x20
	[ChartVector2] // 0x00000001800B5960-0x00000001800B5970
	public StringSerializableVector2 position; // 0x28
	[ChartVector2] // 0x00000001800B5960-0x00000001800B5970
	public StringSerializableVector2 mirroredPosition; // 0x30
	[ChartHSV] // 0x00000001800B5960-0x00000001800B5970
	public HSVColor color1HSV; // 0x38
	[ChartString] // 0x00000001800B5960-0x00000001800B5970
	public string rotation; // 0x70
	[ChartString] // 0x00000001800B5960-0x00000001800B5970
	public string rotationCompensation; // 0x78
	[ChartString] // 0x00000001800B5960-0x00000001800B5970
	public string mirrorRotationCompensation; // 0x80
	[ChartString] // 0x00000001800B5960-0x00000001800B5970
	public string scale; // 0x88
	[NonSerialized]
	public float alpha; // 0x90
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool flipX; // 0x94
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool flipY; // 0x95
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool mirror; // 0x96

	// Properties
	public float Rotation { get; set; } // 0x00000001814070E0-0x00000001814070F0 0x0000000181407140-0x0000000181407160
	public float RotationCompensation { get; set; } // 0x00000001814070D0-0x00000001814070E0 0x0000000181407120-0x0000000181407140
	public float MirrorRotationCompensation { get; set; } // 0x00000001814070C0-0x00000001814070D0 0x0000000181407100-0x0000000181407120
	public float Scale { get; set; } // 0x00000001814070F0-0x0000000181407100 0x0000000181407160-0x0000000181407180
	public bool IsEye { get; } // 0x0000000181407080-0x00000001814070C0 

	// Constructors
	public ActorInfoDecalEntry(); // 0x0000000181406F50-0x0000000181407080
}

