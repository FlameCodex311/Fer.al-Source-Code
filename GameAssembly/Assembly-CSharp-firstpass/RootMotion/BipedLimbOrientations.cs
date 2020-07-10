/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion
{
	[Serializable]
	public class BipedLimbOrientations // TypeDefIndex: 9306
	{
		// Fields
		public LimbOrientation leftArm; // 0x10
		public LimbOrientation rightArm; // 0x18
		public LimbOrientation leftLeg; // 0x20
		public LimbOrientation rightLeg; // 0x28
	
		// Properties
		public static BipedLimbOrientations UMA { get; } // 0x000000018163BF70-0x000000018163C270 
		public static BipedLimbOrientations MaxBiped { get; } // 0x000000018163BC70-0x000000018163BF70 
	
		// Nested types
		[Serializable]
		public class LimbOrientation // TypeDefIndex: 9307
		{
			// Fields
			public Vector3 upperBoneForwardAxis; // 0x10
			public Vector3 lowerBoneForwardAxis; // 0x1C
			public Vector3 lastBoneLeftAxis; // 0x28
	
			// Constructors
			public LimbOrientation(Vector3 upperBoneForwardAxis, Vector3 lowerBoneForwardAxis, Vector3 lastBoneLeftAxis); // 0x0000000181654BE0-0x0000000181654C50
		}
	
		// Constructors
		public BipedLimbOrientations(LimbOrientation leftArm, LimbOrientation rightArm, LimbOrientation leftLeg, LimbOrientation rightLeg); // 0x0000000180609260-0x00000001806092C0
	}
}
