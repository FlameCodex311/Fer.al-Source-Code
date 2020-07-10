/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.FinalIK
{
	public class LookAtController : UnityEngine.MonoBehaviour // TypeDefIndex: 9474
	{
		// Fields
		public LookAtIK ik; // 0x18
		[Header] // 0x00000001800C1F30-0x00000001800C1F90
		[Tooltip] // 0x00000001800C1F30-0x00000001800C1F90
		public Transform target; // 0x20
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float weight; // 0x28
		public Vector3 offset; // 0x2C
		[Tooltip] // 0x00000001800C2150-0x00000001800C2180
		public float targetSwitchSmoothTime; // 0x38
		[Tooltip] // 0x00000001800C2250-0x00000001800C2280
		public float weightSmoothTime; // 0x3C
		[Header] // 0x00000001800B3770-0x00000001800B37D0
		[Tooltip] // 0x00000001800B3770-0x00000001800B37D0
		public bool smoothTurnTowardsTarget; // 0x40
		[Tooltip] // 0x00000001800B3C40-0x00000001800B3C70
		public float maxRadiansDelta; // 0x44
		[Tooltip] // 0x00000001800B3E20-0x00000001800B3E50
		public float maxMagnitudeDelta; // 0x48
		[Tooltip] // 0x00000001800B3FF0-0x00000001800B4020
		public float slerpSpeed; // 0x4C
		[Tooltip] // 0x00000001800C2670-0x00000001800C26A0
		public Vector3 pivotOffsetFromRoot; // 0x50
		[Tooltip] // 0x00000001800C2880-0x00000001800C28B0
		public float minDistance; // 0x5C
		[Header] // 0x00000001800C29D0-0x00000001800C2A50
		[Range] // 0x00000001800C29D0-0x00000001800C2A50
		[Tooltip] // 0x00000001800C29D0-0x00000001800C2A50
		public float maxRootAngle; // 0x60
		private Transform lastTarget; // 0x68
		private float switchWeight; // 0x70
		private float switchWeightV; // 0x74
		private float weightV; // 0x78
		private Vector3 lastPosition; // 0x7C
		private Vector3 dir; // 0x88
		private bool lastSmoothTowardsTarget; // 0x94
	
		// Properties
		private Vector3 pivot { get; } // 0x0000000181B09AC0-0x0000000181B09C60 
	
		// Constructors
		public LookAtController(); // 0x0000000181B09A10-0x0000000181B09AC0
	
		// Methods
		private void Start(); // 0x0000000181B098D0-0x0000000181B09A10
		private void LateUpdate(); // 0x0000000181B08A10-0x0000000181B09510
		private void ApplyMinDistance(); // 0x0000000181B087F0-0x0000000181B08A10
		private void RootRotation(); // 0x0000000181B09510-0x0000000181B098D0
	}
}
