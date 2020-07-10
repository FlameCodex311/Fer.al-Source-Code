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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype
{
	public class FeralRandomNPC : ManagedBehaviour // TypeDefIndex: 16070
	{
		// Fields
		[RootSelector] // 0x00000001800FDCF0-0x00000001800FDD50
		public string npcAvatarDefId; // 0x50
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _disableRange; // 0x58
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _disableOffScreen; // 0x5C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float _modelScale; // 0x60
		private NavMeshAgent _agent; // 0x68
		private ActorBase _actorBase; // 0x70
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CreateRandomActor>d__7 : IEnumerator<object> // TypeDefIndex: 16071
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FeralRandomNPC <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <CreateRandomActor>d__7(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813A7EC0-0x00000001813A8310
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813A8310-0x00000001813A8360
		}
	
		// Constructors
		public FeralRandomNPC(); // 0x00000001813A2B70-0x00000001813A2BE0
	
		// Methods
		public override void MStart(); // 0x00000001813A2900-0x00000001813A2970
		[IteratorStateMachine] // 0x00000001800FE340-0x00000001800FE390
		private IEnumerator CreateRandomActor(); // 0x00000001813A28A0-0x00000001813A2900
		private void OnDrawGizmos(); // 0x00000001813A2970-0x00000001813A2B70
	}
}
