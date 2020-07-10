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
	public class BipedReferences // TypeDefIndex: 9311
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
		public virtual bool isFilled { get; } // 0x00000001816457D0-0x0000000181645C30 
		public bool isEmpty { get; } // 0x00000001808C6790-0x00000001808C67B0 
	
		// Nested types
		public struct AutoDetectParams // TypeDefIndex: 9312
		{
			// Fields
			public bool legsParentInSpine; // 0x00
			public bool includeEyes; // 0x01
	
			// Properties
			public static AutoDetectParams Default { get; } // 0x000000018163A960-0x000000018163A970 
	
			// Constructors
			public AutoDetectParams(bool legsParentInSpine, bool includeEyes); // 0x0000000180253850-0x0000000180253890
		}
	
		// Constructors
		public BipedReferences(); // 0x0000000181645770-0x00000001816457D0
	
		// Methods
		public virtual bool IsEmpty(bool includeRoot); // 0x0000000181643B00-0x0000000181643FA0
		public virtual bool Contains(Transform t, bool ignoreRoot = false /* Metadata: 0x00745028 */); // 0x0000000181642330-0x00000001816427E0
		public static bool AutoDetectReferences(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams); // 0x0000000181641F40-0x0000000181642330
		public static void DetectReferencesByNaming(ref BipedReferences references, Transform root, AutoDetectParams autoDetectParams); // 0x0000000181642930-0x0000000181643510
		public static void AssignHumanoidReferences(ref BipedReferences references, Animator animator, AutoDetectParams autoDetectParams); // 0x0000000181641980-0x0000000181641F40
		public static bool SetupError(BipedReferences references, ref string errorMessage); // 0x0000000181645040-0x0000000181645180
		public static bool SetupWarning(BipedReferences references, ref string warningMessage); // 0x0000000181645180-0x0000000181645270
		private static bool IsNeckBone(Transform bone, Transform leftUpperArm); // 0x0000000181643FA0-0x0000000181644090
		private static bool AddBoneToEyes(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams); // 0x00000001816415C0-0x00000001816416D0
		private static bool AddBoneToSpine(Transform bone, ref BipedReferences references, AutoDetectParams autoDetectParams); // 0x00000001816417C0-0x0000000181641980
		private static void DetectLimb(BipedNaming.BoneType boneType, BipedNaming.BoneSide boneSide, ref Transform firstBone, ref Transform secondBone, ref Transform lastBone, Transform[] transforms); // 0x00000001816427E0-0x0000000181642930
		private static void AddBoneToHierarchy(ref Transform[] bones, Transform transform); // 0x00000001816416D0-0x00000001816417C0
		private static bool LimbError(Transform bone1, Transform bone2, Transform bone3, ref string errorMessage); // 0x0000000181644090-0x00000001816448A0
		private static bool LimbWarning(Transform bone1, Transform bone2, Transform bone3, ref string warningMessage); // 0x00000001816448A0-0x0000000181644CB0
		private static bool SpineError(BipedReferences references, ref string errorMessage); // 0x0000000181645270-0x0000000181645770
		private static bool SpineWarning(BipedReferences references, ref string warningMessage); // 0x00000001803C28F0-0x00000001803C2900
		private static bool EyesError(BipedReferences references, ref string errorMessage); // 0x0000000181643510-0x0000000181643730
		private static bool EyesWarning(BipedReferences references, ref string warningMessage); // 0x00000001803C28F0-0x00000001803C2900
		private static bool RootHeightWarning(BipedReferences references, ref string warningMessage); // 0x0000000181644CB0-0x0000000181645040
		private static bool FacingAxisWarning(BipedReferences references, ref string warningMessage); // 0x0000000181643730-0x00000001816439E0
		private static float GetVerticalOffset(Vector3 p1, Vector3 p2, Quaternion rotation); // 0x00000001816439E0-0x0000000181643B00
	}
}
