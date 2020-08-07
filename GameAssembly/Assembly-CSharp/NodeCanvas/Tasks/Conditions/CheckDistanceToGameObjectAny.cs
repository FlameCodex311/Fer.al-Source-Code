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
	[Category] // 0x000000018022C2B0-0x000000018022C310
	[Name] // 0x000000018022C2B0-0x000000018022C310
	public class CheckDistanceToGameObjectAny : ConditionTask<Transform> // TypeDefIndex: 15221
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
		protected override string info { get; } // 0x000000018079A160-0x000000018079A380 
	
		// Constructors
		public CheckDistanceToGameObjectAny(); // 0x000000018079A0F0-0x000000018079A160
	
		// Methods
		protected override bool OnCheck(); // 0x0000000180799A80-0x0000000180799F00
		public override void OnDrawGizmosSelected(); // 0x0000000180799F00-0x0000000180799FF0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <OnCheck>b__8_0(GameObject x); // 0x0000000180799FF0-0x000000018079A0F0
	}
}
