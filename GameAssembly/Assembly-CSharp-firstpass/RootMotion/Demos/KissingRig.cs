/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	public class KissingRig : UnityEngine.MonoBehaviour // TypeDefIndex: 9813
	{
		// Fields
		public Partner partner1; // 0x18
		public Partner partner2; // 0x20
		public float weight; // 0x28
		public int iterations; // 0x2C
	
		// Nested types
		[Serializable]
		public class Partner // TypeDefIndex: 9814
		{
			// Fields
			public FullBodyBipedIK ik; // 0x10
			public Transform mouth; // 0x18
			public Transform mouthTarget; // 0x20
			public Transform touchTargetLeftHand; // 0x28
			public Transform touchTargetRightHand; // 0x30
			public float bodyWeightHorizontal; // 0x38
			public float bodyWeightVertical; // 0x3C
			public float neckRotationWeight; // 0x40
			public float headTiltAngle; // 0x44
			public Vector3 headTiltAxis; // 0x48
			private Quaternion neckRotation; // 0x54
	
			// Properties
			private Transform neck { get; } // 0x000000018137F1F0-0x000000018137F2A0 
	
			// Constructors
			public Partner(); // 0x000000018137F1C0-0x000000018137F1F0
	
			// Methods
			public void Initiate(); // 0x000000018137E430-0x000000018137E460
			public void Update(float weight); // 0x000000018137E6D0-0x000000018137F1C0
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight); // 0x000000018137E460-0x000000018137E6D0
		}
	
		// Constructors
		public KissingRig(); // 0x00000001813799D0-0x00000001813799E0
	
		// Methods
		private void Start(); // 0x0000000181379970-0x00000001813799D0
		private void LateUpdate(); // 0x0000000181379910-0x0000000181379970
	}
}
