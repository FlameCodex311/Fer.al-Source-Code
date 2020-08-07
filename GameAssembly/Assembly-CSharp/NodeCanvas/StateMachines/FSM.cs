/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.StateMachines
{
	[CreateAssetMenu] // 0x00000001801EB2E0-0x00000001801EB370
	[GraphInfo] // 0x00000001801EB2E0-0x00000001801EB370
	public class FSM : Graph // TypeDefIndex: 15069
	{
		// Fields
		private List<IUpdatable> updatableNodes; // 0x98
		private IStateCallbackReceiver[] callbackReceivers; // 0xA0
		private Stack<FSMState> stateStack; // 0xA8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<IState> onStateEnter; // 0xB0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<IState> onStateUpdate; // 0xB8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<IState> onStateExit; // 0xC0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Action<IState> onStateTransition; // 0xC8
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private FSMState <currentState>k__BackingField; // 0xD0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private FSMState <previousState>k__BackingField; // 0xD8
	
		// Properties
		public FSMState currentState { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001805293A0-0x00000001805293B0 0x0000000180529420-0x0000000180529430
		public FSMState previousState { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001805CB740-0x00000001805CB750 0x00000001809E2CC0-0x00000001809E4880
		public string currentStateName { get; } // 0x0000000180CC5E30-0x0000000180CC5E50 
		public string previousStateName { get; } // 0x0000000180CC5E50-0x0000000180CC5E70 
		public override Type baseNodeType { get; } // 0x0000000180CC5DD0-0x0000000180CC5E30 
		public override bool requiresAgent { get; } // 0x0000000180380B60-0x0000000180380B70 
		public override bool requiresPrimeNode { get; } // 0x0000000180380B60-0x0000000180380B70 
		public override bool isTree { get; } // 0x0000000180380950-0x0000000180380960 
		public override bool allowBlackboardOverrides { get; } // 0x0000000180380B60-0x0000000180380B70 
		public sealed override bool canAcceptVariableDrops { get; } // 0x0000000180380950-0x0000000180380960 
	
		// Events
		public event Action<IState> onStateEnter {
			add; // 0x0000000180CC5B50-0x0000000180CC5BF0
			remove; // 0x0000000180CC5E70-0x0000000180CC5F10
		}
		public event Action<IState> onStateUpdate {
			add; // 0x0000000180CC5D30-0x0000000180CC5DD0
			remove; // 0x0000000180CC6050-0x0000000180CC60F0
		}
		public event Action<IState> onStateExit {
			add; // 0x0000000180CC5BF0-0x0000000180CC5C90
			remove; // 0x0000000180CC5F10-0x0000000180CC5FB0
		}
		public event Action<IState> onStateTransition {
			add; // 0x0000000180CC5C90-0x0000000180CC5D30
			remove; // 0x0000000180CC5FB0-0x0000000180CC6050
		}
	
		// Nested types
		public enum TransitionCallMode // TypeDefIndex: 15070
		{
			Normal = 0,
			Stacked = 1,
			Clean = 2
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15071
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<IUpdatable, bool> <>9__42_0; // 0x08
			public static Func<Node, bool> <>9__46_0; // 0x10
			public static Func<Node, string> <>9__46_1; // 0x18
	
			// Constructors
			static <>c(); // 0x0000000180CD2630-0x0000000180CD2690
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <OnGraphUpdate>b__42_0(IUpdatable n); // 0x0000000180CD1D40-0x0000000180CD1D90
			internal bool <GetStateNames>b__46_0(Node n); // 0x0000000180CD1CA0-0x0000000180CD1D10
			internal string <GetStateNames>b__46_1(Node n); // 0x0000000180CD1D10-0x0000000180CD1D40
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass47_0 // TypeDefIndex: 15072
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public <>c__DisplayClass47_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <GetStateWithName>b__0(Node n); // 0x0000000180CD24C0-0x0000000180CD2570
		}
	
		// Constructors
		public FSM(); // 0x0000000180CC5B40-0x0000000180CC5B50
	
		// Methods
		protected override void OnGraphInitialize(); // 0x0000000180CC5000-0x0000000180CC51B0
		protected override void OnGraphStarted(); // 0x0000000180CC51B0-0x0000000180CC5280
		protected override void OnGraphUpdate(); // 0x0000000180CC52F0-0x0000000180CC5610
		protected override void OnGraphStoped(); // 0x0000000180CC5280-0x0000000180CC52F0
		public bool EnterState(FSMState newState, TransitionCallMode callMode); // 0x0000000180CC47A0-0x0000000180CC4A50
		public FSMState TriggerState(string stateName, TransitionCallMode callMode); // 0x0000000180CC5660-0x0000000180CC57B0
		public string[] GetStateNames(); // 0x0000000180CC4D20-0x0000000180CC4EE0
		public FSMState GetStateWithName(string name); // 0x0000000180CC4EE0-0x0000000180CC5000
		private void GatherCallbackReceivers(); // 0x0000000180CC4A50-0x0000000180CC4D20
		public FSMState PeekStack(); // 0x0000000180CC5610-0x0000000180CC5660
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <GatherCallbackReceivers>b__48_0(IState x); // 0x0000000180CC57B0-0x0000000180CC58E0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <GatherCallbackReceivers>b__48_1(IState x); // 0x0000000180CC58E0-0x0000000180CC5A10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <GatherCallbackReceivers>b__48_2(IState x); // 0x0000000180CC5A10-0x0000000180CC5B40
	}
}
