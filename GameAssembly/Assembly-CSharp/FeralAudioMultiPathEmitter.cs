/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FeralAudioMultiPathEmitter : ManagedBehaviour // TypeDefIndex: 11375
{
	// Fields
	private BezierSpline[] splines; // 0x50
	private FeralAudioEmitter emitter; // 0x58
	private Vector3 playerPosition; // 0x60
	public int updateInterval; // 0x6C
	public int pointCount; // 0x70
	public float threshold; // 0x74
	private int updateCount; // 0x78
	private float skipDistance; // 0x7C
	public bool DebugPath; // 0x80
	public GameObject DebugPathMarkerPrefab; // 0x88
	public GameObject DebugEmitterMarkerPrefab; // 0x90
	private GameObject DebugEmitterMarker; // 0x98
	private Vector3 previousPlayerPos; // 0xA0

	// Constructors
	public FeralAudioMultiPathEmitter(); // 0x00000001806945D0-0x0000000180694640

	// Methods
	public override void MStart(); // 0x0000000180693FD0-0x0000000180694110
	public override void MUpdate(); // 0x0000000180694110-0x0000000180694150
	private void UpdateEmitterPosition(); // 0x0000000180694150-0x00000001806945D0
	private void DrawDebugPath(); // 0x0000000180693DD0-0x0000000180693FD0
}

