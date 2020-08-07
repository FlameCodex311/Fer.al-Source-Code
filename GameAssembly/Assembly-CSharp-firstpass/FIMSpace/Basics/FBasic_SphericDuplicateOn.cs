/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FIMSpace.Basics
{
	public class FBasic_SphericDuplicateOn : UnityEngine.MonoBehaviour // TypeDefIndex: 10369
	{
		// Fields
		public int RowCount; // 0x18
		public float Radius; // 0x1C
		public LayerMask LayerMask; // 0x20
		public Vector2 fromRange; // 0x24
		public Vector2 toRange; // 0x2C
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float Randomize; // 0x34
		public int Seed; // 0x38
		private System.Random randomSeed; // 0x40
		public GameObject ToDuplicate; // 0x48
		public Vector3 RotationOffset; // 0x50
		public Vector3 RandomRotationLocalAxis; // 0x5C
		public Vector2 RandomRotationRange; // 0x68
		public Transform AttachTo; // 0x70
		public Transform AttachToNearestTransformOf; // 0x78
		public List<GameObject> Generated; // 0x80
	
		// Constructors
		public FBasic_SphericDuplicateOn(); // 0x0000000181082B20-0x0000000181082C10
	
		// Methods
		private void OnDrawGizmos(); // 0x0000000181082470-0x0000000181082920
		private Vector3 RandomVectorSeed(float rangeA, float rangeB); // 0x0000000181082A70-0x0000000181082B20
		private float GetRandomRange(float rangeA, float rangeB); // 0x00000001810823B0-0x0000000181082470
		public void Duplicate(); // 0x00000001810817B0-0x00000001810823B0
		private void PurgeGenerated(); // 0x0000000181082920-0x0000000181082A70
	}
}
