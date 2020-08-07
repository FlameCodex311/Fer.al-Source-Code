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
	public class Finger // TypeDefIndex: 9870
	{
		// Fields
		[Range] // 0x0000000180223950-0x00000001802239B0
		[Tooltip] // 0x0000000180223950-0x00000001802239B0
		public float weight; // 0x10
		[Range] // 0x0000000180223B00-0x0000000180223B60
		[Tooltip] // 0x0000000180223B00-0x0000000180223B60
		public float rotationWeight; // 0x14
		[Tooltip] // 0x0000000180223D60-0x0000000180223D90
		public DOF rotationDOF; // 0x18
		[Tooltip] // 0x0000000180223E50-0x0000000180223E80
		public Transform bone1; // 0x20
		[Tooltip] // 0x00000001802240E0-0x0000000180224110
		public Transform bone2; // 0x28
		[Tooltip] // 0x0000000180225640-0x0000000180225670
		public Transform bone3; // 0x30
		[Tooltip] // 0x0000000180225760-0x0000000180225790
		public Transform tip; // 0x38
		[Tooltip] // 0x0000000180225950-0x0000000180225980
		public Transform target; // 0x40
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <initiated>k__BackingField; // 0x48
		private IKSolverLimb solver; // 0x50
		private Quaternion bone3RelativeToTarget; // 0x58
		private Vector3 bone3DefaultLocalPosition; // 0x68
		private Quaternion bone3DefaultLocalRotation; // 0x74
		private Vector3 bone1Axis; // 0x84
		private Vector3 tipAxis; // 0x90
	
		// Properties
		public bool initiated { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803C9D60-0x00000001803C9D70 0x00000001803C9DD0-0x00000001803C9DE0
		public Vector3 IKPosition { get; set; } // 0x0000000181434820-0x0000000181434850 0x0000000181434880-0x00000001814348B0
		public Quaternion IKRotation { get; set; } // 0x0000000181434850-0x0000000181434880 0x00000001814348B0-0x00000001814348D0
	
		// Nested types
		[Serializable]
		public enum DOF // TypeDefIndex: 9871
		{
			One = 0,
			Three = 1
		}
	
		// Constructors
		public Finger(); // 0x0000000181434800-0x0000000181434820
	
		// Methods
		public bool IsValid(ref string errorMessage); // 0x0000000181434160-0x0000000181434260
		public void Initiate(Transform hand, int index); // 0x0000000181433C10-0x0000000181434160
		public void FixTransforms(); // 0x0000000181433B10-0x0000000181433C10
		public void StoreDefaultLocalState(); // 0x0000000181434260-0x0000000181434350
		public void Update(float masterWeight); // 0x0000000181434350-0x0000000181434800
	}
}
