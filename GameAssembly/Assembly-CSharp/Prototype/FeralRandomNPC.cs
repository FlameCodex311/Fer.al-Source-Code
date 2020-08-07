/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype
{
	public class FeralRandomNPC : ManagedBehaviour // TypeDefIndex: 14809
	{
		// Fields
		[RootSelector] // 0x0000000180218490-0x00000001802184F0
		public string npcAvatarDefId; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _disableRange; // 0x58
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _disableOffScreen; // 0x5C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float _modelScale; // 0x60
		private NavMeshAgent _agent; // 0x68
		private ActorBase _actorBase; // 0x70
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CreateRandomActor>d__7 : IEnumerator<object> // TypeDefIndex: 14810
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FeralRandomNPC <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <CreateRandomActor>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180ADE530-0x0000000180ADE970
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180ADE970-0x0000000180ADE9C0
		}
	
		// Constructors
		public FeralRandomNPC(); // 0x0000000180AD8F40-0x0000000180AD8FB0
	
		// Methods
		public override void MStart(); // 0x0000000180AD8CE0-0x0000000180AD8D50
		[IteratorStateMachine] // 0x0000000180218C50-0x0000000180218CA0
		private IEnumerator CreateRandomActor(); // 0x0000000180AD8C80-0x0000000180AD8CE0
		private void OnDrawGizmos(); // 0x0000000180AD8D50-0x0000000180AD8F40
	}
}
