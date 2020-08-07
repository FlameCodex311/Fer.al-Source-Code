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
	public class IKMappingBone : IKMapping // TypeDefIndex: 9911
	{
		// Fields
		public Transform bone; // 0x10
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float maintainRotationWeight; // 0x18
		private BoneMap boneMap; // 0x20
	
		// Constructors
		public IKMappingBone(); // 0x00000001819E3810-0x00000001819E38A0
		public IKMappingBone(Transform bone); // 0x00000001819E3770-0x00000001819E3810
	
		// Methods
		public override bool IsValid(IKSolver solver, ref string message); // 0x00000001819E3600-0x00000001819E3690
		public void StoreDefaultLocalState(); // 0x00000001819E36D0-0x00000001819E3740
		public void FixTransforms(); // 0x00000001819E34F0-0x00000001819E3530
		public override void Initiate(IKSolverFullBody solver); // 0x00000001819E3530-0x00000001819E3600
		public void ReadPose(); // 0x00000001819E3690-0x00000001819E36D0
		public void WritePose(float solverWeight); // 0x00000001819E3740-0x00000001819E3770
	}
}
