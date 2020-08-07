/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x0000000180242D20-0x0000000180242D80
	[Description] // 0x0000000180242D20-0x0000000180242D80
	public class LocalPlayerOverCollider : ConditionTask<Collider> // TypeDefIndex: 15284
	{
		// Fields
		public BBParameter<float> checkRate; // 0x68
		private float _checkRate; // 0x70
		private CharacterController charController; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180800960-0x0000000180800A30 
	
		// Constructors
		public LocalPlayerOverCollider(); // 0x0000000180800910-0x0000000180800960
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180800640-0x0000000180800910
	}
}
