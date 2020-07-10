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
	public class IKConstraintBend // TypeDefIndex: 9373
	{
		// Fields
		public Transform bone1; // 0x10
		public Transform bone2; // 0x18
		public Transform bone3; // 0x20
		public Transform bendGoal; // 0x28
		public Vector3 direction; // 0x30
		public Quaternion rotationOffset; // 0x3C
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float weight; // 0x4C
		public Vector3 defaultLocalDirection; // 0x50
		public Vector3 defaultChildDirection; // 0x5C
		[NonSerialized]
		public float clampF; // 0x68
		private int chainIndex1; // 0x6C
		private int nodeIndex1; // 0x70
		private int chainIndex2; // 0x74
		private int nodeIndex2; // 0x78
		private int chainIndex3; // 0x7C
		private int nodeIndex3; // 0x80
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <initiated>k__BackingField; // 0x84
		private bool limbOrientationsSet; // 0x85
	
		// Properties
		public bool initiated { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180478580-0x0000000180478590 0x0000000181C26040-0x0000000181C26050
	
		// Constructors
		public IKConstraintBend(); // 0x0000000181C25F10-0x0000000181C25F90
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3); // 0x0000000181C25F90-0x0000000181C26040
	
		// Methods
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger); // 0x0000000181C251B0-0x0000000181C25390
		public void SetBones(Transform bone1, Transform bone2, Transform bone3); // 0x0000000181C25CA0-0x0000000181C25CB0
		public void Initiate(IKSolverFullBody solver); // 0x0000000181C24C10-0x0000000181C251B0
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last); // 0x0000000181C25CB0-0x0000000181C25F10
		public void LimitBend(float solverWeight, float positionWeight); // 0x0000000181C25390-0x0000000181C259C0
		public Vector3 GetDir(IKSolverFullBody solver); // 0x0000000181C24440-0x0000000181C24C10
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent); // 0x0000000181C25B30-0x0000000181C25CA0
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent); // 0x0000000181C259C0-0x0000000181C25B30
	}
}
