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

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180267470-0x00000001802674D0
	[Description] // 0x0000000180267470-0x00000001802674D0
	public class GetLinecastInfo2DAll : ActionTask<Transform> // TypeDefIndex: 15407
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> target; // 0x68
		public LayerMask mask; // 0x70
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<List<GameObject>> saveHitGameObjectsAs; // 0x78
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<List<float>> saveDistancesAs; // 0x80
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<List<Vector3>> savePointsAs; // 0x88
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<List<Vector3>> saveNormalsAs; // 0x90
		private RaycastHit2D[] hits; // 0x98
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15408
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<RaycastHit2D, GameObject> <>9__7_0; // 0x08
			public static Func<RaycastHit2D, float> <>9__7_1; // 0x10
			public static Func<RaycastHit2D, Vector3> <>9__7_3; // 0x18
	
			// Constructors
			static <>c(); // 0x0000000180BC1040-0x0000000180BC10A0
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal GameObject <OnExecute>b__7_0(RaycastHit2D h); // 0x0000000180BC0B60-0x0000000180BC0B90
			internal float <OnExecute>b__7_1(RaycastHit2D h); // 0x0000000180BC0B90-0x0000000180BC0BB0
			internal Vector3 <OnExecute>b__7_3(RaycastHit2D h); // 0x0000000180BC0BB0-0x0000000180BC0C10
		}
	
		// Constructors
		public GetLinecastInfo2DAll(); // 0x0000000180BAF090-0x0000000180BAF0E0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BAEAB0-0x0000000180BAEFB0
		public override void OnDrawGizmosSelected(); // 0x0000000180BAE920-0x0000000180BAEAB0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 <OnExecute>b__7_2(RaycastHit2D h); // 0x0000000180BAEFB0-0x0000000180BAF090
	}
}
