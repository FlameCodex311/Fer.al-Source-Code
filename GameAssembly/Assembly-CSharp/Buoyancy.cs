/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RequireComponent] // 0x00000001800FC5D0-0x00000001800FC650
[RequireComponent] // 0x00000001800FC5D0-0x00000001800FC650
public class Buoyancy : ManagedBehaviour // TypeDefIndex: 13720
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3 _centerOfMass; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float density; // 0x5C
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int slicesPerAxis; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool isConcave; // 0x64
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int voxelsLimit; // 0x68
	private const float DAMPFER = 0.1f; // Metadata: 0x00783FF4
	private const float WATER_DENSITY = 1000f; // Metadata: 0x00783FF8
	private float voxelHalfHeight; // 0x6C
	private Vector3 localArchimedesForce; // 0x70
	private List<Vector3> voxels; // 0x80
	private bool isMeshCollider; // 0x88
	private List<Vector3[]> forces; // 0x90
	private Collider _collider; // 0x98
	private Rigidbody _rigidbody; // 0xA0

	// Constructors
	public Buoyancy(); // 0x0000000181020120-0x00000001810201C0

	// Methods
	public override void MStart(); // 0x000000018101E1E0-0x000000018101EA80
	private List<Vector3> SliceIntoVoxels(bool concave); // 0x000000018101F600-0x000000018101FCA0
	private static bool PointIsInsideMeshCollider(Collider c, Vector3 p); // 0x000000018101F250-0x000000018101F600
	private static void FindClosestPoints(IList<Vector3> list, out int firstIndex, out int secondIndex); // 0x000000018101DAC0-0x000000018101DC90
	private static void WeldPoints(IList<Vector3> list, int targetCount); // 0x000000018101FCA0-0x0000000181020120
	private float GetWaterLevel(float x, float z); // 0x000000018101E1D0-0x000000018101E1E0
	private void FixedUpdate(); // 0x000000018101DC90-0x000000018101E1D0
	private void OnDrawGizmos(); // 0x000000018101EA80-0x000000018101F250
}

