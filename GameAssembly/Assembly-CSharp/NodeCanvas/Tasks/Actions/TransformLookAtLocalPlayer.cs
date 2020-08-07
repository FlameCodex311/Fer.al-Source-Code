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
	[Category] // 0x0000000180295640-0x00000001802956A0
	[Description] // 0x0000000180295640-0x00000001802956A0
	public class TransformLookAtLocalPlayer : ActionTask<Transform> // TypeDefIndex: 15566
	{
		// Fields
		public BBParameter<Vector3> playerOffset; // 0x68
		public BBParameter<float> duration; // 0x70
		public BBParameter<bool> waitToContinue; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001807AA220-0x00000001807AA300 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <LookAt>d__6 : IEnumerator<object> // TypeDefIndex: 15567
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TransformLookAtLocalPlayer <>4__this; // 0x20
			private Vector3 <startPos>5__2; // 0x28
			private Vector3 <endPos>5__3; // 0x34
			private float <t>5__4; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <LookAt>d__6(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001807AB570-0x00000001807ABAB0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001807ABAB0-0x00000001807ABB00
		}
	
		// Constructors
		public TransformLookAtLocalPlayer(); // 0x00000001807AA190-0x00000001807AA220
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A9F10-0x00000001807AA190
		[IteratorStateMachine] // 0x0000000180295B60-0x0000000180295BB0
		private IEnumerator LookAt(); // 0x00000001807A9EB0-0x00000001807A9F10
	}
}
