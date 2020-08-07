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
	[Category] // 0x0000000180282200-0x0000000180282260
	[Description] // 0x0000000180282200-0x0000000180282260
	public class MoveTransformOverTime : ActionTask<Transform> // TypeDefIndex: 15482
	{
		// Fields
		public MoveToMode moveTo; // 0x68
		[ShowIf] // 0x0000000180282430-0x0000000180282460
		public BBParameter<Vector3> localPlayerOffset; // 0x70
		[ShowIf] // 0x0000000180282580-0x00000001802825B0
		public BBParameter<Vector3> position; // 0x78
		[ShowIf] // 0x0000000180282660-0x0000000180282690
		public BBParameter<Transform> targetGameObject; // 0x80
		[ShowIf] // 0x0000000180282660-0x0000000180282690
		public BBParameter<Vector3> gameObjectOffset; // 0x88
		public BBParameter<float> duration; // 0x90
		public BBParameter<bool> waitToContinue; // 0x98
	
		// Properties
		protected override string info { get; } // 0x0000000180BB8E30-0x0000000180BB9710 
	
		// Nested types
		public enum MoveToMode // TypeDefIndex: 15483
		{
			LocalPlayer = 0,
			Position = 1,
			GameObject = 2
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Move>d__11 : IEnumerator<object> // TypeDefIndex: 15484
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MoveTransformOverTime <>4__this; // 0x20
			public Vector3 inEnd; // 0x28
			private Vector3 <startPos>5__2; // 0x34
			private float <t>5__3; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Move>d__11(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180BBFCB0-0x0000000180BC0270
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180BC0270-0x0000000180BC02C0
		}
	
		// Constructors
		public MoveTransformOverTime(); // 0x0000000180BB8D50-0x0000000180BB8E30
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB88C0-0x0000000180BB8D50
		[IteratorStateMachine] // 0x0000000180282A00-0x0000000180282A50
		private IEnumerator Move(Vector3 inEnd); // 0x0000000180BB8840-0x0000000180BB88C0
	}
}
