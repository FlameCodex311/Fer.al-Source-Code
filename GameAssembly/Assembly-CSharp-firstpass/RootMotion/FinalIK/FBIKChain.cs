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
	public class FBIKChain // TypeDefIndex: 9370
	{
		// Fields
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float pin; // 0x10
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float pull; // 0x14
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float push; // 0x18
		[Range] // 0x000000018010CDC0-0x000000018010CDE0
		public float pushParent; // 0x1C
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float reach; // 0x20
		public Smoothing reachSmoothing; // 0x24
		public Smoothing pushSmoothing; // 0x28
		public IKSolver.Node[] nodes; // 0x30
		public int[] children; // 0x38
		public ChildConstraint[] childConstraints; // 0x40
		public IKConstraintBend bendConstraint; // 0x48
		private float rootLength; // 0x50
		private bool initiated; // 0x54
		private float length; // 0x58
		private float distance; // 0x5C
		private IKSolver.Point p; // 0x60
		private float reachForce; // 0x68
		private float pullParentSum; // 0x6C
		private float[] crossFades; // 0x70
		private float sqrMag1; // 0x78
		private float sqrMag2; // 0x7C
		private float sqrMagDif; // 0x80
		private const float maxLimbLength = 0.99999f; // Metadata: 0x007450B0
	
		// Nested types
		[Serializable]
		public class ChildConstraint // TypeDefIndex: 9371
		{
			// Fields
			public float pushElasticity; // 0x10
			public float pullElasticity; // 0x14
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			private Transform bone1; // 0x18
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			private Transform bone2; // 0x20
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private float <nominalDistance>k__BackingField; // 0x28
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private bool <isRigid>k__BackingField; // 0x2C
			private float crossFade; // 0x30
			private float inverseCrossFade; // 0x34
			private int chain1Index; // 0x38
			private int chain2Index; // 0x3C
	
			// Properties
			public float nominalDistance { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180487D50-0x0000000180487D60 0x00000001805D90B0-0x00000001805D90C0
			public bool isRigid { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180488600-0x0000000180488610 0x0000000180488610-0x0000000180488620
	
			// Constructors
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f /* Metadata: 0x007450B4 */, float pullElasticity = 0f /* Metadata: 0x007450B8 */); // 0x0000000181C14660-0x0000000181C146C0
	
			// Methods
			public void Initiate(IKSolverFullBody solver); // 0x0000000181C13E00-0x0000000181C13E60
			public void OnPreSolve(IKSolverFullBody solver); // 0x0000000181C13E60-0x0000000181C14180
			public void Solve(IKSolverFullBody solver); // 0x0000000181C14180-0x0000000181C14660
		}
	
		[Serializable]
		public enum Smoothing // TypeDefIndex: 9372
		{
			None = 0,
			Exponential = 1,
			Cubic = 2
		}
	
		// Constructors
		public FBIKChain(); // 0x000000018182EEF0-0x000000018182EFA0
		public FBIKChain(float pin, float pull, params /* 0x00000001800B36B0-0x00000001800B36C0 */ Transform[] nodeTransforms); // 0x000000018182ECE0-0x000000018182EEF0
	
		// Methods
		public void SetNodes(params /* 0x00000001800B36B0-0x00000001800B36C0 */ Transform[] boneTransforms); // 0x000000018182D4B0-0x000000018182D5F0
		public int GetNodeIndex(Transform boneTransform); // 0x000000018182B9C0-0x000000018182BAD0
		public bool IsValid(ref string message); // 0x000000018182BD90-0x000000018182BEB0
		public void Initiate(IKSolverFullBody solver); // 0x000000018182BAD0-0x000000018182BD90
		public void ReadPose(IKSolverFullBody solver, bool fullBody); // 0x000000018182CA90-0x000000018182D4B0
		private void CalculateBoneLengths(IKSolverFullBody solver); // 0x000000018182A990-0x000000018182B430
		public void Reach(IKSolverFullBody solver); // 0x000000018182C4C0-0x000000018182CA90
		public Vector3 Push(IKSolverFullBody solver); // 0x000000018182BEB0-0x000000018182C4C0
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false /* Metadata: 0x007450AF */); // 0x000000018182DCB0-0x000000018182E260
		public void Stage1(IKSolverFullBody solver); // 0x000000018182E260-0x000000018182EAD0
		public void Stage2(IKSolverFullBody solver, Vector3 position); // 0x000000018182EAD0-0x000000018182ECE0
		public void SolveConstraintSystems(IKSolverFullBody solver); // 0x000000018182D690-0x000000018182D8E0
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length); // 0x000000018182D8E0-0x000000018182DA20
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude); // 0x000000018182B760-0x000000018182B9C0
		private void SolveChildConstraints(IKSolverFullBody solver); // 0x000000018182D5F0-0x000000018182D690
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance); // 0x000000018182DA20-0x000000018182DCB0
		public void ForwardReach(Vector3 position); // 0x000000018182B430-0x000000018182B760
		private void BackwardReach(Vector3 position); // 0x000000018182A530-0x000000018182A990
	}
}
