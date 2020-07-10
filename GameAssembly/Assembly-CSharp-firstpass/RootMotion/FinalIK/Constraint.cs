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
	public abstract class Constraint // TypeDefIndex: 9330
	{
		// Fields
		public Transform transform; // 0x10
		public float weight; // 0x18
	
		// Properties
		public bool isValid { get; } // 0x0000000181820980-0x00000001818209E0 
	
		// Constructors
		protected Constraint(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public abstract void UpdateConstraint();
	}
}
