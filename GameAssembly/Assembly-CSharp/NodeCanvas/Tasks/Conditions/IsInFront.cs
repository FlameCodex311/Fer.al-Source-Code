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
	[Category] // 0x00000001800CB400-0x00000001800CB480
	[Description] // 0x00000001800CB400-0x00000001800CB480
	[Name] // 0x00000001800CB400-0x00000001800CB480
	public class IsInFront : ConditionTask<Transform> // TypeDefIndex: 14139
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> checkTarget; // 0x68
		[SliderField] // 0x00000001800C9340-0x00000001800C9360
		public BBParameter<float> viewAngle; // 0x70
	
		// Properties
		protected override string info { get; } // 0x0000000181257730-0x0000000181257770 
	
		// Constructors
		public IsInFront(); // 0x00000001812576E0-0x0000000181257730
	
		// Methods
		protected override bool OnCheck(); // 0x00000001812572B0-0x0000000181257480
		public override void OnDrawGizmosSelected(); // 0x0000000181257480-0x00000001812576E0
	}
}
