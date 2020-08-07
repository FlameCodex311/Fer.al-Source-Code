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
	[Category] // 0x0000000180296310-0x0000000180296370
	[Description] // 0x0000000180296310-0x0000000180296370
	public class TransformLookAtTranform : ActionTask<Transform> // TypeDefIndex: 15568
	{
		// Fields
		public BBParameter<Transform> transformToLookAt; // 0x68
		public BBParameter<bool> ignoreTransformY; // 0x70
		public BBParameter<Vector3> lookAtOffset; // 0x78
		public BBParameter<float> duration; // 0x80
		public BBParameter<bool> waitToContinue; // 0x88
		private Vector3 startPos; // 0x90
		private Vector3 endPos; // 0x9C
	
		// Properties
		protected override string info { get; } // 0x00000001807AA740-0x00000001807AA8B0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <LookAt>d__10 : IEnumerator<object> // TypeDefIndex: 15569
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TransformLookAtTranform <>4__this; // 0x20
			private float <t>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <LookAt>d__10(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001807AB020-0x00000001807AB520
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001807AB520-0x00000001807AB570
		}
	
		// Constructors
		public TransformLookAtTranform(); // 0x00000001807AA6F0-0x00000001807AA740
	
		// Methods
		protected override void OnExecute(); // 0x00000001807AA360-0x00000001807AA6F0
		[IteratorStateMachine] // 0x0000000180296610-0x0000000180296660
		private IEnumerator LookAt(); // 0x00000001807AA300-0x00000001807AA360
	}
}
