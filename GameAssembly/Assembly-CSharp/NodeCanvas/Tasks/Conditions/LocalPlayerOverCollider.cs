/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800DF3C0-0x00000001800DF420
	[Description] // 0x00000001800DF3C0-0x00000001800DF420
	public class LocalPlayerOverCollider : ConditionTask<Collider> // TypeDefIndex: 14181
	{
		// Fields
		public BBParameter<float> checkRate; // 0x68
		private float _checkRate; // 0x70
		private CharacterController charController; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001812582C0-0x00000001812583A0 
	
		// Constructors
		public LocalPlayerOverCollider(); // 0x0000000181258270-0x00000001812582C0
	
		// Methods
		protected override bool OnCheck(); // 0x0000000181257F90-0x0000000181258270
	}
}
