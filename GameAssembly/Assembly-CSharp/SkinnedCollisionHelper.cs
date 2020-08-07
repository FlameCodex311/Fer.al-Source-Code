/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SkinnedCollisionHelper : MonoBehaviour // TypeDefIndex: 13425
{
	// Fields
	public bool forceUpdate; // 0x20
	public bool updateOncePerFrame; // 0x21
	private CWeightList[] nodeWeights; // 0x28
	private SkinnedMeshRenderer skinnedMeshRenderer; // 0x30
	private MeshCollider meshCollider; // 0x38

	// Nested types
	private class CVertexWeight // TypeDefIndex: 13426
	{
		// Fields
		public int index; // 0x10
		public Vector3 localPosition; // 0x14
		public float weight; // 0x20

		// Constructors
		public CVertexWeight(int i, Vector3 p, float w); // 0x0000000180763700-0x0000000180763760
	}

	private class CWeightList // TypeDefIndex: 13427
	{
		// Fields
		public Transform transform; // 0x10
		public ArrayList weights; // 0x18

		// Constructors
		public CWeightList(); // 0x0000000180763760-0x00000001807637C0
	}

	// Constructors
	public SkinnedCollisionHelper(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x000000018076F2E0-0x000000018076FD70
	public void UpdateCollisionMesh(); // 0x000000018076FD70-0x00000001807703C0
	private void Update(); // 0x00000001807703C0-0x00000001807703E0
}

