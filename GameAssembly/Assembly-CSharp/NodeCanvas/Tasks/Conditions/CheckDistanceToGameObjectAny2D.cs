/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x000000018022CC70-0x000000018022CCD0
	[Name] // 0x000000018022CC70-0x000000018022CCD0
	public class CheckDistanceToGameObjectAny2D : ConditionTask<Transform> // TypeDefIndex: 15222
	{
		// Fields
		public BBParameter<List<GameObject>> targetObjects; // 0x68
		public CompareMethod checkType; // 0x70
		public BBParameter<float> distance; // 0x78
		[SliderField] // 0x0000000180225480-0x00000001802254A0
		public float floatingPoint; // 0x80
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<List<GameObject>> allResults; // 0x88
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> closerResult; // 0x90
	
		// Properties
		protected override string info { get; } // 0x0000000180799860-0x0000000180799A80 
	
		// Constructors
		public CheckDistanceToGameObjectAny2D(); // 0x00000001807997F0-0x0000000180799860
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180799120-0x00000001807995A0
		public override void OnDrawGizmosSelected(); // 0x00000001807995A0-0x00000001807996E0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <OnCheck>b__8_0(GameObject x); // 0x00000001807996E0-0x00000001807997F0
	}
}
