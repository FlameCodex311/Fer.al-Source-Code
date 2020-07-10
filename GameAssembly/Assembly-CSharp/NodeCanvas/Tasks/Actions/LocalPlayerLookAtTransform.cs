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
	[Category] // 0x00000001801112B0-0x0000000180111310
	[Description] // 0x00000001801112B0-0x0000000180111310
	public class LocalPlayerLookAtTransform : ActionTask<Transform> // TypeDefIndex: 14371
	{
		// Fields
		public BBParameter<bool> _lookAtIgnoreY; // 0x68
		public BBParameter<Vector3> transformOffset; // 0x70
		public BBParameter<float> duration; // 0x78
		public BBParameter<bool> waitToContinue; // 0x80
	
		// Properties
		protected override string info { get; } // 0x000000018154EC00-0x000000018154ECE0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <LookAt>d__7 : IEnumerator<object> // TypeDefIndex: 14372
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <LookAt>d__7(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018155A410-0x000000018155A810
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018155A810-0x000000018155A860
		}
	
		// Constructors
		public LocalPlayerLookAtTransform(); // 0x000000018154EB60-0x000000018154EC00
	
		// Methods
		protected override void OnExecute(); // 0x000000018154E8E0-0x000000018154EB60
		[IteratorStateMachine] // 0x00000001801114B0-0x0000000180111500
		private IEnumerator LookAt(); // 0x000000018154E880-0x000000018154E8E0
	}
}
