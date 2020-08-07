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
	public class IKMapping // TypeDefIndex: 9909
	{
		// Nested types
		[Serializable]
		public class BoneMap // TypeDefIndex: 9910
		{
			// Fields
			public Transform transform; // 0x10
			public int chainIndex; // 0x18
			public int nodeIndex; // 0x1C
			public Vector3 defaultLocalPosition; // 0x20
			public Quaternion defaultLocalRotation; // 0x2C
			public Vector3 localSwingAxis; // 0x3C
			public Vector3 localTwistAxis; // 0x48
			public Vector3 planePosition; // 0x54
			public Vector3 ikPosition; // 0x60
			public Quaternion defaultLocalTargetRotation; // 0x6C
			private Quaternion maintainRotation; // 0x7C
			public float length; // 0x8C
			public Quaternion animatedRotation; // 0x90
			private Transform planeBone1; // 0xA0
			private Transform planeBone2; // 0xA8
			private Transform planeBone3; // 0xB0
			private int plane1ChainIndex; // 0xB8
			private int plane1NodeIndex; // 0xBC
			private int plane2ChainIndex; // 0xC0
			private int plane2NodeIndex; // 0xC4
			private int plane3ChainIndex; // 0xC8
			private int plane3NodeIndex; // 0xCC
	
			// Properties
			public Vector3 swingDirection { get; } // 0x00000001819D9310-0x00000001819D93E0 
			public bool isNodeBone { get; } // 0x00000001819D9030-0x00000001819D9040 
			private Quaternion lastAnimatedTargetRotation { get; } // 0x00000001819D9040-0x00000001819D9310 
	
			// Constructors
			public BoneMap(); // 0x00000001819D9000-0x00000001819D9030
	
			// Methods
			public void Initiate(Transform transform, IKSolverFullBody solver); // 0x00000001819D7DC0-0x00000001819D7E00
			public void StoreDefaultLocalState(); // 0x000000018143DFB0-0x000000018143E010
			public void FixTransform(bool position); // 0x00000001819D77B0-0x00000001819D7820
			public void SetLength(BoneMap nextBone); // 0x00000001819D83B0-0x00000001819D84B0
			public void SetLocalSwingAxis(BoneMap swingTarget); // 0x00000001819D84B0-0x00000001819D84C0
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2); // 0x00000001819D84C0-0x00000001819D8680
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection); // 0x00000001819D8680-0x00000001819D87A0
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3); // 0x00000001819D87A0-0x00000001819D8880
			public void UpdatePlane(bool rotation, bool position); // 0x00000001819D8E20-0x00000001819D9000
			public void SetIKPosition(); // 0x00000001819D8370-0x00000001819D83B0
			public void MaintainRotation(); // 0x00000001819D7E00-0x00000001819D7E40
			public void SetToIKPosition(); // 0x00000001819D8880-0x00000001819D88C0
			public void FixToNode(IKSolverFullBody solver, float weight, IKSolver.Node fixNode = null); // 0x00000001819D75A0-0x00000001819D77B0
			public Vector3 GetPlanePosition(IKSolverFullBody solver); // 0x00000001819D7820-0x00000001819D7A10
			public void PositionToPlane(IKSolverFullBody solver); // 0x00000001819D7E40-0x00000001819D7E90
			public void RotateToPlane(IKSolverFullBody solver, float weight); // 0x00000001819D81E0-0x00000001819D8370
			public void Swing(Vector3 swingTarget, float weight); // 0x00000001819D88C0-0x00000001819D8950
			public void Swing(Vector3 pos1, Vector3 pos2, float weight); // 0x00000001819D8950-0x00000001819D8BD0
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight); // 0x00000001819D8BD0-0x00000001819D8E20
			public void RotateToMaintain(float weight); // 0x00000001819D80D0-0x00000001819D81E0
			public void RotateToEffector(IKSolverFullBody solver, float weight); // 0x00000001819D7E90-0x00000001819D80D0
			private Quaternion GetTargetRotation(IKSolverFullBody solver); // 0x00000001819D7A10-0x00000001819D7DC0
		}
	
		// Constructors
		public IKMapping(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public virtual bool IsValid(IKSolver solver, ref string message); // 0x0000000180380B60-0x0000000180380B70
		public virtual void Initiate(IKSolverFullBody solver); // 0x00000001803774A0-0x00000001803774B0
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, Warning.Logger logger = null); // 0x00000001819E7E50-0x00000001819E7F70
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length); // 0x00000001819E7F70-0x00000001819E80B0
	}
}
