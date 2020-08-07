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
	public class IKConstraintBend // TypeDefIndex: 9907
	{
		// Fields
		public Transform bone1; // 0x10
		public Transform bone2; // 0x18
		public Transform bone3; // 0x20
		public Transform bendGoal; // 0x28
		public Vector3 direction; // 0x30
		public Quaternion rotationOffset; // 0x3C
		[Range] // 0x00000001801D3630-0x00000001801D3650
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <initiated>k__BackingField; // 0x84
		private bool limbOrientationsSet; // 0x85
	
		// Properties
		public bool initiated { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180440E20-0x0000000180440E30 0x00000001819E0860-0x00000001819E0870
	
		// Constructors
		public IKConstraintBend(); // 0x00000001819E0730-0x00000001819E07B0
		public IKConstraintBend(Transform bone1, Transform bone2, Transform bone3); // 0x00000001819E07B0-0x00000001819E0860
	
		// Methods
		public bool IsValid(IKSolverFullBody solver, Warning.Logger logger); // 0x00000001819DF880-0x00000001819DFA60
		public void SetBones(Transform bone1, Transform bone2, Transform bone3); // 0x00000001819E04C0-0x00000001819E04D0
		public void Initiate(IKSolverFullBody solver); // 0x00000001819DF4B0-0x00000001819DF880
		public void SetLimbOrientation(Vector3 upper, Vector3 lower, Vector3 last); // 0x00000001819E04D0-0x00000001819E0730
		public void LimitBend(float solverWeight, float positionWeight); // 0x00000001819DFA60-0x00000001819E0080
		public Vector3 GetDir(IKSolverFullBody solver); // 0x00000001819DED00-0x00000001819DF4B0
		private Vector3 OrthoToLimb(IKSolverFullBody solver, Vector3 tangent); // 0x00000001819E02A0-0x00000001819E04C0
		private Vector3 OrthoToBone1(IKSolverFullBody solver, Vector3 tangent); // 0x00000001819E0080-0x00000001819E02A0
	}
}
