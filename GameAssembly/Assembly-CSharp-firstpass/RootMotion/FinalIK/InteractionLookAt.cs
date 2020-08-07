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
	public class InteractionLookAt // TypeDefIndex: 9952
	{
		// Fields
		[Tooltip] // 0x000000018025CCB0-0x000000018025CCE0
		public LookAtIK ik; // 0x10
		[Tooltip] // 0x000000018025CED0-0x000000018025CF00
		public float lerpSpeed; // 0x18
		[Tooltip] // 0x000000018025D0C0-0x000000018025D0F0
		public float weightSpeed; // 0x1C
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public bool isPaused; // 0x20
		private Transform lookAtTarget; // 0x28
		private float stopLookTime; // 0x30
		private float weight; // 0x34
		private bool firstFBBIKSolve; // 0x38
	
		// Constructors
		public InteractionLookAt(); // 0x0000000181630B90-0x0000000181630BB0
	
		// Methods
		public void Look(Transform target, float time); // 0x0000000181630300-0x0000000181630530
		public void OnFixTransforms(); // 0x0000000181630530-0x00000001816305E0
		public void Update(); // 0x0000000181630890-0x0000000181630B90
		public void SolveSpine(); // 0x00000001816306F0-0x0000000181630890
		public void SolveHead(); // 0x00000001816305E0-0x00000001816306F0
	}
}
