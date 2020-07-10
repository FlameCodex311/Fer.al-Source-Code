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
	public class IKSolverLimb : IKSolverTrigonometric // TypeDefIndex: 9398
	{
		// Fields
		public AvatarIKGoal goal; // 0xA8
		public BendModifier bendModifier; // 0xAC
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float maintainRotationWeight; // 0xB0
		[Range] // 0x00000001800C20E0-0x00000001800C2100
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
		private AxisDirection[] axisDirections { get; } // 0x0000000181D76D40-0x0000000181D76D60 
	
		// Nested types
		[Serializable]
		public enum BendModifier // TypeDefIndex: 9399
		{
			Animation = 0,
			Target = 1,
			Parent = 2,
			Arm = 3,
			Goal = 4
		}
	
		[Serializable]
		public struct AxisDirection // TypeDefIndex: 9400
		{
			// Fields
			public Vector3 direction; // 0x00
			public Vector3 axis; // 0x0C
			public float dot; // 0x18
	
			// Constructors
			public AxisDirection(Vector3 direction, Vector3 axis); // 0x0000000180301A00-0x0000000180301A80
		}
	
		// Constructors
		public IKSolverLimb(); // 0x0000000181D76CD0-0x0000000181D76D40
		public IKSolverLimb(AvatarIKGoal goal); // 0x0000000181D76C50-0x0000000181D76CD0
	
		// Methods
		public void MaintainRotation(); // 0x0000000181D75FA0-0x0000000181D76000
		public void MaintainBend(); // 0x0000000181D75F40-0x0000000181D75FA0
		protected override void OnInitiateVirtual(); // 0x0000000181D76000-0x0000000181D764A0
		protected override void OnUpdateVirtual(); // 0x0000000181D76620-0x0000000181D76780
		protected override void OnPostSolveVirtual(); // 0x0000000181D764A0-0x0000000181D76620
		private void StoreAxisDirections(ref AxisDirection[] axisDirections); // 0x0000000181D76780-0x0000000181D76C50
		private Vector3 GetModifiedBendNormal(); // 0x0000000181D75070-0x0000000181D75F40
	}
}
