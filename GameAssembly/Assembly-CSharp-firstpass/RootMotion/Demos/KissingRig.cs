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
	public class KissingRig : UnityEngine.MonoBehaviour // TypeDefIndex: 9526
	{
		// Fields
		public Partner partner1; // 0x18
		public Partner partner2; // 0x20
		public float weight; // 0x28
		public int iterations; // 0x2C
	
		// Nested types
		[Serializable]
		public class Partner // TypeDefIndex: 9527
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
			private Transform neck { get; } // 0x0000000181838930-0x00000001818389F0 
	
			// Constructors
			public Partner(); // 0x0000000181838900-0x0000000181838930
	
			// Methods
			public void Initiate(); // 0x0000000181823D40-0x0000000181823D70
			public void Update(float weight); // 0x0000000181837DB0-0x0000000181838900
			private void InverseTransformEffector(FullBodyBipedEffector effector, Transform target, Vector3 targetPosition, float weight); // 0x0000000181837B30-0x0000000181837DB0
		}
	
		// Constructors
		public KissingRig(); // 0x0000000181832FC0-0x0000000181832FD0
	
		// Methods
		private void Start(); // 0x0000000181832F60-0x0000000181832FC0
		private void LateUpdate(); // 0x0000000181832F00-0x0000000181832F60
	}
}
