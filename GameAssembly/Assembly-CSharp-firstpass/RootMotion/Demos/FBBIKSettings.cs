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
	public class FBBIKSettings : UnityEngine.MonoBehaviour // TypeDefIndex: 9514
	{
		// Fields
		public FullBodyBipedIK ik; // 0x18
		public bool disableAfterStart; // 0x20
		public Limb leftArm; // 0x28
		public Limb rightArm; // 0x30
		public Limb leftLeg; // 0x38
		public Limb rightLeg; // 0x40
		public float rootPin; // 0x48
		public bool bodyEffectChildNodes; // 0x4C
	
		// Nested types
		[Serializable]
		public class Limb // TypeDefIndex: 9515
		{
			// Fields
			public FBIKChain.Smoothing reachSmoothing; // 0x10
			public float maintainRelativePositionWeight; // 0x14
			public float mappingWeight; // 0x18
	
			// Constructors
			public Limb(); // 0x0000000181833070-0x0000000181833080
	
			// Methods
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver); // 0x0000000181832FD0-0x0000000181833070
		}
	
		// Constructors
		public FBBIKSettings(); // 0x000000018182A110-0x000000018182A120
	
		// Methods
		public void UpdateSettings(); // 0x0000000181829D20-0x000000018182A100
		private void Start(); // 0x0000000181829CA0-0x0000000181829D20
		private void Update(); // 0x000000018182A100-0x000000018182A110
	}
}
