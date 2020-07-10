/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.BehaviourTrees
{
	[CreateAssetMenu] // 0x0000000180161A70-0x0000000180161B00
	[GraphInfo] // 0x0000000180161A70-0x0000000180161B00
	public class BehaviourTree : Graph // TypeDefIndex: 14023
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public bool repeat; // 0x88
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public float updateInterval; // 0x8C
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<BehaviourTree, Status> onRootStatusChanged; // 0x00
		private float intervalCounter; // 0x90
		private Status _rootStatus; // 0x94
	
		// Properties
		public Status rootStatus { get; private set; } // 0x00000001804D0680-0x00000001804D0690 0x0000000181560B90-0x0000000181560C00
		public override Type baseNodeType { get; } // 0x0000000181560A80-0x0000000181560AE0 
		public override bool requiresAgent { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public override bool requiresPrimeNode { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public override bool isTree { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public override bool useLocalBlackboard { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public sealed override bool canAcceptVariableDrops { get; } // 0x00000001803C28F0-0x00000001803C2900 
	
		// Events
		public static event Action<BehaviourTree, Status> onRootStatusChanged {
			add; // 0x00000001815609D0-0x0000000181560A80
			remove; // 0x0000000181560AE0-0x0000000181560B90
		}
	
		// Nested types
		[Serializable]
		private struct DerivedSerializationData // TypeDefIndex: 14024
		{
			// Fields
			public bool repeat; // 0x00
			public float updateInterval; // 0x04
		}
	
		// Constructors
		public BehaviourTree(); // 0x0000000181560960-0x00000001815609D0
	
		// Methods
		public override object OnDerivedDataSerialization(); // 0x0000000181560620-0x0000000181560690
		public override void OnDerivedDataDeserialization(object data); // 0x0000000181560580-0x0000000181560620
		protected override void OnGraphStarted(); // 0x0000000181560690-0x0000000181560720
		protected override void OnGraphUpdate(); // 0x0000000181560720-0x0000000181560880
		private Status Tick(Component agent, IBlackboard blackboard); // 0x0000000181560880-0x0000000181560960
	}
}
