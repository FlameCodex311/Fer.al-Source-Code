/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RequireComponent] // 0x00000001800F6770-0x00000001800F67C0
public class FeralAudioPath_MultipleEmitter : ManagedBehaviour // TypeDefIndex: 13704
{
	// Fields
	private BezierSpline spline; // 0x50
	private FeralAudioEmitter emitter; // 0x58
	private Vector3 playerPosition; // 0x60
	private List<FeralAudioEmitter> secondaryEmitters; // 0x70
	public int secondaryEmitterCount; // 0x78
	public float emitterGap; // 0x7C
	public int updateInterval; // 0x80
	public int pointCount; // 0x84
	public float threshold; // 0x88
	private int updateCount; // 0x8C
	private float skipDistance; // 0x90
	private Vector3 previousPlayerPos; // 0x94

	// Constructors
	public FeralAudioPath_MultipleEmitter(); // 0x0000000181100130-0x00000001811001B0

	// Methods
	public override void MStart(); // 0x00000001810FF9D0-0x00000001810FFB80
	public override void MUpdate(); // 0x00000001810FFB80-0x00000001810FFBD0
	private void UpdateEmitterPosition(); // 0x00000001810FFBD0-0x0000000181100130
}

