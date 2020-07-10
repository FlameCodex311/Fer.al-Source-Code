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
	public class IKMapping // TypeDefIndex: 9375
	{
		// Nested types
		[Serializable]
		public class BoneMap // TypeDefIndex: 9376
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
			public Vector3 swingDirection { get; } // 0x0000000181C12F40-0x0000000181C13010 
			public bool isNodeBone { get; } // 0x0000000181C12C50-0x0000000181C12C60 
			private Quaternion lastAnimatedTargetRotation { get; } // 0x0000000181C12C60-0x0000000181C12F40 
	
			// Constructors
			public BoneMap(); // 0x0000000181C12C20-0x0000000181C12C50
	
			// Methods
			public void Initiate(Transform transform, IKSolverFullBody solver); // 0x0000000181C11980-0x0000000181C119C0
			public void StoreDefaultLocalState(); // 0x0000000181C12460-0x0000000181C124D0
			public void FixTransform(bool position); // 0x0000000181C11500-0x0000000181C11570
			public void SetLength(BoneMap nextBone); // 0x0000000181C11F30-0x0000000181C12040
			public void SetLocalSwingAxis(BoneMap swingTarget); // 0x0000000181C12040-0x0000000181C12050
			public void SetLocalSwingAxis(BoneMap bone1, BoneMap bone2); // 0x0000000181C12050-0x0000000181C12220
			public void SetLocalTwistAxis(Vector3 twistDirection, Vector3 normalDirection); // 0x0000000181C12220-0x0000000181C12340
			public void SetPlane(IKSolverFullBody solver, Transform planeBone1, Transform planeBone2, Transform planeBone3); // 0x0000000181C12340-0x0000000181C12420
			public void UpdatePlane(bool rotation, bool position); // 0x0000000181C12A30-0x0000000181C12C20
			public void SetIKPosition(); // 0x0000000181C11EF0-0x0000000181C11F30
			public void MaintainRotation(); // 0x0000000181C119C0-0x0000000181C11A00
			public void SetToIKPosition(); // 0x0000000181C12420-0x0000000181C12460
			public void FixToNode(IKSolverFullBody solver, float weight, IKSolver.Node fixNode = null); // 0x0000000181C11340-0x0000000181C11500
			public Vector3 GetPlanePosition(IKSolverFullBody solver); // 0x0000000181C11570-0x0000000181C11700
			public void PositionToPlane(IKSolverFullBody solver); // 0x0000000181C11A00-0x0000000181C11A60
			public void RotateToPlane(IKSolverFullBody solver, float weight); // 0x0000000181C11D60-0x0000000181C11EF0
			public void Swing(Vector3 swingTarget, float weight); // 0x0000000181C124D0-0x0000000181C12560
			public void Swing(Vector3 pos1, Vector3 pos2, float weight); // 0x0000000181C12560-0x0000000181C127E0
			public void Twist(Vector3 twistDirection, Vector3 normalDirection, float weight); // 0x0000000181C127E0-0x0000000181C12A30
			public void RotateToMaintain(float weight); // 0x0000000181C11C40-0x0000000181C11D60
			public void RotateToEffector(IKSolverFullBody solver, float weight); // 0x0000000181C11A60-0x0000000181C11C40
			private Quaternion GetTargetRotation(IKSolverFullBody solver); // 0x0000000181C11700-0x0000000181C11980
		}
	
		// Constructors
		public IKMapping(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public virtual bool IsValid(IKSolver solver, ref string message); // 0x00000001803C29F0-0x00000001803C2A00
		public virtual void Initiate(IKSolverFullBody solver); // 0x00000001803581E0-0x00000001803581F0
		protected bool BoneIsValid(Transform bone, IKSolver solver, ref string message, Warning.Logger logger = null); // 0x0000000181C2CF10-0x0000000181C2D030
		protected Vector3 SolveFABRIKJoint(Vector3 pos1, Vector3 pos2, float length); // 0x0000000181C2D030-0x0000000181C2D170
	}
}
