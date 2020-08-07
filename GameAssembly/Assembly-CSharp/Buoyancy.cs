/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RequireComponent] // 0x00000001801D36A0-0x00000001801D3720
[RequireComponent] // 0x00000001801D36A0-0x00000001801D3720
public class Buoyancy : ManagedBehaviour // TypeDefIndex: 11393
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3 _centerOfMass; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float density; // 0x5C
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int slicesPerAxis; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool isConcave; // 0x64
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int voxelsLimit; // 0x68
	private const float DAMPFER = 0.1f; // Metadata: 0x0077CAB3
	private const float WATER_DENSITY = 1000f; // Metadata: 0x0077CAB7
	private float voxelHalfHeight; // 0x6C
	private Vector3 localArchimedesForce; // 0x70
	private List<Vector3> voxels; // 0x80
	private bool isMeshCollider; // 0x88
	private List<Vector3[]> forces; // 0x90
	private Collider _collider; // 0x98
	private Rigidbody _rigidbody; // 0xA0

	// Constructors
	public Buoyancy(); // 0x0000000180498900-0x00000001804989A0

	// Methods
	public override void MStart(); // 0x0000000180496A30-0x00000001804972A0
	private List<Vector3> SliceIntoVoxels(bool concave); // 0x0000000180497DF0-0x0000000180498480
	private static bool PointIsInsideMeshCollider(Collider c, Vector3 p); // 0x0000000180497A50-0x0000000180497DF0
	private static void FindClosestPoints(IList<Vector3> list, out int firstIndex, out int secondIndex); // 0x0000000180496320-0x00000001804964F0
	private static void WeldPoints(IList<Vector3> list, int targetCount); // 0x0000000180498480-0x0000000180498900
	private float GetWaterLevel(float x, float z); // 0x0000000180496A20-0x0000000180496A30
	private void FixedUpdate(); // 0x00000001804964F0-0x0000000180496A20
	private void OnDrawGizmos(); // 0x00000001804972A0-0x0000000180497A50
}

