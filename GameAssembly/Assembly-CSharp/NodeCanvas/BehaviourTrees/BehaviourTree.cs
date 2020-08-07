/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.BehaviourTrees
{
	[CreateAssetMenu] // 0x000000018020DEF0-0x000000018020DF80
	[GraphInfo] // 0x000000018020DEF0-0x000000018020DF80
	public class BehaviourTree : Graph // TypeDefIndex: 15143
	{
		// Fields
		[NonSerialized]
		public bool repeat; // 0x98
		[NonSerialized]
		public float updateInterval; // 0x9C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<BehaviourTree, Status> onRootStatusChanged; // 0x00
		private float intervalCounter; // 0xA0
		private Status _rootStatus; // 0xA4
	
		// Properties
		public Status rootStatus { get; private set; } // 0x00000001807C4E60-0x00000001807C4E70 0x00000001807C4F20-0x00000001807C4F90
		public override Type baseNodeType { get; } // 0x00000001807C4E00-0x00000001807C4E60 
		public override bool requiresAgent { get; } // 0x0000000180380B60-0x0000000180380B70 
		public override bool requiresPrimeNode { get; } // 0x0000000180380B60-0x0000000180380B70 
		public override bool isTree { get; } // 0x0000000180380B60-0x0000000180380B70 
		public override bool allowBlackboardOverrides { get; } // 0x0000000180380B60-0x0000000180380B70 
		public sealed override bool canAcceptVariableDrops { get; } // 0x0000000180380950-0x0000000180380960 
	
		// Events
		public static event Action<BehaviourTree, Status> onRootStatusChanged {
			add; // 0x00000001807C4D50-0x00000001807C4E00
			remove; // 0x00000001807C4E70-0x00000001807C4F20
		}
	
		// Nested types
		[Serializable]
		private class DerivedSerializationData // TypeDefIndex: 15144
		{
			// Fields
			public bool repeat; // 0x10
			public float updateInterval; // 0x14
	
			// Constructors
			public DerivedSerializationData(); // 0x0000000180373240-0x0000000180373250
		}
	
		// Constructors
		public BehaviourTree(); // 0x00000001807C4D30-0x00000001807C4D50
	
		// Methods
		public override object OnDerivedDataSerialization(); // 0x00000001807C4A00-0x00000001807C4A70
		public override void OnDerivedDataDeserialization(object data); // 0x00000001807C4840-0x00000001807C4A00
		protected override void OnGraphStarted(); // 0x00000001807C4A70-0x00000001807C4B00
		protected override void OnGraphUpdate(); // 0x00000001807C4B00-0x00000001807C4C60
		private Status Tick(Component agent, IBlackboard blackboard); // 0x00000001807C4C60-0x00000001807C4D30
	}
}
