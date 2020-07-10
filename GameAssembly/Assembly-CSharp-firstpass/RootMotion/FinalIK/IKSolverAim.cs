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
	public class IKSolverAim : IKSolverHeuristic // TypeDefIndex: 9387
	{
		// Fields
		public Transform transform; // 0x88
		public Vector3 axis; // 0x90
		public Vector3 poleAxis; // 0x9C
		public Vector3 polePosition; // 0xA8
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float poleWeight; // 0xB4
		public Transform poleTarget; // 0xB8
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float clampWeight; // 0xC0
		[Range] // 0x000000018010BD70-0x000000018010BD90
		public int clampSmoothing; // 0xC4
		public IterationDelegate OnPreIteration; // 0xC8
		private float step; // 0xD0
		private Vector3 clampedIKPosition; // 0xD4
		private RotationLimit transformLimit; // 0xE0
		private Transform lastTransform; // 0xE8
	
		// Properties
		public Vector3 transformAxis { get; } // 0x0000000181C2EE30-0x0000000181C2EF10 
		public Vector3 transformPoleAxis { get; } // 0x0000000181C2EF10-0x0000000181C2EFF0 
		protected override int minBones { get; } // 0x000000018042E670-0x000000018042E680 
		protected override Vector3 localDirection { get; } // 0x0000000181C2ED10-0x0000000181C2EE30 
	
		// Constructors
		public IKSolverAim(); // 0x0000000181C2EC60-0x0000000181C2ED10
	
		// Methods
		public float GetAngle(); // 0x0000000181C2D170-0x0000000181C2D2A0
		protected override void OnInitiate(); // 0x0000000181C2D810-0x0000000181C2DBC0
		protected override void OnUpdate(); // 0x0000000181C2DBC0-0x0000000181C2E320
		private void Solve(); // 0x0000000181C2EA70-0x0000000181C2EC60
		private Vector3 GetClampedIKPosition(); // 0x0000000181C2D2A0-0x0000000181C2D810
		private void RotateToTarget(Vector3 targetPosition, Bone bone, float weight); // 0x0000000181C2E320-0x0000000181C2EA70
	}
}
