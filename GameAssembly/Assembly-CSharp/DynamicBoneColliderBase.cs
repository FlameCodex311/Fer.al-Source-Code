/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class DynamicBoneColliderBase : MonoBehaviour // TypeDefIndex: 11466
{
	// Fields
	[Tooltip] // 0x00000001801EF070-0x00000001801EF0A0
	public Direction m_Direction; // 0x20
	[Tooltip] // 0x00000001801EF1E0-0x00000001801EF210
	public Vector3 m_Center; // 0x24
	[Tooltip] // 0x00000001801EF410-0x00000001801EF440
	public Bound m_Bound; // 0x30

	// Nested types
	public enum Direction // TypeDefIndex: 11467
	{
		X = 0,
		Y = 1,
		Z = 2
	}

	public enum Bound // TypeDefIndex: 11468
	{
		Outside = 0,
		Inside = 1
	}

	// Constructors
	public DynamicBoneColliderBase(); // 0x0000000180856860-0x00000001808568E0

	// Methods
	public virtual bool Collide(ref Vector3 particlePosition, float particleRadius); // 0x0000000180380950-0x0000000180380960
}

