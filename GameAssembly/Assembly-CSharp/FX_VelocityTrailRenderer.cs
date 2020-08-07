/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FX_VelocityTrailRenderer : ManagedBehaviour // TypeDefIndex: 11924
{
	// Fields
	public float minSpeedTime; // 0x50
	public float maxSpeedTime; // 0x54
	private bool _checkedCachedTrailRenderers; // 0x58
	private List<TrailRenderer> _cachedTrailRenderers; // 0x60
	private bool _checkedCachedParentActor; // 0x68
	private ActorBase _cachedParentActor; // 0x70

	// Properties
	private List<TrailRenderer> CachedTrailRenderers { get; } // 0x0000000180864ED0-0x0000000180864F20 
	private ActorBase CachedParentActor { get; } // 0x0000000180864E80-0x0000000180864ED0 

	// Constructors
	public FX_VelocityTrailRenderer(); // 0x0000000180864DF0-0x0000000180864E80

	// Methods
	public override void MStart(); // 0x00000001808649C0-0x0000000180864B60
	public override void MUpdate(); // 0x0000000180864B60-0x0000000180864DF0
}

