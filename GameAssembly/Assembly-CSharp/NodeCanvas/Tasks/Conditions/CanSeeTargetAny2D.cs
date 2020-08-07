/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001802298E0-0x0000000180229940
	[Description] // 0x00000001802298E0-0x0000000180229940
	public class CanSeeTargetAny2D : ConditionTask<Transform> // TypeDefIndex: 15218
	{
		// Fields
		public BBParameter<List<GameObject>> targetObjects; // 0x68
		public BBParameter<float> maxDistance; // 0x70
		public BBParameter<float> awarnessDistance; // 0x78
		[SliderField] // 0x0000000180229F50-0x0000000180229F70
		public BBParameter<float> viewAngle; // 0x80
		public Vector2 offset; // 0x88
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<List<GameObject>> allResults; // 0x90
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> closerResult; // 0x98
	
		// Properties
		protected override string info { get; } // 0x0000000180794530-0x0000000180794570 
	
		// Constructors
		public CanSeeTargetAny2D(); // 0x00000001807944B0-0x0000000180794530
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180793380-0x0000000180793C40
		public override void OnDrawGizmosSelected(); // 0x0000000180793C40-0x00000001807943B0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <OnCheck>b__9_0(GameObject x); // 0x00000001807943B0-0x00000001807944B0
	}
}
