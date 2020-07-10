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
	[Category] // 0x00000001800DEFB0-0x00000001800DF010
	[Description] // 0x00000001800DEFB0-0x00000001800DF010
	public class LocalPlayerInRange : ConditionTask<Transform> // TypeDefIndex: 14180
	{
		// Fields
		public BBParameter<float> range; // 0x68
	
		// Properties
		protected override string info { get; } // 0x0000000181257CF0-0x0000000181257F90 
	
		// Constructors
		public LocalPlayerInRange(); // 0x0000000181257CB0-0x0000000181257CF0
	
		// Methods
		protected override bool OnCheck(); // 0x00000001812579F0-0x0000000181257B80
		public override void OnDrawGizmosSelected(); // 0x0000000181257B80-0x0000000181257CB0
	}
}
