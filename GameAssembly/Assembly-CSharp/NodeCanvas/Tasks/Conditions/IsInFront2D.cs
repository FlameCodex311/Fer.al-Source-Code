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
	[Category] // 0x000000018022F580-0x000000018022F600
	[Description] // 0x000000018022F580-0x000000018022F600
	[Name] // 0x000000018022F580-0x000000018022F600
	public class IsInFront2D : ConditionTask<Transform> // TypeDefIndex: 15229
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> checkTarget; // 0x68
		[SliderField] // 0x0000000180229F50-0x0000000180229F70
		public BBParameter<float> viewAngle; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001807FF730-0x00000001807FF770 
	
		// Constructors
		public IsInFront2D(); // 0x00000001807FF6E0-0x00000001807FF730
	
		// Methods
		protected override bool OnCheck(); // 0x00000001807FF290-0x00000001807FF440
		public override void OnDrawGizmosSelected(); // 0x00000001807FF440-0x00000001807FF6E0
	}
}
