/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverFullBodyBiped : IKSolverFullBody // TypeDefIndex: 9929
	{
		// Fields
		public Transform rootNode; // 0xD0
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float spineStiffness; // 0xD8
		[Range] // 0x0000000180244630-0x0000000180244650
		public float pullBodyVertical; // 0xDC
		[Range] // 0x0000000180244630-0x0000000180244650
		public float pullBodyHorizontal; // 0xE0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <pullBodyOffset>k__BackingField; // 0xE4
		private Vector3 offset; // 0xF0
	
		// Properties
		public IKEffector bodyEffector { get; } // 0x0000000181A9FC90-0x0000000181A9FCD0 
		public IKEffector leftShoulderEffector { get; } // 0x0000000181A9FE50-0x0000000181A9FE90 
		public IKEffector rightShoulderEffector { get; } // 0x0000000181AA0070-0x0000000181AA00B0 
		public IKEffector leftThighEffector { get; } // 0x0000000181A9FE90-0x0000000181A9FED0 
		public IKEffector rightThighEffector { get; } // 0x0000000181AA00B0-0x0000000181AA00F0 
		public IKEffector leftHandEffector { get; } // 0x0000000181A9FD90-0x0000000181A9FDD0 
		public IKEffector rightHandEffector { get; } // 0x0000000181A9FFB0-0x0000000181A9FFF0 
		public IKEffector leftFootEffector { get; } // 0x0000000181A9FD50-0x0000000181A9FD90 
		public IKEffector rightFootEffector { get; } // 0x0000000181A9FF70-0x0000000181A9FFB0 
		public FBIKChain leftArmChain { get; } // 0x0000000181A9FCD0-0x0000000181A9FD10 
		public FBIKChain rightArmChain { get; } // 0x0000000181A9FEF0-0x0000000181A9FF30 
		public FBIKChain leftLegChain { get; } // 0x0000000181A9FDD0-0x0000000181A9FE10 
		public FBIKChain rightLegChain { get; } // 0x0000000181A9FFF0-0x0000000181AA0030 
		public IKMappingLimb leftArmMapping { get; } // 0x0000000181A9FD10-0x0000000181A9FD50 
		public IKMappingLimb rightArmMapping { get; } // 0x0000000181A9FF30-0x0000000181A9FF70 
		public IKMappingLimb leftLegMapping { get; } // 0x0000000181A9FE10-0x0000000181A9FE50 
		public IKMappingLimb rightLegMapping { get; } // 0x0000000181AA0030-0x0000000181AA0070 
		public IKMappingBone headMapping { get; } // 0x0000000181A9C9D0-0x0000000181A9CA10 
		public Vector3 pullBodyOffset { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000181A9FED0-0x0000000181A9FEF0 0x0000000181AA00F0-0x0000000181AA0110
	
		// Constructors
		public IKSolverFullBodyBiped(); // 0x0000000181A9FC70-0x0000000181A9FC90
	
		// Methods
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f /* Metadata: 0x0077AC25 */); // 0x0000000181A9D620-0x0000000181A9D690
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight); // 0x0000000181A9D690-0x0000000181A9D780
		public FBIKChain GetChain(FullBodyBipedChain c); // 0x0000000181A9C2D0-0x0000000181A9C3B0
		public FBIKChain GetChain(FullBodyBipedEffector effector); // 0x0000000181A9C0B0-0x0000000181A9C2D0
		public IKEffector GetEffector(FullBodyBipedEffector effector); // 0x0000000181A9C3B0-0x0000000181A9C5F0
		public IKEffector GetEndEffector(FullBodyBipedChain c); // 0x0000000181A9C5F0-0x0000000181A9C6D0
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain); // 0x0000000181A9CAE0-0x0000000181A9CBD0
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector); // 0x0000000181A9CBD0-0x0000000181A9CDE0
		public IKMappingSpine GetSpineMapping(); // 0x0000000180418980-0x0000000180418990
		public IKMappingBone GetHeadMapping(); // 0x0000000181A9C9D0-0x0000000181A9CA10
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb); // 0x0000000181A9BC20-0x0000000181A9BD30
		public override bool IsValid(ref string message); // 0x0000000181A9CEB0-0x0000000181A9D180
		public void SetToReferences(BipedReferences references, Transform rootNode = null); // 0x0000000181A9DB10-0x0000000181A9FB10
		public static Transform DetectRootNodeBone(BipedReferences references); // 0x0000000181A9B700-0x0000000181A9BC20
		public void SetLimbOrientations(BipedLimbOrientations o); // 0x0000000181A9DAA0-0x0000000181A9DB10
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation); // 0x0000000181A9D780-0x0000000181A9DAA0
		private static Transform GetLeftClavicle(BipedReferences references); // 0x0000000181A9CA10-0x0000000181A9CAE0
		private static Transform GetRightClavicle(BipedReferences references); // 0x0000000181A9CDE0-0x0000000181A9CEB0
		private static bool Contains(Transform[] array, Transform transform); // 0x0000000181A9B640-0x0000000181A9B700
		protected override void ReadPose(); // 0x0000000181A9D400-0x0000000181A9D620
		private void PullBody(); // 0x0000000181A9D180-0x0000000181A9D400
		private Vector3 GetBodyOffset(); // 0x0000000181A9BD30-0x0000000181A9C0B0
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset); // 0x0000000181A9C6D0-0x0000000181A9C9D0
		protected override void ApplyBendConstraints(); // 0x0000000181A9B000-0x0000000181A9B640
		protected override void WritePose(); // 0x0000000181A9FB10-0x0000000181A9FC70
	}
}
