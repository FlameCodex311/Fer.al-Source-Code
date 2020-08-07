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
	[Category] // 0x000000018022EB90-0x000000018022EC10
	[Description] // 0x000000018022EB90-0x000000018022EC10
	[Name] // 0x000000018022EB90-0x000000018022EC10
	public class IsInFront : ConditionTask<Transform> // TypeDefIndex: 15228
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> checkTarget; // 0x68
		[SliderField] // 0x0000000180229F50-0x0000000180229F70
		public BBParameter<float> viewAngle; // 0x70
	
		// Properties
		protected override string info { get; } // 0x00000001807FFBD0-0x00000001807FFC10 
	
		// Constructors
		public IsInFront(); // 0x00000001807FFB80-0x00000001807FFBD0
	
		// Methods
		protected override bool OnCheck(); // 0x00000001807FF770-0x00000001807FF930
		public override void OnDrawGizmosSelected(); // 0x00000001807FF930-0x00000001807FFB80
	}
}
