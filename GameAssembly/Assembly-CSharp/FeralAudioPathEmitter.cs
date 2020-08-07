/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x00000001801CE270-0x00000001801CE2F0
[RequireComponent] // 0x00000001801CE270-0x00000001801CE2F0
public class FeralAudioPathEmitter : ManagedBehaviour // TypeDefIndex: 11377
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
	public FeralAudioPathEmitter(); // 0x00000001806950F0-0x0000000180695160

	// Methods
	public override void MStart(); // 0x0000000180694AD0-0x0000000180694E30
	public override void MUpdate(); // 0x0000000180694E30-0x0000000180694E70
	private void UpdateEmitterPosition(); // 0x0000000180694E70-0x00000001806950F0
}

