/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion
{
	[Serializable]
	public class BipedLimbOrientations // TypeDefIndex: 9760
	{
		// Fields
		public LimbOrientation leftArm; // 0x10
		public LimbOrientation rightArm; // 0x18
		public LimbOrientation leftLeg; // 0x20
		public LimbOrientation rightLeg; // 0x28
	
		// Properties
		public static BipedLimbOrientations UMA { get; } // 0x0000000180D1A9E0-0x0000000180D1ACE0 
		public static BipedLimbOrientations MaxBiped { get; } // 0x0000000180D1A6E0-0x0000000180D1A9E0 
	
		// Nested types
		[Serializable]
		public class LimbOrientation // TypeDefIndex: 9761
		{
			// Fields
			public Vector3 upperBoneForwardAxis; // 0x10
			public Vector3 lowerBoneForwardAxis; // 0x1C
			public Vector3 lastBoneLeftAxis; // 0x28
	
			// Constructors
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis); // 0x0000000180D28860-0x0000000180D288D0
		}
	
		// Constructors
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg); // 0x0000000180D1A680-0x0000000180D1A6E0
	}
}
