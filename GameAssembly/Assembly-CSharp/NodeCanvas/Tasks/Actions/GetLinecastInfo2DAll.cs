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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180100A20-0x0000000180100A80
	[Description] // 0x0000000180100A20-0x0000000180100A80
	public class GetLinecastInfo2DAll : ActionTask<Transform> // TypeDefIndex: 14304
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> target; // 0x68
		public LayerMask mask; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<List<GameObject>> saveHitGameObjectsAs; // 0x78
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<List<float>> saveDistancesAs; // 0x80
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<List<Vector3>> savePointsAs; // 0x88
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<List<Vector3>> saveNormalsAs; // 0x90
		private RaycastHit2D[] hits; // 0x98
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 14305
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<RaycastHit2D, GameObject> <>9__7_0; // 0x08
			public static Func<RaycastHit2D, float> <>9__7_1; // 0x10
			public static Func<RaycastHit2D, Vector2> <>9__7_2; // 0x18
			public static Func<RaycastHit2D, Vector2> <>9__7_3; // 0x20
	
			// Constructors
			static <>c(); // 0x000000018155C6F0-0x000000018155C750
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal GameObject <OnExecute>b__7_0(RaycastHit2D h); // 0x000000018155C1D0-0x000000018155C200
			internal float <OnExecute>b__7_1(RaycastHit2D h); // 0x000000018155C200-0x000000018155C220
			internal Vector2 <OnExecute>b__7_2(RaycastHit2D h); // 0x000000018155C220-0x000000018155C240
			internal Vector2 <OnExecute>b__7_3(RaycastHit2D h); // 0x000000018155C240-0x000000018155C260
		}
	
		// Constructors
		public GetLinecastInfo2DAll(); // 0x0000000181548FA0-0x0000000181548FF0
	
		// Methods
		protected override void OnExecute(); // 0x0000000181548A10-0x0000000181548FA0
		public override void OnDrawGizmosSelected(); // 0x0000000181548880-0x0000000181548A10
	}
}
