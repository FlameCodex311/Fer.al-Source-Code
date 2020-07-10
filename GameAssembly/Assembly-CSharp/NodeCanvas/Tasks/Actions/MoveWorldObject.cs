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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180117290-0x00000001801172F0
	[Description] // 0x0000000180117290-0x00000001801172F0
	public class MoveWorldObject : ActionTask<ActorNPCSpawner> // TypeDefIndex: 14382
	{
		// Fields
		public Transform destination; // 0x68
		public float speed; // 0x70
		public float stopDistance; // 0x74
		public EMoveType moveType; // 0x78
		private ActorBase _actorBase; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000181553B80-0x0000000181553F40 
	
		// Nested types
		public enum EMoveType // TypeDefIndex: 14383
		{
			StartToEnd = 0,
			StartToWaynpoint = 1,
			WaypointToWaynpoint = 2,
			WaypointToEnd = 3
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 14384
		{
			// Fields
			public float currentSpeed; // 0x10
	
			// Constructors
			public <>c__DisplayClass10_0(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass10_1 // TypeDefIndex: 14385
		{
			// Fields
			public float t; // 0x10
			public <>c__DisplayClass10_0 CS$<>8__locals1; // 0x18
	
			// Constructors
			public <>c__DisplayClass10_1(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <MoveIt>b__0(Animator cAnimator); // 0x000000018155C300-0x000000018155C3C0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <MoveIt>d__10 : IEnumerator<object> // TypeDefIndex: 14386
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MoveWorldObject <>4__this; // 0x20
			private <>c__DisplayClass10_1 <>8__1; // 0x28
			private WorldObjectMoveNodeData <nNode>5__2; // 0x30
			private float <t>5__3; // 0x70
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <MoveIt>d__10(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018155A860-0x000000018155B280
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018155B280-0x000000018155B2D0
		}
	
		// Constructors
		public MoveWorldObject(); // 0x0000000181553B30-0x0000000181553B80
	
		// Methods
		private void SetFaceLocalPlayer(bool inFace); // 0x00000001815539E0-0x0000000181553B30
		protected override void OnExecute(); // 0x0000000181553970-0x00000001815539E0
		[IteratorStateMachine] // 0x0000000180117590-0x00000001801175E0
		private IEnumerator MoveIt(); // 0x0000000181553910-0x0000000181553970
	}
}
