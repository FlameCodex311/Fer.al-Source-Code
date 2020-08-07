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
	[Serializable]
	public class IKMappingLimb : IKMapping // TypeDefIndex: 9912
	{
		// Fields
		public Transform parentBone; // 0x10
		public Transform bone1; // 0x18
		public Transform bone2; // 0x20
		public Transform bone3; // 0x28
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float maintainRotationWeight; // 0x30
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float weight; // 0x34
		private BoneMap boneMapParent; // 0x38
		private BoneMap boneMap1; // 0x40
		private BoneMap boneMap2; // 0x48
		private BoneMap boneMap3; // 0x50
	
		// Nested types
		[Serializable]
		public enum BoneMapType // TypeDefIndex: 9913
		{
			Parent = 0,
			Bone1 = 1,
			Bone2 = 2,
			Bone3 = 3
		}
	
		// Constructors
		public IKMappingLimb(); // 0x00000001819E4BF0-0x00000001819E4D50
		public IKMappingLimb(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null); // 0x00000001819E4A50-0x00000001819E4BF0
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message); // 0x00000001819E3E90-0x00000001819E4080
		public BoneMap GetBoneMap(BoneMapType boneMap); // 0x00000001819E3A20-0x00000001819E3AE0
		public void SetLimbOrientation(Vector3 upper, Vector3 lower); // 0x00000001819E4200-0x00000001819E4610
		public void SetBones(Transform bone1, Transform bone2, Transform bone3, Transform parentBone = null); // 0x00000001819E41E0-0x00000001819E4200
		public void StoreDefaultLocalState(); // 0x00000001819E4610-0x00000001819E4810
		public void FixTransforms(); // 0x00000001819E38A0-0x00000001819E3A20
		public override void Initiate(IKSolverFullBody solver); // 0x00000001819E3AE0-0x00000001819E3E90
		public void ReadPose(); // 0x00000001819E4080-0x00000001819E41E0
		public void WritePose(IKSolverFullBody solver, bool fullBody); // 0x00000001819E4810-0x00000001819E4A50
	}
}
