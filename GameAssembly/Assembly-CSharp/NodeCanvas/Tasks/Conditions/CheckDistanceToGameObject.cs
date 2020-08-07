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
	[Category] // 0x000000018022B470-0x000000018022B4D0
	[Name] // 0x000000018022B470-0x000000018022B4D0
	public class CheckDistanceToGameObject : ConditionTask<Transform> // TypeDefIndex: 15219
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> checkTarget; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> distance; // 0x78
		[SliderField] // 0x0000000180225480-0x00000001802254A0
		public float floatingPoint; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018079A660-0x000000018079A880 
	
		// Constructors
		public CheckDistanceToGameObject(); // 0x000000018079A5F0-0x000000018079A660
	
		// Methods
		protected override bool OnCheck(); // 0x000000018079A380-0x000000018079A500
		public override void OnDrawGizmosSelected(); // 0x000000018079A500-0x000000018079A5F0
	}
}
