﻿/*
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
	public class IKSolverArm : IKSolver // TypeDefIndex: 9388
	{
		// Fields
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float IKRotationWeight; // 0x58
		public Quaternion IKRotation; // 0x5C
		public Point chest; // 0x70
		public Point shoulder; // 0x78
		public Point upperArm; // 0x80
		public Point forearm; // 0x88
		public Point hand; // 0x90
		public bool isLeft; // 0x98
		public IKSolverVR.Arm arm; // 0xA0
		private Vector3[] positions; // 0xA8
		private Quaternion[] rotations; // 0xB0
	
		// Constructors
		public IKSolverArm(); // 0x0000000181C307D0-0x0000000181C30AE0
	
		// Methods
		public override bool IsValid(ref string message); // 0x0000000181C2F4D0-0x0000000181C2F9C0
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root); // 0x0000000181C30190-0x0000000181C30230
		public override Point[] GetPoints(); // 0x0000000181C2F2B0-0x0000000181C2F4D0
		public override Point GetPoint(Transform transform); // 0x0000000181C2F070-0x0000000181C2F2B0
		public override void StoreDefaultLocalState(); // 0x0000000181C302D0-0x0000000181C304B0
		public override void FixTransforms(); // 0x0000000181C2EFF0-0x0000000181C2F070
		protected override void OnInitiate(); // 0x0000000181C2F9C0-0x0000000181C2FA60
		protected override void OnUpdate(); // 0x0000000181C2FA60-0x0000000181C2FB10
		private void Solve(); // 0x0000000181C30230-0x0000000181C302D0
		private void Read(); // 0x0000000181C2FB10-0x0000000181C30190
		private void Write(); // 0x0000000181C304B0-0x0000000181C307D0
	}
}
