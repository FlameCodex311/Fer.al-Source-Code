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
	public class ConstraintRotationOffset : Constraint // TypeDefIndex: 9334
	{
		// Fields
		public Quaternion offset; // 0x20
		private Quaternion defaultRotation; // 0x30
		private Quaternion defaultLocalRotation; // 0x40
		private Quaternion lastLocalRotation; // 0x50
		private Quaternion defaultTargetLocalRotation; // 0x60
		private bool initiated; // 0x70
	
		// Properties
		private bool rotationChanged { get; } // 0x0000000181820770-0x0000000181820810 
	
		// Constructors
		public ConstraintRotationOffset(); // 0x000000018036B6C0-0x000000018036B6D0
		public ConstraintRotationOffset(Transform transform); // 0x000000018037D3F0-0x000000018037D420
	
		// Methods
		public override void UpdateConstraint(); // 0x00000001818204B0-0x0000000181820770
	}
}
