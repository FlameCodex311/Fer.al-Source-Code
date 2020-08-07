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
	public class FBBIKSettings : UnityEngine.MonoBehaviour // TypeDefIndex: 9801
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
		public class Limb // TypeDefIndex: 9802
		{
			// Fields
			public FBIKChain.Smoothing reachSmoothing; // 0x10
			public float maintainRelativePositionWeight; // 0x14
			public float mappingWeight; // 0x18
	
			// Constructors
			public Limb(); // 0x0000000181379A70-0x0000000181379A80
	
			// Methods
			public void Apply(FullBodyBipedChain chain, IKSolverFullBodyBiped solver); // 0x00000001813799E0-0x0000000181379A70
		}
	
		// Constructors
		public FBBIKSettings(); // 0x0000000181375720-0x0000000181375730
	
		// Methods
		public void UpdateSettings(); // 0x0000000181375360-0x0000000181375710
		private void Start(); // 0x00000001813752E0-0x0000000181375360
		private void Update(); // 0x0000000181375710-0x0000000181375720
	}
}
