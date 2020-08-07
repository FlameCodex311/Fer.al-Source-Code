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
	public class IKSolverLeg : IKSolver // TypeDefIndex: 9931
	{
		// Fields
		[Range] // 0x00000001801D3630-0x00000001801D3650
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
		public IKSolverLeg(); // 0x0000000181AA3770-0x0000000181AA38D0
	
		// Methods
		public override bool IsValid(ref string message); // 0x0000000181AA2540-0x0000000181AA29C0
		public bool SetChain(Transform pelvis, Transform thigh, Transform calf, Transform foot, Transform toe, Transform root); // 0x00000001819EAF80-0x00000001819EB020
		public override Point[] GetPoints(); // 0x0000000181AA2340-0x0000000181AA2540
		public override Point GetPoint(Transform transform); // 0x0000000181AA2110-0x0000000181AA2340
		public override void StoreDefaultLocalState(); // 0x0000000181AA3400-0x0000000181AA3470
		public override void FixTransforms(); // 0x00000001819E9EB0-0x00000001819E9F30
		protected override void OnInitiate(); // 0x0000000181AA29C0-0x0000000181AA2A50
		protected override void OnUpdate(); // 0x0000000181AA2A50-0x0000000181AA2BE0
		private void Solve(); // 0x0000000181AA3290-0x0000000181AA3400
		private void Read(); // 0x0000000181AA2BE0-0x0000000181AA3290
		private void Write(); // 0x0000000181AA3470-0x0000000181AA3770
	}
}
