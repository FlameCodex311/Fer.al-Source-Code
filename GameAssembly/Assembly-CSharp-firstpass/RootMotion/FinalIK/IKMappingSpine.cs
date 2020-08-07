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
	public class IKMappingSpine : IKMapping // TypeDefIndex: 9914
	{
		// Fields
		public Transform[] spineBones; // 0x10
		public Transform leftUpperArmBone; // 0x18
		public Transform rightUpperArmBone; // 0x20
		public Transform leftThighBone; // 0x28
		public Transform rightThighBone; // 0x30
		[Range] // 0x0000000180246690-0x00000001802466B0
		public int iterations; // 0x38
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float twistWeight; // 0x3C
		private int rootNodeIndex; // 0x40
		private BoneMap[] spine; // 0x48
		private BoneMap leftUpperArm; // 0x50
		private BoneMap rightUpperArm; // 0x58
		private BoneMap leftThigh; // 0x60
		private BoneMap rightThigh; // 0x68
		private bool useFABRIK; // 0x70
	
		// Constructors
		public IKMappingSpine(); // 0x00000001819E7CD0-0x00000001819E7E50
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone); // 0x00000001819E7B10-0x00000001819E7CD0
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message); // 0x00000001819E63B0-0x00000001819E6700
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone); // 0x00000001819E7290-0x00000001819E72B0
		public void StoreDefaultLocalState(); // 0x00000001819E72B0-0x00000001819E7390
		public void FixTransforms(); // 0x00000001819E5050-0x00000001819E5100
		public override void Initiate(IKSolverFullBody solver); // 0x00000001819E5420-0x00000001819E63B0
		private bool UseFABRIK(); // 0x00000001819E7390-0x00000001819E73C0
		public void ReadPose(); // 0x00000001819E6D60-0x00000001819E7290
		public void WritePose(IKSolverFullBody solver); // 0x00000001819E73C0-0x00000001819E7B10
		public void ForwardReach(Vector3 position); // 0x00000001819E5100-0x00000001819E5420
		private void BackwardReach(Vector3 position); // 0x00000001819E4D50-0x00000001819E5050
		private void MapToSolverPositions(IKSolverFullBody solver); // 0x00000001819E6700-0x00000001819E6D60
	}
}
