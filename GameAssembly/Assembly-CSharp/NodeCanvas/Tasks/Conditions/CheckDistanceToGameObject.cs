/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800C9510-0x00000001800C9570
	[Name] // 0x00000001800C9510-0x00000001800C9570
	public class CheckDistanceToGameObject : ConditionTask<Transform> // TypeDefIndex: 14133
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> checkTarget; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> distance; // 0x78
		[SliderField] // 0x00000001800C58A0-0x00000001800C58C0
		public float floatingPoint; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018124FF50-0x0000000181250190 
	
		// Constructors
		public CheckDistanceToGameObject(); // 0x000000018124FEE0-0x000000018124FF50
	
		// Methods
		protected override bool OnCheck(); // 0x000000018124FC70-0x000000018124FDF0
		public override void OnDrawGizmosSelected(); // 0x000000018124FDF0-0x000000018124FEE0
	}
}
