/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public abstract class VA_Shape : MonoBehaviour // TypeDefIndex: 10919
{
	// Fields
	public bool OuterPointSet; // 0x20
	public Vector3 OuterPoint; // 0x24
	public float OuterPointDistance; // 0x30

	// Properties
	public virtual bool FinalPointSet { get; } // 0x00000001803FA090-0x00000001803FA0A0 
	public virtual Vector3 FinalPoint { get; } // 0x00000001806757C0-0x00000001806757E0 
	public virtual float FinalPointDistance { get; } // 0x00000001806757B0-0x00000001806757C0 

	// Constructors
	protected VA_Shape(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void SetOuterPoint(Vector3 newOuterPoint); // 0x0000000180675640-0x00000001806757B0
	protected virtual void LateUpdate(); // 0x0000000180499260-0x0000000180499270
}

