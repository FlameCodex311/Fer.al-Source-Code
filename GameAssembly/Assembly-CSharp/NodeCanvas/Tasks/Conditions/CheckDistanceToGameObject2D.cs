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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x000000018022B9C0-0x000000018022BA20
	[Name] // 0x000000018022B9C0-0x000000018022BA20
	public class CheckDistanceToGameObject2D : ConditionTask<Transform> // TypeDefIndex: 15220
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> checkTarget; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> distance; // 0x78
		[SliderField] // 0x0000000180225480-0x00000001802254A0
		public float floatingPoint; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180798F00-0x0000000180799120 
	
		// Constructors
		public CheckDistanceToGameObject2D(); // 0x0000000180798E90-0x0000000180798F00
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180798BE0-0x0000000180798D50
		public override void OnDrawGizmosSelected(); // 0x0000000180798D50-0x0000000180798E90
	}
}
