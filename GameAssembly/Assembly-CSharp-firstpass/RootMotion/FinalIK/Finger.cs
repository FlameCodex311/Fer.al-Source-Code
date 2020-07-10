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
	public class Finger // TypeDefIndex: 9336
	{
		// Fields
		[Range] // 0x000000018011EAA0-0x000000018011EB00
		[Tooltip] // 0x000000018011EAA0-0x000000018011EB00
		public float weight; // 0x10
		[Range] // 0x000000018011ECA0-0x000000018011ED00
		[Tooltip] // 0x000000018011ECA0-0x000000018011ED00
		public float rotationWeight; // 0x14
		[Tooltip] // 0x000000018011F000-0x000000018011F030
		public DOF rotationDOF; // 0x18
		[Tooltip] // 0x000000018011F160-0x000000018011F190
		public Transform bone1; // 0x20
		[Tooltip] // 0x000000018011F330-0x000000018011F360
		public Transform bone2; // 0x28
		[Tooltip] // 0x000000018011F4D0-0x000000018011F500
		public Transform bone3; // 0x30
		[Tooltip] // 0x000000018011F840-0x000000018011F870
		public Transform tip; // 0x38
		[Tooltip] // 0x000000018011F940-0x000000018011F970
		public Transform target; // 0x40
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <initiated>k__BackingField; // 0x48
		private IKSolverLimb solver; // 0x50
		private Quaternion bone3RelativeToTarget; // 0x58
		private Vector3 bone3DefaultLocalPosition; // 0x68
		private Quaternion bone3DefaultLocalRotation; // 0x74
		private Vector3 bone1Axis; // 0x84
		private Vector3 tipAxis; // 0x90
	
		// Properties
		public bool initiated { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001805E3A60-0x00000001805E3A70 0x000000018082AC70-0x000000018082AC80
		public Vector3 IKPosition { get; set; } // 0x0000000181C16380-0x0000000181C163B0 0x0000000181C163E0-0x0000000181C16410
		public Quaternion IKRotation { get; set; } // 0x0000000181C163B0-0x0000000181C163E0 0x0000000181C16410-0x0000000181C16440
	
		// Nested types
		[Serializable]
		public enum DOF // TypeDefIndex: 9337
		{
			One = 0,
			Three = 1
		}
	
		// Constructors
		public Finger(); // 0x0000000181C16360-0x0000000181C16380
	
		// Methods
		public bool IsValid(ref string errorMessage); // 0x0000000181C15CB0-0x0000000181C15DB0
		public void Initiate(Transform hand, int index); // 0x0000000181C15740-0x0000000181C15CB0
		public void FixTransforms(); // 0x0000000181C15640-0x0000000181C15740
		public void StoreDefaultLocalState(); // 0x0000000181C15DB0-0x0000000181C15EA0
		public void Update(float masterWeight); // 0x0000000181C15EA0-0x0000000181C16360
	}
}
