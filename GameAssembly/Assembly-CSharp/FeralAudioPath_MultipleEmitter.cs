/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RequireComponent] // 0x00000001801CE650-0x00000001801CE6A0
public class FeralAudioPath_MultipleEmitter : ManagedBehaviour // TypeDefIndex: 11378
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
	public FeralAudioPath_MultipleEmitter(); // 0x00000001806958A0-0x0000000180695920

	// Methods
	public override void MStart(); // 0x0000000180695160-0x0000000180695310
	public override void MUpdate(); // 0x0000000180695310-0x0000000180695360
	private void UpdateEmitterPosition(); // 0x0000000180695360-0x00000001806958A0
}

