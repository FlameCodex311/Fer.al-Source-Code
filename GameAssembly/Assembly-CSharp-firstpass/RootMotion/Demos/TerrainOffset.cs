/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	public class TerrainOffset : UnityEngine.MonoBehaviour // TypeDefIndex: 9498
	{
		// Fields
		public AimIK aimIK; // 0x18
		public Vector3 raycastOffset; // 0x20
		public LayerMask raycastLayers; // 0x2C
		public float min; // 0x30
		public float max; // 0x34
		public float lerpSpeed; // 0x38
		private RaycastHit hit; // 0x3C
		private Vector3 offset; // 0x68
	
		// Constructors
		public TerrainOffset(); // 0x000000018183D880-0x000000018183D8F0
	
		// Methods
		private void LateUpdate(); // 0x000000018183D550-0x000000018183D880
		private Vector3 GetGroundHeightOffset(Vector3 worldPosition); // 0x000000018183D280-0x000000018183D550
	}
}
