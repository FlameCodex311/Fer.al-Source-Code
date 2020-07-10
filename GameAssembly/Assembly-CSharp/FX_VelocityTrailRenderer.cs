/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FX_VelocityTrailRenderer : ManagedBehaviour // TypeDefIndex: 10447
{
	// Fields
	public float minSpeedTime; // 0x50
	public float maxSpeedTime; // 0x54
	private bool _checkedCachedTrailRenderers; // 0x58
	private List<TrailRenderer> _cachedTrailRenderers; // 0x60
	private bool _checkedCachedParentActor; // 0x68
	private ActorBase _cachedParentActor; // 0x70

	// Properties
	private List<TrailRenderer> CachedTrailRenderers { get; } // 0x0000000181197C20-0x0000000181197C70 
	private ActorBase CachedParentActor { get; } // 0x0000000181197BD0-0x0000000181197C20 

	// Constructors
	public FX_VelocityTrailRenderer(); // 0x0000000181197B40-0x0000000181197BD0

	// Methods
	public override void MStart(); // 0x0000000181197700-0x00000001811978A0
	public override void MUpdate(); // 0x00000001811978A0-0x0000000181197B40
}

