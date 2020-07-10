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
	public class OffsetPose : UnityEngine.MonoBehaviour // TypeDefIndex: 9480
	{
		// Fields
		public EffectorLink[] effectorLinks; // 0x18
	
		// Nested types
		[Serializable]
		public class EffectorLink // TypeDefIndex: 9481
		{
			// Fields
			public FullBodyBipedEffector effector; // 0x10
			public Vector3 offset; // 0x14
			public Vector3 pin; // 0x20
			public Vector3 pinWeight; // 0x2C
	
			// Constructors
			public EffectorLink(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation); // 0x0000000181AF41C0-0x0000000181AF45C0
		}
	
		// Constructors
		public OffsetPose(); // 0x0000000181B0ACB0-0x0000000181B0AD00
	
		// Methods
		public void Apply(IKSolverFullBodyBiped solver, float weight); // 0x0000000181B0AB90-0x0000000181B0ACB0
		public void Apply(IKSolverFullBodyBiped solver, float weight, Quaternion rotation); // 0x0000000181B0AAB0-0x0000000181B0AB90
	}
}
