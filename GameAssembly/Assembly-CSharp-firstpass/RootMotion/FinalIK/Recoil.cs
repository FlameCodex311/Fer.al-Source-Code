/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	public class Recoil : OffsetModifier // TypeDefIndex: 10019
	{
		// Fields
		[Tooltip] // 0x00000001802893F0-0x0000000180289420
		public AimIK aimIK; // 0x30
		[Tooltip] // 0x0000000180289510-0x0000000180289540
		public bool aimIKSolvedLast; // 0x38
		[Tooltip] // 0x0000000180289680-0x00000001802896B0
		public Handedness handedness; // 0x3C
		[Tooltip] // 0x0000000180289800-0x0000000180289830
		public bool twoHanded; // 0x40
		[Tooltip] // 0x0000000180289930-0x0000000180289960
		public AnimationCurve recoilWeight; // 0x48
		[Tooltip] // 0x0000000180289B60-0x0000000180289B90
		public float magnitudeRandom; // 0x50
		[Tooltip] // 0x0000000180289CD0-0x0000000180289D00
		public Vector3 rotationRandom; // 0x54
		[Tooltip] // 0x0000000180289FA0-0x0000000180289FD0
		public Vector3 handRotationOffset; // 0x60
		[Tooltip] // 0x000000018028A160-0x000000018028A190
		public float blendTime; // 0x6C
		[Space] // 0x000000018028A3A0-0x000000018028A3F0
		[Tooltip] // 0x000000018028A3A0-0x000000018028A3F0
		public RecoilOffset[] offsets; // 0x70
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		public bool isFinished { get; } // 0x000000018163F300-0x000000018163F320 
		private IKEffector primaryHandEffector { get; } // 0x000000018163F320-0x000000018163F380 
		private IKEffector secondaryHandEffector { get; } // 0x000000018163F3F0-0x000000018163F450 
		private Transform primaryHand { get; } // 0x000000018163F380-0x000000018163F3F0 
		private Transform secondaryHand { get; } // 0x000000018163F450-0x000000018163F4C0 
	
		// Nested types
		[Serializable]
		public class RecoilOffset // TypeDefIndex: 10020
		{
			// Fields
			[Tooltip] // 0x000000018028A570-0x000000018028A5A0
			public Vector3 offset; // 0x10
			[Range] // 0x000000018028A710-0x000000018028A770
			[Tooltip] // 0x000000018028A710-0x000000018028A770
			public float additivity; // 0x1C
			[Tooltip] // 0x000000018028A9B0-0x000000018028A9E0
			public float maxAdditiveOffsetMag; // 0x20
			[Tooltip] // 0x000000018028AA80-0x000000018028AAB0
			public EffectorLink[] effectorLinks; // 0x28
			private Vector3 additiveOffset; // 0x30
			private Vector3 lastOffset; // 0x3C
	
			// Nested types
			[Serializable]
			public class EffectorLink // TypeDefIndex: 10021
			{
				// Fields
				[Tooltip] // 0x0000000180279410-0x0000000180279440
				public FullBodyBipedEffector effector; // 0x10
				[Tooltip] // 0x00000001802795C0-0x00000001802795F0
				public float weight; // 0x14
	
				// Constructors
				public EffectorLink(); // 0x0000000180373240-0x0000000180373250
			}
	
			// Constructors
			public RecoilOffset(); // 0x000000018163D860-0x000000018163D880
	
			// Methods
			public void Start(); // 0x000000018163D780-0x000000018163D860
			public void Apply(IKSolverFullBodyBiped solver, Quaternion rotation, float masterWeight, float length, float timeLeft); // 0x000000018163D460-0x000000018163D780
		}
	
		[Serializable]
		public enum Handedness // TypeDefIndex: 10022
		{
			Right = 0,
			Left = 1
		}
	
		// Constructors
		public Recoil(); // 0x000000018163F250-0x000000018163F300
	
		// Methods
		public void SetHandRotations(Quaternion leftHandRotation, Quaternion rightHandRotation); // 0x000000018163F220-0x000000018163F250
		public void Fire(float magnitude); // 0x000000018163DA80-0x000000018163DD70
		protected override void OnModifyOffset(); // 0x000000018163E020-0x000000018163F220
		private void AfterFBBIK(); // 0x000000018163D8D0-0x000000018163DA80
		private void AfterAimIK(); // 0x000000018163D880-0x000000018163D8D0
		protected override void OnDestroy(); // 0x000000018163DD70-0x000000018163E020
	}
}
