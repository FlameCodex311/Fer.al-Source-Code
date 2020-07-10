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
	public class IKMappingBone : IKMapping // TypeDefIndex: 9377
	{
		// Fields
		public Transform bone; // 0x10
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float maintainRotationWeight; // 0x18
		private BoneMap boneMap; // 0x20
	
		// Constructors
		public IKMappingBone(); // 0x0000000181C28980-0x0000000181C28A10
		public IKMappingBone(Transform bone); // 0x0000000181C288E0-0x0000000181C28980
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message); // 0x0000000181C28760-0x0000000181C287F0
		public void StoreDefaultLocalState(); // 0x0000000181C28840-0x0000000181C288B0
		public void FixTransforms(); // 0x0000000181C28650-0x0000000181C28690
		public override void Initiate(IKSolverFullBody solver); // 0x0000000181C28690-0x0000000181C28760
		public void ReadPose(); // 0x0000000181C287F0-0x0000000181C28840
		public void WritePose(float solverWeight); // 0x0000000181C288B0-0x0000000181C288E0
	}
}
