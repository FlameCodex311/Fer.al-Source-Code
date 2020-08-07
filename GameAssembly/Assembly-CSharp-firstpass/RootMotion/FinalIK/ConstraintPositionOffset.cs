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
	public class ConstraintPositionOffset : Constraint // TypeDefIndex: 9866
	{
		// Fields
		public Vector3 offset; // 0x20
		private Vector3 defaultLocalPosition; // 0x2C
		private Vector3 lastLocalPosition; // 0x38
		private bool initiated; // 0x44
	
		// Properties
		private bool positionChanged { get; } // 0x0000000181426190-0x0000000181426250 
	
		// Constructors
		public ConstraintPositionOffset(); // 0x0000000180373240-0x0000000180373250
		public ConstraintPositionOffset(Transform transform); // 0x0000000180400150-0x0000000180400180
	
		// Methods
		public override void UpdateConstraint(); // 0x0000000181425E60-0x0000000181426190
	}
}
