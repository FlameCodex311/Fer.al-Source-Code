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
	public class Recoil : OffsetModifier // TypeDefIndex: 9485
	{
		// Fields
		[Tooltip] // 0x00000001800C8F30-0x00000001800C8F60
		public AimIK aimIK; // 0x30
		[Tooltip] // 0x00000001800C9140-0x00000001800C9170
		public bool aimIKSolvedLast; // 0x38
		[Tooltip] // 0x00000001800C9360-0x00000001800C9390
		public Handedness handedness; // 0x3C
		[Tooltip] // 0x00000001800C9610-0x00000001800C9640
		public bool twoHanded; // 0x40
		[Tooltip] // 0x00000001800C9760-0x00000001800C9790
		public AnimationCurve recoilWeight; // 0x48
		[Tooltip] // 0x00000001800C9A20-0x00000001800C9A50
		public float magnitudeRandom; // 0x50
		[Tooltip] // 0x00000001800C9C80-0x00000001800C9CB0
		public Vector3 rotationRandom; // 0x54
		[Tooltip] // 0x00000001800C9E40-0x00000001800C9E70
		public Vector3 handRotationOffset; // 0x60
		[Tooltip] // 0x00000001800CA090-0x00000001800CA0C0
		public float blendTime; // 0x6C
		[Space] // 0x00000001800CA200-0x00000001800CA250
		[Tooltip] // 0x00000001800CA200-0x00000001800CA250
		public RecoilOffset[] offsets; // 0x70
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public Quaternion rotationOffset; // 0x78
		private float magnitudeMlp; // 0x88
		private float endTime; // 0x8C
		private Quaternion handRotation; // 0x90
		private Quaternion secondaryHandRelativeRotation; // 0xA0
		private Quaternion randomRotation; // 0xB0
		private float length; // 0xC0
		private bool initiated; // 0xC4
		private float blendWeight; // 0xC8
		private float w; // 0xCC
		private Quaternion primaryHandRotation; // 0xD0
		private bool handRotationsSet; // 0xE0
		private Vector3 aimIKAxis; // 0xE4
	
		// Properties
		public bool isFinished { get; } // 0x0000000181B0E550-0x0000000181B0E570 
		private IKEffector primaryHandEffector { get; } // 0x0000000181B0E570-0x0000000181B0E5D0 
		private IKEffector secondaryHandEffector { get; } // 0x0000000181B0E640-0x0000000181B0E6A0 
		private Transform primaryHand { get; } // 0x0000000181B0E5D0-0x0000000181B0E640 
		private Transform secondaryHand { get; } // 0x0000000181B0E6A0-0x0000000181B0E710 
	
		// Nested types
		[Serializable]
		public class RecoilOffset // TypeDefIndex: 9486
		{
			// Fields
			[Tooltip] // 0x00000001800CA770-0x00000001800CA7A0
			public Vector3 offset; // 0x10
			[Range] // 0x00000001800CAA40-0x00000001800CAAA0
			[Tooltip] // 0x00000001800CAA40-0x00000001800CAAA0
			public float additivity; // 0x1C
			[Tooltip] // 0x00000001800CACC0-0x00000001800CACF0
			public float maxAdditiveOffsetMag; // 0x20
			[Tooltip] // 0x00000001800CAF40-0x00000001800CAF70
			public EffectorLink[] effectorLinks; // 0x28
			private Vector3 additiveOffset; // 0x30
			private Vector3 lastOffset; // 0x3C
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 9487
			{
				// Fields
				[Tooltip] // 0x00000001800B7710-0x00000001800B7740
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip] // 0x00000001800B7940-0x00000001800B7970
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink(); // 0x000000018036B6C0-0x000000018036B6D0
			}
	
			// Constructors
			public RecoilOffset(); // 0x0000000181B0CA70-0x0000000181B0CA90
	
			// Methods
			public void Start(); // 0x0000000181B0C990-0x0000000181B0CA70
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft); // 0x0000000181B0C670-0x0000000181B0C990
		}
	
		[Serializable]
		public enum Handedness // TypeDefIndex: 9488
		{
			Right = 0,
			Left = 1
		}
	
		// Constructors
		public Recoil(); // 0x0000000181B0E4A0-0x0000000181B0E550
	
		// Methods
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation); // 0x0000000181B0E470-0x0000000181B0E4A0
		public void Fire(float magnitude); // 0x0000000181B0CC30-0x0000000181B0CF30
		protected override void OnModifyOffset(); // 0x0000000181B0D1F0-0x0000000181B0E470
		private void AfterFBBIK(); // 0x0000000181B0CAE0-0x0000000181B0CC30
		private void AfterAimIK(); // 0x0000000181B0CA90-0x0000000181B0CAE0
		protected override void OnDestroy(); // 0x0000000181B0CF30-0x0000000181B0D1F0
	}
}
