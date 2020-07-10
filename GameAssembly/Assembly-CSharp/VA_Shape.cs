/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public abstract class VA_Shape : MonoBehaviour // TypeDefIndex: 13253
{
	// Fields
	public bool OuterPointSet; // 0x20
	public Vector3 OuterPoint; // 0x24
	public float OuterPointDistance; // 0x30

	// Properties
	public virtual bool FinalPointSet { get; } // 0x00000001803C19E0-0x00000001803C19F0 
	public virtual Vector3 FinalPoint { get; } // 0x00000001807A1520-0x00000001807A1540 
	public virtual float FinalPointDistance { get; } // 0x0000000180485990-0x00000001804859A0 

	// Constructors
	protected VA_Shape(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public void SetOuterPoint(Vector3 newOuterPoint); // 0x0000000181131480-0x00000001811315F0
	protected virtual void LateUpdate(); // 0x000000018059D270-0x000000018059D280
}

