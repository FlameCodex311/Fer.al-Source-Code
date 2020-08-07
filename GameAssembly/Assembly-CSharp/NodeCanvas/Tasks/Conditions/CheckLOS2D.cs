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
	[Category] // 0x000000018022DD60-0x000000018022DDE0
	[Description] // 0x000000018022DD60-0x000000018022DDE0
	[Name] // 0x000000018022DD60-0x000000018022DDE0
	public class CheckLOS2D : ConditionTask<Transform> // TypeDefIndex: 15224
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> LOSTarget; // 0x68
		public BBParameter<LayerMask> layerMask; // 0x70
		[BlackboardOnly] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<float> saveDistanceAs; // 0x78
		[GetFromAgent] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected Collider2D agentCollider; // 0x80
		private RaycastHit2D[] hits; // 0x88
	
		// Properties
		protected override string info { get; } // 0x00000001807F2CA0-0x00000001807F2D00 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15225
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<RaycastHit2D, Collider2D> <>9__7_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180808590-0x00000001808085F0
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal Collider2D <OnCheck>b__7_0(RaycastHit2D h); // 0x00000001808084C0-0x00000001808084E0
		}
	
		// Constructors
		public CheckLOS2D(); // 0x00000001807F2C40-0x00000001807F2CA0
	
		// Methods
		protected override bool OnCheck(); // 0x00000001807F24E0-0x00000001807F2A30
		public override void OnDrawGizmosSelected(); // 0x00000001807F2A30-0x00000001807F2C40
	}
}
