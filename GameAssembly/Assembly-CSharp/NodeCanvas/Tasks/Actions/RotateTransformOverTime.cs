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
	[Category] // 0x000000018028F090-0x000000018028F0F0
	[Description] // 0x000000018028F090-0x000000018028F0F0
	public class RotateTransformOverTime : ActionTask<Transform> // TypeDefIndex: 15550
	{
		// Fields
		public BBParameter<Vector3> rotation; // 0x68
		public BBParameter<float> duration; // 0x70
		public BBParameter<bool> additive; // 0x78
		public BBParameter<bool> waitToContinue; // 0x80
		private Vector3 endRot; // 0x88
	
		// Properties
		protected override string info { get; } // 0x00000001807A0ED0-0x00000001807A1350 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <RotateIt>d__8 : IEnumerator<object> // TypeDefIndex: 15551
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RotateTransformOverTime <>4__this; // 0x20
			private Vector3 <startRot>5__2; // 0x28
			private float <t>5__3; // 0x34
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <RotateIt>d__8(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001807AC1F0-0x00000001807AC540
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001807AC540-0x00000001807AC590
		}
	
		// Constructors
		public RotateTransformOverTime(); // 0x00000001807A0E80-0x00000001807A0ED0
	
		// Methods
		protected override void OnExecute(); // 0x00000001807A0A20-0x00000001807A0E20
		[IteratorStateMachine] // 0x000000018028F2E0-0x000000018028F330
		private IEnumerator RotateIt(); // 0x00000001807A0E20-0x00000001807A0E80
	}
}
