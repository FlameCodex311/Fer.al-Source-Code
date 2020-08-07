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
	public class IKSolverLimb : IKSolverTrigonometric // TypeDefIndex: 9932
	{
		// Fields
		public AvatarIKGoal goal; // 0xA8
		public BendModifier bendModifier; // 0xAC
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float maintainRotationWeight; // 0xB0
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float bendModifierWeight; // 0xB4
		public Transform bendGoal; // 0xB8
		private bool maintainBendFor1Frame; // 0xC0
		private bool maintainRotationFor1Frame; // 0xC1
		private Quaternion defaultRootRotation; // 0xC4
		private Quaternion parentDefaultRotation; // 0xD4
		private Quaternion bone3RotationBeforeSolve; // 0xE4
		private Quaternion maintainRotation; // 0xF4
		private Quaternion bone3DefaultRotation; // 0x104
		private Vector3 _bendNormal; // 0x114
		private Vector3 animationNormal; // 0x120
		private AxisDirection[] axisDirectionsLeft; // 0x130
		private AxisDirection[] axisDirectionsRight; // 0x138
	
		// Properties
		private AxisDirection[] axisDirections { get; } // 0x0000000181AA5520-0x0000000181AA5540 
	
		// Nested types
		[Serializable]
		public enum BendModifier // TypeDefIndex: 9933
		{
			Animation = 0,
			Target = 1,
			Parent = 2,
			Arm = 3,
			Goal = 4
		}
	
		[Serializable]
		public struct AxisDirection // TypeDefIndex: 9934
		{
			// Fields
			public Vector3 direction; // 0x00
			public Vector3 axis; // 0x0C
			public float dot; // 0x18
	
			// Constructors
			public AxisDirection(Vector3 direction, Vector3 axis); // 0x000000018010E410-0x000000018010E490
		}
	
		// Constructors
		public IKSolverLimb(); // 0x0000000181AA54B0-0x0000000181AA5520
		public IKSolverLimb(AvatarIKGoal goal); // 0x0000000181AA5430-0x0000000181AA54B0
	
		// Methods
		public void MaintainRotation(); // 0x0000000181AA47B0-0x0000000181AA4810
		public void MaintainBend(); // 0x0000000181AA4760-0x0000000181AA47B0
		protected override void OnInitiateVirtual(); // 0x0000000181AA4810-0x0000000181AA4C90
		protected override void OnUpdateVirtual(); // 0x0000000181AA4E10-0x0000000181AA4F70
		protected override void OnPostSolveVirtual(); // 0x0000000181AA4C90-0x0000000181AA4E10
		private void StoreAxisDirections(ref AxisDirection[] axisDirections); // 0x0000000181AA4F70-0x0000000181AA5430
		private Vector3 GetModifiedBendNormal(); // 0x0000000181AA38D0-0x0000000181AA4760
	}
}
