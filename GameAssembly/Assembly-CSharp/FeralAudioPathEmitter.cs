/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x00000001800F69C0-0x00000001800F6A40
[RequireComponent] // 0x00000001800F69C0-0x00000001800F6A40
public class FeralAudioPathEmitter : ManagedBehaviour // TypeDefIndex: 13705
{
	// Fields
	private BezierSpline _bezierSpline; // 0x50
	private FeralAudioEmitter _feralAudioEmitter; // 0x58
	private Vector3 _playerPosition; // 0x60
	public int updateInterval; // 0x6C
	public int pointCount; // 0x70
	public float threshold; // 0x74
	private int _updateCount; // 0x78
	private float _skipDistance; // 0x7C
	private Vector3 previousPlayerPos; // 0x80

	// Constructors
	public FeralAudioPathEmitter(); // 0x00000001810FF960-0x00000001810FF9D0

	// Methods
	public override void MStart(); // 0x00000001810FF320-0x00000001810FF6A0
	public override void MUpdate(); // 0x00000001810FF6A0-0x00000001810FF6E0
	private void UpdateEmitterPosition(); // 0x00000001810FF6E0-0x00000001810FF960
}

