/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BezierCurve : ManagedBehaviour // TypeDefIndex: 13712
{
	// Fields
	public Vector3[] points; // 0x50

	// Constructors
	public BezierCurve(); // 0x0000000181045280-0x00000001810452E0

	// Methods
	public Vector3 GetPoint(float t); // 0x0000000181044C80-0x0000000181044E50
	public Vector3 GetVelocity(float t); // 0x0000000181044E50-0x00000001810450B0
	public Vector3 GetDirection(float t); // 0x0000000181044C20-0x0000000181044C80
	public void Reset(); // 0x00000001810450B0-0x0000000181045280
}

