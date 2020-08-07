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
	[Category] // 0x000000018028FCA0-0x000000018028FD00
	[Description] // 0x000000018028FCA0-0x000000018028FD00
	public class ScaleMultiplyOverTime : ActionTask<Transform> // TypeDefIndex: 15552
	{
		// Fields
		public BBParameter<float> scaleAmount; // 0x68
		public BBParameter<float> duration; // 0x70
		public BBParameter<bool> waitToContinue; // 0x78
	
		// Properties
		protected override string info { get; } // 0x00000001807A21E0-0x00000001807A24C0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Scale>d__6 : IEnumerator<object> // TypeDefIndex: 15553
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ScaleMultiplyOverTime <>4__this; // 0x20
			private Vector3 <startScale>5__2; // 0x28
			private Vector3 <endScale>5__3; // 0x34
			private float <t>5__4; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Scale>d__6(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001807AC590-0x00000001807AC900
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001807AC900-0x00000001807AC950
		}
	
		// Constructors
		public ScaleMultiplyOverTime(); // 0x00000001807A2170-0x00000001807A21E0
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A1E90-0x00000001807A2110
		[IteratorStateMachine] // 0x000000018028FDD0-0x000000018028FE20
		private IEnumerator Scale(); // 0x00000001807A2110-0x00000001807A2170
	}
}
