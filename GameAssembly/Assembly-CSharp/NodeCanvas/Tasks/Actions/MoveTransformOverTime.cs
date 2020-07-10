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
	[Category] // 0x0000000180114D30-0x0000000180114D90
	[Description] // 0x0000000180114D30-0x0000000180114D90
	public class MoveTransformOverTime : ActionTask<Transform> // TypeDefIndex: 14379
	{
		// Fields
		public MoveToMode moveTo; // 0x68
		[ShowIf] // 0x0000000180114EC0-0x0000000180114EF0
		public BBParameter<Vector3> localPlayerOffset; // 0x70
		[ShowIf] // 0x00000001801150C0-0x00000001801150F0
		public BBParameter<Vector3> position; // 0x78
		[ShowIf] // 0x00000001801151F0-0x0000000180115220
		public BBParameter<Transform> targetGameObject; // 0x80
		[ShowIf] // 0x00000001801151F0-0x0000000180115220
		public BBParameter<Vector3> gameObjectOffset; // 0x88
		public BBParameter<float> duration; // 0x90
		public BBParameter<bool> waitToContinue; // 0x98
	
		// Properties
		protected override string info { get; } // 0x0000000181552D10-0x0000000181553660 
	
		// Nested types
		public enum MoveToMode // TypeDefIndex: 14380
		{
			LocalPlayer = 0,
			Position = 1,
			GameObject = 2
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Move>d__11 : IEnumerator<object> // TypeDefIndex: 14381
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MoveTransformOverTime <>4__this; // 0x20
			public Vector3 inEnd; // 0x28
			private Vector3 <startPos>5__2; // 0x34
			private float <t>5__3; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Move>d__11(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018155B2D0-0x000000018155B8B0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018155B8B0-0x000000018155B900
		}
	
		// Constructors
		public MoveTransformOverTime(); // 0x0000000181552C30-0x0000000181552D10
	
		// Methods
		protected override void OnExecute(); // 0x00000001815527A0-0x0000000181552C30
		[IteratorStateMachine] // 0x0000000180115480-0x00000001801154D0
		private IEnumerator Move(Vector3 inEnd); // 0x0000000181552720-0x00000001815527A0
	}
}
