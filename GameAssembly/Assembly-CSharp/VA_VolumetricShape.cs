/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public abstract class VA_VolumetricShape : VA_Shape // TypeDefIndex: 13255
{
	// Fields
	[Tooltip] // 0x0000000180112490-0x00000001801124C0
	public bool IsHollow; // 0x38
	public bool InnerPointSet; // 0x39
	public Vector3 InnerPoint; // 0x3C
	public float InnerPointDistance; // 0x48
	public bool InnerPointInside; // 0x4C

	// Properties
	public override bool FinalPointSet { get; } // 0x0000000181132440-0x0000000181132450 
	public override Vector3 FinalPoint { get; } // 0x0000000181132450-0x0000000181132480 
	public override float FinalPointDistance { get; } // 0x0000000181132420-0x0000000181132440 

	// Constructors
	protected VA_VolumetricShape(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public void SetInnerPoint(Vector3 newInnerPoint, bool inside); // 0x0000000181132290-0x0000000181132420
	public void SetInnerOuterPoint(Vector3 newInnerOuterPoint, bool inside); // 0x0000000181132230-0x0000000181132290
	protected override void LateUpdate(); // 0x0000000181132220-0x0000000181132230
}

