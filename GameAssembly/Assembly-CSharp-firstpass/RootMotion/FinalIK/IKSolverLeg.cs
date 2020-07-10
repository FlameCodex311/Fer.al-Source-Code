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
	public class IKSolverLeg : IKSolver // TypeDefIndex: 9397
	{
		// Fields
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float IKRotationWeight; // 0x58
		public Quaternion IKRotation; // 0x5C
		public Point pelvis; // 0x70
		public Point thigh; // 0x78
		public Point calf; // 0x80
		public Point foot; // 0x88
		public Point toe; // 0x90
		public IKSolverVR.Leg leg; // 0x98
		public Vector3 heelOffset; // 0xA0
		private Vector3[] positions; // 0xB0
		private Quaternion[] rotations; // 0xB8
	
		// Constructors
		public IKSolverLeg(); // 0x0000000181D74F10-0x0000000181D75070
	
		// Methods
		public override bool IsValid(ref string message); // 0x0000000181D73C00-0x0000000181D740B0
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root); // 0x0000000181C30190-0x0000000181C30230
		public override Point[] GetPoints(); // 0x0000000181D739E0-0x0000000181D73C00
		public override Point GetPoint(Transform transform); // 0x0000000181D737A0-0x0000000181D739E0
		public override void StoreDefaultLocalState(); // 0x0000000181D74B80-0x0000000181D74BF0
		public override void FixTransforms(); // 0x0000000181C2EFF0-0x0000000181C2F070
		protected override void OnInitiate(); // 0x0000000181D740B0-0x0000000181D74150
		protected override void OnUpdate(); // 0x0000000181D74150-0x0000000181D742E0
		private void Solve(); // 0x0000000181D74A00-0x0000000181D74B80
		private void Read(); // 0x0000000181D742E0-0x0000000181D74A00
		private void Write(); // 0x0000000181D74BF0-0x0000000181D74F10
	}
}
