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
	public class BipedReferences // TypeDefIndex: 9765
	{
		// Fields
		public Transform root; // 0x10
		public Transform pelvis; // 0x18
		public Transform leftThigh; // 0x20
		public Transform leftCalf; // 0x28
		public Transform leftFoot; // 0x30
		public Transform rightThigh; // 0x38
		public Transform rightCalf; // 0x40
		public Transform rightFoot; // 0x48
		public Transform leftUpperArm; // 0x50
		public Transform leftForearm; // 0x58
		public Transform leftHand; // 0x60
		public Transform rightUpperArm; // 0x68
		public Transform rightForearm; // 0x70
		public Transform rightHand; // 0x78
		public Transform head; // 0x80
		public Transform[] spine; // 0x88
		public Transform[] eyes; // 0x90
	
		// Properties
		public virtual bool isFilled { get; } // 0x000000018136C370-0x000000018136C7D0 
		public bool isEmpty { get; } // 0x00000001812B1420-0x00000001812B1440 
	
		// Nested types
		public struct AutoDetectParams // TypeDefIndex: 9766
		{
			// Fields
			public bool legsParentInSpine; // 0x00
			public bool includeEyes; // 0x01
	
			// Properties
			public static AutoDetectParams Default { get; } // 0x0000000181367940-0x0000000181367950 
	
			// Constructors
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes); // 0x00000001800C12E0-0x00000001800C1340
		}
	
		// Constructors
		public BipedReferences(); // 0x000000018136C310-0x000000018136C370
	
		// Methods
		public virtual bool IsEmpty(bool includeRoot); // 0x000000018136A740-0x000000018136ABE0
		public virtual bool Contains(Transform t, bool ignoreRoot = false /* Metadata: 0x0077AADA */); // 0x0000000181369070-0x0000000181369510
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams); // 0x0000000181368C90-0x0000000181369070
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams); // 0x0000000181369650-0x000000018136A170
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams); // 0x0000000181368700-0x0000000181368C90
		public static bool SetupError(BipedReferences references, ref string errorMessage); // 0x000000018136BC00-0x000000018136BD40
		public static bool SetupWarning(BipedReferences references, ref string warningMessage); // 0x000000018136BD40-0x000000018136BE30
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm); // 0x000000018136ABE0-0x000000018136ACD0
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams); // 0x0000000181368360-0x0000000181368470
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams); // 0x0000000181368550-0x0000000181368700
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms); // 0x0000000181369510-0x0000000181369650
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform); // 0x0000000181368470-0x0000000181368550
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage); // 0x000000018136ACD0-0x000000018136B490
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage); // 0x000000018136B490-0x000000018136B880
		private static bool SpineError(BipedReferences references, ref string errorMessage); // 0x000000018136BE30-0x000000018136C310
		private static bool SpineWarning(BipedReferences references, ref string warningMessage); // 0x0000000180380950-0x0000000180380960
		private static bool EyesError(BipedReferences references, ref string errorMessage); // 0x000000018136A170-0x000000018136A380
		private static bool EyesWarning(BipedReferences references, ref string warningMessage); // 0x0000000180380950-0x0000000180380960
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage); // 0x000000018136B880-0x000000018136BC00
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage); // 0x000000018136A380-0x000000018136A620
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation); // 0x000000018136A620-0x000000018136A740
	}
}
