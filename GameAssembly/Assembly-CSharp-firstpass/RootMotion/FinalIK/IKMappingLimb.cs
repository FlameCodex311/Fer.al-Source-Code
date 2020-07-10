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
	[Serializable]
	public class IKMappingLimb : IKMapping // TypeDefIndex: 9378
	{
		// Fields
		public Transform parentBone; // 0x10
		public Transform bone1; // 0x18
		public Transform bone2; // 0x20
		public Transform bone3; // 0x28
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float maintainRotationWeight; // 0x30
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float weight; // 0x34
		private BoneMap boneMapParent; // 0x38
		private BoneMap boneMap1; // 0x40
		private BoneMap boneMap2; // 0x48
		private BoneMap boneMap3; // 0x50
	
		// Nested types
		[Serializable]
		public enum BoneMapType // TypeDefIndex: 9379
		{
			Parent = 0,
			Bone1 = 1,
			Bone2 = 2,
			Bone3 = 3
		}
	
		// Constructors
		public IKMappingLimb(); // 0x0000000181C29F40-0x0000000181C2A0A0
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null); // 0x0000000181C29DA0-0x0000000181C29F40
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message); // 0x0000000181C29010-0x0000000181C29210
		public BoneMap GetBoneMap(BoneMapType boneMap); // 0x0000000181C28B90-0x0000000181C28C50
		public void SetLimbOrientation(Vector3 upper, Vector3 lower); // 0x0000000181C293A0-0x0000000181C297C0
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null); // 0x0000000181C29380-0x0000000181C293A0
		public void StoreDefaultLocalState(); // 0x0000000181C297C0-0x0000000181C299E0
		public void FixTransforms(); // 0x0000000181C28A10-0x0000000181C28B90
		public override void Initiate(IKSolverFullBody solver); // 0x0000000181C28C50-0x0000000181C29010
		public void ReadPose(); // 0x0000000181C29210-0x0000000181C29380
		public void WritePose(IKSolverFullBody solver, bool fullBody); // 0x0000000181C299E0-0x0000000181C29DA0
	}
}
