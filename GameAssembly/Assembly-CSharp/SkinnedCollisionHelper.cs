/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SkinnedCollisionHelper : MonoBehaviour // TypeDefIndex: 11889
{
	// Fields
	public bool forceUpdate; // 0x20
	public bool updateOncePerFrame; // 0x21
	private CWeightList[] nodeWeights; // 0x28
	private SkinnedMeshRenderer skinnedMeshRenderer; // 0x30
	private MeshCollider meshCollider; // 0x38

	// Nested types
	private class CVertexWeight // TypeDefIndex: 11890
	{
		// Fields
		public int index; // 0x10
		public Vector3 localPosition; // 0x14
		public float weight; // 0x20

		// Constructors
		public CVertexWeight(int i, Vector3 p, float w); // 0x0000000181348A70-0x0000000181348AD0
	}

	private class CWeightList // TypeDefIndex: 11891
	{
		// Fields
		public Transform transform; // 0x10
		public ArrayList weights; // 0x18

		// Constructors
		public CWeightList(); // 0x0000000181348AD0-0x0000000181348B30
	}

	// Constructors
	public SkinnedCollisionHelper(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x00000001813587D0-0x00000001813592D0
	public void UpdateCollisionMesh(); // 0x00000001813592D0-0x0000000181359950
	private void Update(); // 0x0000000181359950-0x0000000181359970
}

