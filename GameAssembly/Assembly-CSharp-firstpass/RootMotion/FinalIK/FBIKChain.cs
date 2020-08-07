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
	public class FBIKChain // TypeDefIndex: 9904
	{
		// Fields
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float pin; // 0x10
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float pull; // 0x14
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float push; // 0x18
		[Range] // 0x0000000180244630-0x0000000180244650
		public float pushParent; // 0x1C
		[Range] // 0x00000001801D3630-0x00000001801D3650
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
		private const float maxLimbLength = 0.99999f; // Metadata: 0x0077ABBD
	
		// Nested types
		[Serializable]
		public class ChildConstraint // TypeDefIndex: 9905
		{
			// Fields
			public float pushElasticity; // 0x10
			public float pullElasticity; // 0x14
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Transform bone1; // 0x18
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Transform bone2; // 0x20
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private float <nominalDistance>k__BackingField; // 0x28
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private bool <isRigid>k__BackingField; // 0x2C
			private float crossFade; // 0x30
			private float inverseCrossFade; // 0x34
			private int chain1Index; // 0x38
			private int chain2Index; // 0x3C
	
			// Properties
			public float nominalDistance { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180491DA0-0x0000000180491DB0 0x0000000180626240-0x0000000180626250
			public bool isRigid { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180626230-0x0000000180626240 0x0000000180626250-0x0000000180626260
	
			// Constructors
			public ChildConstraint(Transform bone1, Transform bone2, float pushElasticity = 0f /* Metadata: 0x0077ABC1 */, float pullElasticity = 0f /* Metadata: 0x0077ABC5 */); // 0x0000000181425E00-0x0000000181425E60
	
			// Methods
			public void Initiate(IKSolverFullBody solver); // 0x00000001814255F0-0x0000000181425650
			public void OnPreSolve(IKSolverFullBody solver); // 0x0000000181425650-0x0000000181425950
			public void Solve(IKSolverFullBody solver); // 0x0000000181425950-0x0000000181425E00
		}
	
		[Serializable]
		public enum Smoothing // TypeDefIndex: 9906
		{
			None = 0,
			Exponential = 1,
			Cubic = 2
		}
	
		// Constructors
		public FBIKChain(); // 0x0000000181432D10-0x0000000181432DC0
		public FBIKChain(float pin, float pull, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ Transform[] nodeTransforms); // 0x0000000181432B10-0x0000000181432D10
	
		// Methods
		public void SetNodes(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ Transform[] boneTransforms); // 0x0000000181431120-0x0000000181431250
		public int GetNodeIndex(Transform boneTransform); // 0x000000018142F710-0x000000018142F810
		public bool IsValid(ref string message); // 0x000000018142FAE0-0x000000018142FC00
		public void Initiate(IKSolverFullBody solver); // 0x000000018142F810-0x000000018142FAE0
		public void ReadPose(IKSolverFullBody solver, bool fullBody); // 0x0000000181430790-0x0000000181431120
		private void CalculateBoneLengths(IKSolverFullBody solver); // 0x000000018142E7A0-0x000000018142F1B0
		public void Reach(IKSolverFullBody solver); // 0x00000001814301E0-0x0000000181430790
		public Vector3 Push(IKSolverFullBody solver); // 0x000000018142FC00-0x00000001814301E0
		public void SolveTrigonometric(IKSolverFullBody solver, bool calculateBendDirection = false /* Metadata: 0x0077ABBC */); // 0x0000000181431B20-0x00000001814320A0
		public void Stage1(IKSolverFullBody solver); // 0x00000001814320A0-0x0000000181432910
		public void Stage2(IKSolverFullBody solver, Vector3 position); // 0x0000000181432910-0x0000000181432B10
		public void SolveConstraintSystems(IKSolverFullBody solver); // 0x00000001814312F0-0x0000000181431760
		private Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length); // 0x0000000181431760-0x00000001814318A0
		protected Vector3 GetDirToBendPoint(Vector3 direction, Vector3 bendDirection, float directionMagnitude); // 0x000000018142F4B0-0x000000018142F710
		private void SolveChildConstraints(IKSolverFullBody solver); // 0x0000000181431250-0x00000001814312F0
		private void SolveLinearConstraint(IKSolver.Node node1, IKSolver.Node node2, float crossFade, float distance); // 0x00000001814318A0-0x0000000181431B20
		public void ForwardReach(Vector3 position); // 0x000000018142F1B0-0x000000018142F4B0
		private void BackwardReach(Vector3 position); // 0x000000018142E360-0x000000018142E7A0
	}
}
