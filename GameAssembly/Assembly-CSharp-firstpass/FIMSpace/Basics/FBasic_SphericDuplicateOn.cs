/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FIMSpace.Basics
{
	public class FBasic_SphericDuplicateOn : UnityEngine.MonoBehaviour // TypeDefIndex: 9915
	{
		// Fields
		public int RowCount; // 0x18
		public float Radius; // 0x1C
		public LayerMask LayerMask; // 0x20
		public Vector2 fromRange; // 0x24
		public Vector2 toRange; // 0x2C
		[Range] // 0x00000001800C20E0-0x00000001800C2100
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
		public FBasic_SphericDuplicateOn(); // 0x00000001815D8FA0-0x00000001815D9090
	
		// Methods
		private void OnDrawGizmos(); // 0x00000001815D88E0-0x00000001815D8DA0
		private Vector3 RandomVectorSeed(float rangeA, float rangeB); // 0x00000001815D8EF0-0x00000001815D8FA0
		private float GetRandomRange(float rangeA, float rangeB); // 0x00000001815D8820-0x00000001815D88E0
		public void Duplicate(); // 0x00000001815D7BF0-0x00000001815D8820
		private void PurgeGenerated(); // 0x00000001815D8DA0-0x00000001815D8EF0
	}
}
