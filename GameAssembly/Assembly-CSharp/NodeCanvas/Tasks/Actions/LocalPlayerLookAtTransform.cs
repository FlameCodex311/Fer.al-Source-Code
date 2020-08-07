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
	[Category] // 0x000000018027F4B0-0x000000018027F510
	[Description] // 0x000000018027F4B0-0x000000018027F510
	public class LocalPlayerLookAtTransform : ActionTask<Transform> // TypeDefIndex: 15474
	{
		// Fields
		public BBParameter<bool> _lookAtIgnoreY; // 0x68
		public BBParameter<Vector3> transformOffset; // 0x70
		public BBParameter<float> duration; // 0x78
		public BBParameter<bool> waitToContinue; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180BB49E0-0x0000000180BB4AB0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <LookAt>d__7 : IEnumerator<object> // TypeDefIndex: 15475
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public LocalPlayerLookAtTransform <>4__this; // 0x20
			private Transform <playerTransform>5__2; // 0x28
			private Vector3 <startLookDir>5__3; // 0x30
			private Vector3 <endLookDir>5__4; // 0x3C
			private float <t>5__5; // 0x48
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <LookAt>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180BBEE40-0x0000000180BBF230
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180BBF230-0x0000000180BBF280
		}
	
		// Constructors
		public LocalPlayerLookAtTransform(); // 0x0000000180BB4940-0x0000000180BB49E0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB46C0-0x0000000180BB4940
		[IteratorStateMachine] // 0x000000018027F710-0x000000018027F760
		private IEnumerator LookAt(); // 0x0000000180BB4660-0x0000000180BB46C0
	}
}
