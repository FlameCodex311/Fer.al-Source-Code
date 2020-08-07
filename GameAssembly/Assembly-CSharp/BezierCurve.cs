/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class BezierCurve : ManagedBehaviour // TypeDefIndex: 11385
{
	// Fields
	public Vector3[] points; // 0x50

	// Constructors
	public BezierCurve(); // 0x000000018212C5B0-0x000000018212C610

	// Methods
	public Vector3 GetPoint(float t); // 0x000000018212BFE0-0x000000018212C1A0
	public Vector3 GetVelocity(float t); // 0x000000018212C1A0-0x000000018212C3F0
	public Vector3 GetDirection(float t); // 0x000000018212BF80-0x000000018212BFE0
	public void Reset(); // 0x000000018212C3F0-0x000000018212C5B0
}

