/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FeralAudioMultiPathEmitter : ManagedBehaviour // TypeDefIndex: 13702
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
	public FeralAudioMultiPathEmitter(); // 0x00000001810FEE20-0x00000001810FEE90

	// Methods
	public override void MStart(); // 0x00000001810FE810-0x00000001810FE950
	public override void MUpdate(); // 0x00000001810FE950-0x00000001810FE990
	private void UpdateEmitterPosition(); // 0x00000001810FE990-0x00000001810FEE20
	private void DrawDebugPath(); // 0x00000001810FE600-0x00000001810FE810
}

