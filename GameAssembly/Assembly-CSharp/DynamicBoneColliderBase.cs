/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class DynamicBoneColliderBase : MonoBehaviour // TypeDefIndex: 13793
{
	// Fields
	[Tooltip] // 0x0000000180111B70-0x0000000180111BA0
	public Direction m_Direction; // 0x20
	[Tooltip] // 0x0000000180111D20-0x0000000180111D50
	public Vector3 m_Center; // 0x24
	[Tooltip] // 0x0000000180111FA0-0x0000000180111FD0
	public Bound m_Bound; // 0x30

	// Nested types
	public enum Direction // TypeDefIndex: 13794
	{
		X = 0,
		Y = 1,
		Z = 2
	}

	public enum Bound // TypeDefIndex: 13795
	{
		Outside = 0,
		Inside = 1
	}

	// Constructors
	public DynamicBoneColliderBase(); // 0x0000000181189B80-0x0000000181189C00

	// Methods
	public virtual bool Collide(ref Vector3 particlePosition, float particleRadius); // 0x00000001803C28F0-0x00000001803C2900
}

