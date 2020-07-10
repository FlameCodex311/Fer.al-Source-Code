/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Conditions
{
	[Category] // 0x00000001800CA280-0x00000001800CA300
	[Description] // 0x00000001800CA280-0x00000001800CA300
	[Name] // 0x00000001800CA280-0x00000001800CA300
	public class CheckLOS2D : ConditionTask<Transform> // TypeDefIndex: 14135
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> LOSTarget; // 0x68
		public BBParameter<LayerMask> layerMask; // 0x70
		[BlackboardOnly] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<float> saveDistanceAs; // 0x78
		[GetFromAgent] // 0x00000001800B36B0-0x00000001800B36C0
		protected Collider2D agentCollider; // 0x80
		private RaycastHit2D[] hits; // 0x88
	
		// Properties
		protected override string info { get; } // 0x0000000181252DC0-0x0000000181252E20 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 14136
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<RaycastHit2D, Collider2D> <>9__7_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001812685F0-0x0000000181268650
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal Collider2D <OnCheck>b__7_0(RaycastHit2D h); // 0x0000000181268590-0x00000001812685B0
		}
	
		// Constructors
		public CheckLOS2D(); // 0x0000000181252D60-0x0000000181252DC0
	
		// Methods
		protected override bool OnCheck(); // 0x0000000181252610-0x0000000181252BD0
		public override void OnDrawGizmosSelected(); // 0x0000000181252BD0-0x0000000181252D60
	}
}
