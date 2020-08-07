/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001802834A0-0x0000000180283500
	[Description] // 0x00000001802834A0-0x0000000180283500
	public class MoveWorldObject : ActionTask<ActorNPCSpawner> // TypeDefIndex: 15485
	{
		// Fields
		public Transform destination; // 0x68
		public float speed; // 0x70
		public float stopDistance; // 0x74
		public EMoveType moveType; // 0x78
		private ActorBase _actorBase; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180BB9C00-0x0000000180BB9F90 
	
		// Nested types
		public enum EMoveType // TypeDefIndex: 15486
		{
			StartToEnd = 0,
			StartToWaynpoint = 1,
			WaypointToWaynpoint = 2,
			WaypointToEnd = 3
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 15487
		{
			// Fields
			public float currentSpeed; // 0x10
	
			// Constructors
			public <>c__DisplayClass10_0(); // 0x0000000180373240-0x0000000180373250
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass10_1 // TypeDefIndex: 15488
		{
			// Fields
			public float t; // 0x10
			public <>c__DisplayClass10_0 CS$<>8__locals1; // 0x18
	
			// Constructors
			public <>c__DisplayClass10_1(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <MoveIt>b__0(Animator cAnimator); // 0x0000000180BC0C60-0x0000000180BC0D20
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <MoveIt>d__10 : IEnumerator<object> // TypeDefIndex: 15489
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MoveWorldObject <>4__this; // 0x20
			private <>c__DisplayClass10_1 <>8__1; // 0x28
			private WorldObjectMoveNodeData <nNode>5__2; // 0x30
			private float <t>5__3; // 0x70
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <MoveIt>d__10(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180BBF280-0x0000000180BBFC60
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180BBFC60-0x0000000180BBFCB0
		}
	
		// Constructors
		public MoveWorldObject(); // 0x0000000180BB9BB0-0x0000000180BB9C00
	
		// Methods
		private void SetFaceLocalPlayer(bool inFace); // 0x0000000180BB9A70-0x0000000180BB9BB0
		protected override void OnExecute(); // 0x0000000180BB9A00-0x0000000180BB9A70
		[IteratorStateMachine] // 0x00000001802837A0-0x00000001802837F0
		private IEnumerator MoveIt(); // 0x0000000180BB99A0-0x0000000180BB9A00
	}
}
