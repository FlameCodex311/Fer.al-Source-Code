/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.StateMachines
{
	public abstract class FSMState : FSMNode, IState // TypeDefIndex: 15077
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TransitionEvaluationMode _transitionEvaluation; // 0x88
		private bool _hasInit; // 0x8C
	
		// Properties
		public override bool allowAsPrime { get; } // 0x0000000180380B60-0x0000000180380B70 
		public override bool canSelfConnect { get; } // 0x0000000180380B60-0x0000000180380B70 
		public override int maxInConnections { get; } // 0x00000001807C4280-0x00000001807C4290 
		public override int maxOutConnections { get; } // 0x00000001807C4280-0x00000001807C4290 
		public TransitionEvaluationMode transitionEvaluation { get; set; } // 0x00000001803CCE20-0x00000001803CCE30 0x00000001803CCEB0-0x00000001803CCEC0
	
		// Nested types
		public enum TransitionEvaluationMode // TypeDefIndex: 15078
		{
			CheckContinuously = 0,
			CheckAfterStateFinished = 1,
			CheckManually = 2
		}
	
		// Constructors
		protected FSMState(); // 0x00000001807C41B0-0x00000001807C41C0
	
		// Methods
		public FSMConnection[] GetTransitions(); // 0x0000000180CC41C0-0x0000000180CC43A0
		public void Finish(); // 0x0000000180CC4180-0x0000000180CC4190
		public void Finish(bool inSuccess); // 0x0000000180CC06F0-0x0000000180CC0740
		public void Finish(Status status); // 0x0000000180CC4190-0x0000000180CC41C0
		public override void OnGraphPaused(); // 0x0000000180CC4590-0x0000000180CC45B0
		protected override bool CanConnectFromSource(Node sourceNode); // 0x0000000180CC3E60-0x0000000180CC3F10
		protected override bool CanConnectToTarget(Node targetNode); // 0x0000000180CC3F10-0x0000000180CC3FC0
		protected sealed override Status OnExecute(Component agent, IBlackboard bb); // 0x0000000180CC43A0-0x0000000180CC4590
		public void Update(); // 0x0000000180CC4730-0x0000000180CC47A0
		public bool CheckTransitions(); // 0x0000000180CC3FC0-0x0000000180CC4180
		protected sealed override void OnReset(); // 0x0000000180CC45B0-0x0000000180CC4730
		protected virtual void OnInit(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnEnter(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnUpdate(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnExit(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnPause(); // 0x00000001803774A0-0x00000001803774B0
	}
}
