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
	public class IKSolverArm : IKSolver // TypeDefIndex: 9922
	{
		// Fields
		[Range] // 0x00000001801D3630-0x00000001801D3650
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
		public IKSolverArm(); // 0x00000001819EB580-0x00000001819EB890
	
		// Methods
		public override bool IsValid(ref string message); // 0x00000001819EA360-0x00000001819EA820
		public bool SetChain(Transform chest, Transform shoulder, Transform upperArm, Transform forearm, Transform hand, Transform root); // 0x00000001819EAF80-0x00000001819EB020
		public override Point[] GetPoints(); // 0x00000001819EA160-0x00000001819EA360
		public override Point GetPoint(Transform transform); // 0x00000001819E9F30-0x00000001819EA160
		public override void StoreDefaultLocalState(); // 0x00000001819EB0C0-0x00000001819EB280
		public override void FixTransforms(); // 0x00000001819E9EB0-0x00000001819E9F30
		protected override void OnInitiate(); // 0x00000001819EA820-0x00000001819EA8B0
		protected override void OnUpdate(); // 0x00000001819EA8B0-0x00000001819EA960
		private void Solve(); // 0x00000001819EB020-0x00000001819EB0C0
		private void Read(); // 0x00000001819EA960-0x00000001819EAF80
		private void Write(); // 0x00000001819EB280-0x00000001819EB580
	}
}
