/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public abstract class VA_VolumetricShape : VA_Shape // TypeDefIndex: 10921
{
	// Fields
	[Tooltip] // 0x00000001801EBF50-0x00000001801EBF80
	public bool IsHollow; // 0x38
	public bool InnerPointSet; // 0x39
	public Vector3 InnerPoint; // 0x3C
	public float InnerPointDistance; // 0x48
	public bool InnerPointInside; // 0x4C

	// Properties
	public override bool FinalPointSet { get; } // 0x00000001806763D0-0x00000001806763E0 
	public override Vector3 FinalPoint { get; } // 0x00000001806763E0-0x0000000180676410 
	public override float FinalPointDistance { get; } // 0x00000001806763B0-0x00000001806763D0 

	// Constructors
	protected VA_VolumetricShape(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void SetInnerPoint(Vector3 newInnerPoint, bool inside); // 0x0000000180676230-0x00000001806763B0
	public void SetInnerOuterPoint(Vector3 newInnerOuterPoint, bool inside); // 0x00000001806761D0-0x0000000180676230
	protected override void LateUpdate(); // 0x00000001806761C0-0x00000001806761D0
}

