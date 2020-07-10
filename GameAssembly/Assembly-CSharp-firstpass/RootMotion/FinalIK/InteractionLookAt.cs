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
	public class InteractionLookAt // TypeDefIndex: 9418
	{
		// Fields
		[Tooltip] // 0x000000018015BA40-0x000000018015BA70
		public LookAtIK ik; // 0x10
		[Tooltip] // 0x000000018015BC80-0x000000018015BCB0
		public float lerpSpeed; // 0x18
		[Tooltip] // 0x000000018015BE80-0x000000018015BEB0
		public float weightSpeed; // 0x1C
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
		public bool isPaused; // 0x20
		private Transform lookAtTarget; // 0x28
		private float stopLookTime; // 0x30
		private float weight; // 0x34
		private bool firstFBBIKSolve; // 0x38
	
		// Constructors
		public InteractionLookAt(); // 0x0000000181AF8150-0x0000000181AF8170
	
		// Methods
		public void Look(Transform target, float time); // 0x0000000181AF7890-0x0000000181AF7AD0
		public void OnFixTransforms(); // 0x0000000181AF7AD0-0x0000000181AF7B80
		public void Update(); // 0x0000000181AF7E40-0x0000000181AF8150
		public void SolveSpine(); // 0x0000000181AF7C90-0x0000000181AF7E40
		public void SolveHead(); // 0x0000000181AF7B80-0x0000000181AF7C90
	}
}
