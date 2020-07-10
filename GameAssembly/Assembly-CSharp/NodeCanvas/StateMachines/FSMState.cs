/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.StateMachines
{
	public abstract class FSMState : Node, IState // TypeDefIndex: 14010
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TransitionEvaluationMode _transitionEvaluation; // 0x78
		private float _elapsedTime; // 0x7C
		private bool _hasInit; // 0x80
	
		// Properties
		public override bool allowAsPrime { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public override int maxInConnections { get; } // 0x00000001805F5E50-0x00000001805F5E60 
		public override int maxOutConnections { get; } // 0x00000001805F5E50-0x00000001805F5E60 
		public sealed override Type outConnectionType { get; } // 0x0000000181750130-0x0000000181750190 
		public sealed override Alignment2x2 commentsAlignment { get; } // 0x000000018043D4B0-0x000000018043D4C0 
		public sealed override Alignment2x2 iconAlignment { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public TransitionEvaluationMode transitionEvaluation { get; set; } // 0x00000001803DAE10-0x00000001803DAE20 0x00000001803DAE70-0x00000001803DAE80
		public float elapsedTime { get; private set; } // 0x0000000181411C30-0x0000000181411C40 0x0000000181646E80-0x0000000181646E90
		public FSM FSM { get; } // 0x00000001817500A0-0x0000000181750130 
	
		// Nested types
		public enum TransitionEvaluationMode // TypeDefIndex: 14011
		{
			CheckContinuously = 0,
			CheckAfterStateFinished = 1,
			CheckManually = 2
		}
	
		// Constructors
		protected FSMState(); // 0x000000018155E370-0x000000018155E380
	
		// Methods
		public FSMConnection[] GetTransitions(); // 0x000000018174FB60-0x000000018174FBB0
		public void Finish(); // 0x000000018174FB40-0x000000018174FB60
		public void Finish(bool inSuccess); // 0x0000000180DD2DA0-0x0000000180DD2DC0
		public override void OnGraphStarted(); // 0x00000001803581E0-0x00000001803581F0
		public override void OnGraphStoped(); // 0x00000001803581E0-0x00000001803581F0
		public override void OnGraphPaused(); // 0x000000018174FE10-0x000000018174FE30
		protected override bool CanConnectFromSource(Node sourceNode); // 0x000000018174F740-0x000000018174F860
		protected override bool CanConnectToTarget(Node targetNode); // 0x000000018174F860-0x000000018174F980
		protected sealed override Status OnExecute(Component agent, IBlackboard bb); // 0x000000018174FBB0-0x000000018174FE10
		public void Update(); // 0x0000000181750030-0x00000001817500A0
		public bool CheckTransitions(); // 0x000000018174F980-0x000000018174FB40
		protected sealed override void OnReset(); // 0x000000018174FE30-0x0000000181750030
		protected virtual void OnInit(); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void OnEnter(); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void OnUpdate(); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void OnExit(); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void OnPause(); // 0x00000001803581E0-0x00000001803581F0
	}
}
