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
	public class ConstraintPositionOffset : Constraint // TypeDefIndex: 9332
	{
		// Fields
		public Vector3 offset; // 0x20
		private Vector3 defaultLocalPosition; // 0x2C
		private Vector3 lastLocalPosition; // 0x38
		private bool initiated; // 0x44
	
		// Properties
		private bool positionChanged { get; } // 0x0000000181820240-0x0000000181820310 
	
		// Constructors
		public ConstraintPositionOffset(); // 0x000000018036B6C0-0x000000018036B6D0
		public ConstraintPositionOffset(Transform transform); // 0x000000018037D3F0-0x000000018037D420
	
		// Methods
		public override void UpdateConstraint(); // 0x000000018181FF10-0x0000000181820240
	}
}
