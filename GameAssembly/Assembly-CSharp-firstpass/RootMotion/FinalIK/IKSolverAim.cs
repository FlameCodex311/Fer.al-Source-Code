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
	public class IKSolverAim : IKSolverHeuristic // TypeDefIndex: 9921
	{
		// Fields
		public Transform transform; // 0x88
		public Vector3 axis; // 0x90
		public Vector3 poleAxis; // 0x9C
		public Vector3 polePosition; // 0xA8
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float poleWeight; // 0xB4
		public Transform poleTarget; // 0xB8
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float clampWeight; // 0xC0
		[Range] // 0x0000000180247A20-0x0000000180247A40
		public int clampSmoothing; // 0xC4
		public IterationDelegate OnPreIteration; // 0xC8
		private float step; // 0xD0
		private Vector3 clampedIKPosition; // 0xD4
		private RotationLimit transformLimit; // 0xE0
		private Transform lastTransform; // 0xE8
	
		// Properties
		public Vector3 transformAxis { get; } // 0x00000001819E9CF0-0x00000001819E9DD0 
		public Vector3 transformPoleAxis { get; } // 0x00000001819E9DD0-0x00000001819E9EB0 
		protected override int minBones { get; } // 0x000000018058C710-0x000000018058C720 
		protected override Vector3 localDirection { get; } // 0x00000001819E9BE0-0x00000001819E9CF0 
	
		// Constructors
		public IKSolverAim(); // 0x00000001819E9B30-0x00000001819E9BE0
	
		// Methods
		public float GetAngle(); // 0x00000001819E80B0-0x00000001819E81E0
		protected override void OnInitiate(); // 0x00000001819E8740-0x00000001819E8AE0
		protected override void OnUpdate(); // 0x00000001819E8AE0-0x00000001819E9230
		private void Solve(); // 0x00000001819E9960-0x00000001819E9B30
		private Vector3 GetClampedIKPosition(); // 0x00000001819E81E0-0x00000001819E8740
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight); // 0x00000001819E9230-0x00000001819E9960
	}
}
