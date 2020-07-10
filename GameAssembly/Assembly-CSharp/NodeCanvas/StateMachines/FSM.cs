/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.StateMachines
{
	[CreateAssetMenu] // 0x000000018015A9C0-0x000000018015AA50
	[GraphInfo] // 0x000000018015A9C0-0x000000018015AA50
	public class FSM : Graph // TypeDefIndex: 14003
	{
		// Fields
		private bool hasInitialized; // 0x88
		private List<IUpdatable> updatableNodes; // 0x90
		private List<AnyState> anyStates; // 0x98
		private List<ConcurrentState> concurentStates; // 0xA0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action<IState> onStateEnter; // 0xA8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action<IState> onStateUpdate; // 0xB0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action<IState> onStateExit; // 0xB8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Action<IState> onStateTransition; // 0xC0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private FSMState <currentState>k__BackingField; // 0xC8
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private FSMState <previousState>k__BackingField; // 0xD0
	
		// Properties
		public FSMState currentState { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804A2590-0x00000001804A25A0 0x00000001804A22E0-0x00000001804A22F0
		public FSMState previousState { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001804A24D0-0x00000001804A24E0 0x00000001804A22C0-0x00000001804A22D0
		public string currentStateName { get; } // 0x0000000181751BF0-0x0000000181751C10 
		public string previousStateName { get; } // 0x0000000181751C10-0x0000000181751C30 
		public override Type baseNodeType { get; } // 0x0000000181751B90-0x0000000181751BF0 
		public override bool requiresAgent { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public override bool requiresPrimeNode { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public override bool isTree { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public override bool useLocalBlackboard { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public sealed override bool canAcceptVariableDrops { get; } // 0x00000001803C28F0-0x00000001803C2900 
	
		// Events
		public event Action<IState> onStateEnter {
			add; // 0x0000000181751910-0x00000001817519B0
			remove; // 0x0000000181751C30-0x0000000181751CD0
		}
		public event Action<IState> onStateUpdate {
			add; // 0x0000000181751AF0-0x0000000181751B90
			remove; // 0x0000000181751E10-0x0000000181751EB0
		}
		public event Action<IState> onStateExit {
			add; // 0x00000001817519B0-0x0000000181751A50
			remove; // 0x0000000181751CD0-0x0000000181751D70
		}
		public event Action<IState> onStateTransition {
			add; // 0x0000000181751A50-0x0000000181751AF0
			remove; // 0x0000000181751D70-0x0000000181751E10
		}
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 14004
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<Node, bool> <>9__47_0; // 0x08
			public static Func<Node, string> <>9__47_1; // 0x10
	
			// Constructors
			static <>c(); // 0x0000000181761580-0x00000001817615E0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <GetStateNames>b__47_0(Node n); // 0x0000000181760D00-0x0000000181760D30
			internal string <GetStateNames>b__47_1(Node n); // 0x0000000181760D30-0x0000000181760D60
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass48_0 // TypeDefIndex: 14005
		{
			// Fields
			public string name; // 0x10
	
			// Constructors
			public <>c__DisplayClass48_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <GetStateWithName>b__0(Node n); // 0x00000001817610E0-0x0000000181761150
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass49_0 // TypeDefIndex: 14006
		{
			// Fields
			public MethodInfo enterMethod; // 0x10
			public MonoBehaviour mono; // 0x18
			public MethodInfo stayMethod; // 0x20
			public MethodInfo exitMethod; // 0x28
	
			// Constructors
			public <>c__DisplayClass49_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <GatherDelegates>b__0(IState m); // 0x0000000181761150-0x00000001817611E0
			internal void <GatherDelegates>b__1(IState m); // 0x00000001817611E0-0x0000000181761270
			internal void <GatherDelegates>b__2(IState m); // 0x0000000181761270-0x0000000181761300
		}
	
		// Constructors
		public FSM(); // 0x0000000181751840-0x0000000181751910
	
		// Methods
		protected override void OnGraphStarted(); // 0x0000000181750B10-0x0000000181751130
		protected override void OnGraphUnpaused(); // 0x00000001817511D0-0x0000000181751270
		protected override void OnGraphUpdate(); // 0x0000000181751270-0x00000001817514C0
		protected override void OnGraphStoped(); // 0x0000000181751130-0x00000001817511D0
		protected override void OnGraphPaused(); // 0x0000000181750AF0-0x0000000181750B10
		public bool EnterState(FSMState newState); // 0x0000000181750190-0x0000000181750370
		public FSMState TriggerState(string stateName); // 0x00000001817514C0-0x0000000181751840
		public string[] GetStateNames(); // 0x0000000181750820-0x00000001817509D0
		public FSMState GetStateWithName(string name); // 0x00000001817509D0-0x0000000181750AF0
		private void GatherDelegates(); // 0x0000000181750370-0x0000000181750820
	}
}
