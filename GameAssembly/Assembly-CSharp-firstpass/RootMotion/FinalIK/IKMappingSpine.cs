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
	public class IKMappingSpine : IKMapping // TypeDefIndex: 9380
	{
		// Fields
		public Transform[] spineBones; // 0x10
		public Transform leftUpperArmBone; // 0x18
		public Transform rightUpperArmBone; // 0x20
		public Transform leftThighBone; // 0x28
		public Transform rightThighBone; // 0x30
		[Range] // 0x0000000180140BA0-0x0000000180140BC0
		public int iterations; // 0x38
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float twistWeight; // 0x3C
		private int rootNodeIndex; // 0x40
		private BoneMap[] spine; // 0x48
		private BoneMap leftUpperArm; // 0x50
		private BoneMap rightUpperArm; // 0x58
		private BoneMap leftThigh; // 0x60
		private BoneMap rightThigh; // 0x68
		private bool useFABRIK; // 0x70
	
		// Constructors
		public IKMappingSpine(); // 0x0000000181C2CD90-0x0000000181C2CF10
		public IKMappingSpine(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone); // 0x0000000181C2CBD0-0x0000000181C2CD90
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message); // 0x0000000181C2B450-0x0000000181C2B7B0
		public void SetBones(Transform[] spineBones, Transform leftUpperArmBone, Transform rightUpperArmBone, Transform leftThighBone, Transform rightThighBone); // 0x0000000181C2C3B0-0x0000000181C2C3D0
		public void StoreDefaultLocalState(); // 0x0000000181C2C3D0-0x0000000181C2C4C0
		public void FixTransforms(); // 0x0000000181C2A3C0-0x0000000181C2A480
		public override void Initiate(IKSolverFullBody solver); // 0x0000000181C2A7C0-0x0000000181C2B450
		private bool UseFABRIK(); // 0x0000000181C2C4C0-0x0000000181C2C4F0
		public void ReadPose(); // 0x0000000181C2BE40-0x0000000181C2C3B0
		public void WritePose(IKSolverFullBody solver); // 0x0000000181C2C4F0-0x0000000181C2CBD0
		public void ForwardReach(Vector3 position); // 0x0000000181C2A480-0x0000000181C2A7C0
		private void BackwardReach(Vector3 position); // 0x0000000181C2A0A0-0x0000000181C2A3C0
		private void MapToSolverPositions(IKSolverFullBody solver); // 0x0000000181C2B7B0-0x0000000181C2BE40
	}
}
