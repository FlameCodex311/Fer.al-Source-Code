/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverFullBodyBiped : IKSolverFullBody // TypeDefIndex: 9395
	{
		// Fields
		public Transform rootNode; // 0xD0
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float spineStiffness; // 0xD8
		[Range] // 0x000000018010CDC0-0x000000018010CDE0
		public float pullBodyVertical; // 0xDC
		[Range] // 0x000000018010CDC0-0x000000018010CDE0
		public float pullBodyHorizontal; // 0xE0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 <pullBodyOffset>k__BackingField; // 0xE4
		private Vector3 offset; // 0xF0
	
		// Properties
		public IKEffector bodyEffector { get; } // 0x0000000181D6F1C0-0x0000000181D6F200 
		public IKEffector leftShoulderEffector { get; } // 0x0000000181D6F380-0x0000000181D6F3C0 
		public IKEffector rightShoulderEffector { get; } // 0x0000000181D6F5A0-0x0000000181D6F5E0 
		public IKEffector leftThighEffector { get; } // 0x0000000181D6F3C0-0x0000000181D6F400 
		public IKEffector rightThighEffector { get; } // 0x0000000181D6F5E0-0x0000000181D6F620 
		public IKEffector leftHandEffector { get; } // 0x0000000181D6F2C0-0x0000000181D6F300 
		public IKEffector rightHandEffector { get; } // 0x0000000181D6F4E0-0x0000000181D6F520 
		public IKEffector leftFootEffector { get; } // 0x0000000181D6F280-0x0000000181D6F2C0 
		public IKEffector rightFootEffector { get; } // 0x0000000181D6F4A0-0x0000000181D6F4E0 
		public FBIKChain leftArmChain { get; } // 0x0000000181D6F200-0x0000000181D6F240 
		public FBIKChain rightArmChain { get; } // 0x0000000181D6F420-0x0000000181D6F460 
		public FBIKChain leftLegChain { get; } // 0x0000000181D6F300-0x0000000181D6F340 
		public FBIKChain rightLegChain { get; } // 0x0000000181D6F520-0x0000000181D6F560 
		public IKMappingLimb leftArmMapping { get; } // 0x0000000181D6F240-0x0000000181D6F280 
		public IKMappingLimb rightArmMapping { get; } // 0x0000000181D6F460-0x0000000181D6F4A0 
		public IKMappingLimb leftLegMapping { get; } // 0x0000000181D6F340-0x0000000181D6F380 
		public IKMappingLimb rightLegMapping { get; } // 0x0000000181D6F560-0x0000000181D6F5A0 
		public IKMappingBone headMapping { get; } // 0x0000000181D6BBE0-0x0000000181D6BC20 
		public Vector3 pullBodyOffset { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000181D6F400-0x0000000181D6F420 0x0000000181D6F620-0x0000000181D6F640
	
		// Constructors
		public IKSolverFullBodyBiped(); // 0x0000000181D6F0F0-0x0000000181D6F1C0
	
		// Methods
		public void SetChainWeights(FullBodyBipedChain c, float pull, float reach = 0f /* Metadata: 0x00745118 */); // 0x0000000181D6C8B0-0x0000000181D6C920
		public void SetEffectorWeights(FullBodyBipedEffector effector, float positionWeight, float rotationWeight); // 0x0000000181D6C920-0x0000000181D6CA10
		public FBIKChain GetChain(FullBodyBipedChain c); // 0x0000000181D6B470-0x0000000181D6B560
		public FBIKChain GetChain(FullBodyBipedEffector effector); // 0x0000000181D6B220-0x0000000181D6B470
		public IKEffector GetEffector(FullBodyBipedEffector effector); // 0x0000000181D6B560-0x0000000181D6B7D0
		public IKEffector GetEndEffector(FullBodyBipedChain c); // 0x0000000181D6B7D0-0x0000000181D6B8C0
		public IKMappingLimb GetLimbMapping(FullBodyBipedChain chain); // 0x0000000181D6BCF0-0x0000000181D6BDF0
		public IKMappingLimb GetLimbMapping(FullBodyBipedEffector effector); // 0x0000000181D6BDF0-0x0000000181D6C020
		public IKMappingSpine GetSpineMapping(); // 0x0000000180369B50-0x0000000180369B60
		public IKMappingBone GetHeadMapping(); // 0x0000000181D6BBE0-0x0000000181D6BC20
		public IKConstraintBend GetBendConstraint(FullBodyBipedChain limb); // 0x0000000181D6AD40-0x0000000181D6AE90
		public override bool IsValid(ref string message); // 0x0000000181D6C0F0-0x0000000181D6C3E0
		public void SetToReferences(BipedReferences references, Transform rootNode = null); // 0x0000000181D6CDA0-0x0000000181D6EF80
		public static Transform DetectRootNodeBone(BipedReferences references); // 0x0000000181D6A7F0-0x0000000181D6AD40
		public void SetLimbOrientations(BipedLimbOrientations o); // 0x0000000181D6CD30-0x0000000181D6CDA0
		private void SetLimbOrientation(FullBodyBipedChain chain, BipedLimbOrientations.LimbOrientation limbOrientation); // 0x0000000181D6CA10-0x0000000181D6CD30
		private static Transform GetLeftClavicle(BipedReferences references); // 0x0000000181D6BC20-0x0000000181D6BCF0
		private static Transform GetRightClavicle(BipedReferences references); // 0x0000000181D6C020-0x0000000181D6C0F0
		private static bool Contains(Transform[] array, Transform transform); // 0x0000000181D6A720-0x0000000181D6A7F0
		protected override void ReadPose(); // 0x0000000181D6C670-0x0000000181D6C8B0
		private void PullBody(); // 0x0000000181D6C3E0-0x0000000181D6C670
		private Vector3 GetBodyOffset(); // 0x0000000181D6AE90-0x0000000181D6B220
		private Vector3 GetHandBodyPull(IKEffector effector, FBIKChain arm, Vector3 offset); // 0x0000000181D6B8C0-0x0000000181D6BBE0
		protected override void ApplyBendConstraints(); // 0x0000000181D6A040-0x0000000181D6A720
		protected override void WritePose(); // 0x0000000181D6EF80-0x0000000181D6F0F0
	}
}
