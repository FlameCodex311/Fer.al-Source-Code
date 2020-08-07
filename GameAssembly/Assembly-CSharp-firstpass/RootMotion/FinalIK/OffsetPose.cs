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
	public class OffsetPose : UnityEngine.MonoBehaviour // TypeDefIndex: 10014
	{
		// Fields
		public EffectorLink[] effectorLinks; // 0x18
	
		// Nested types
		[Serializable]
		public class EffectorLink // TypeDefIndex: 10015
		{
			// Fields
			public FullBodyBipedEffector effector; // 0x10
			public Vector3 offset; // 0x14
			public Vector3 pin; // 0x20
			public Vector3 pinWeight; // 0x2C
	
			// Constructors
			public EffectorLink(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation); // 0x000000018162CD40-0x000000018162D130
		}
	
		// Constructors
		public OffsetPose(); // 0x000000018163BA20-0x000000018163BA70
	
		// Methods
		public void Apply(IKSolverFullBodyBiped solver, float weight); // 0x000000018163B910-0x000000018163BA20
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation); // 0x000000018163B840-0x000000018163B910
	}
}
