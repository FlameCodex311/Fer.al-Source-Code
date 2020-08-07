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
	public class ConstraintRotationOffset : Constraint // TypeDefIndex: 9868
	{
		// Fields
		public Quaternion offset; // 0x20
		private Quaternion defaultRotation; // 0x30
		private Quaternion defaultLocalRotation; // 0x40
		private Quaternion lastLocalRotation; // 0x50
		private Quaternion defaultTargetLocalRotation; // 0x60
		private bool initiated; // 0x70
	
		// Properties
		private bool rotationChanged { get; } // 0x00000001814266A0-0x0000000181426740 
	
		// Constructors
		public ConstraintRotationOffset(); // 0x0000000180373240-0x0000000180373250
		public ConstraintRotationOffset(Transform transform); // 0x0000000180400150-0x0000000180400180
	
		// Methods
		public override void UpdateConstraint(); // 0x00000001814263F0-0x00000001814266A0
	}
}
