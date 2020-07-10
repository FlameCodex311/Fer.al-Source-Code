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
	[Category] // 0x000000018012A040-0x000000018012A0A0
	[Description] // 0x000000018012A040-0x000000018012A0A0
	public class TransformLookAtTranform : ActionTask<Transform> // TypeDefIndex: 14462
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
		protected override string info { get; } // 0x0000000181266320-0x00000001812664A0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <LookAt>d__10 : IEnumerator<object> // TypeDefIndex: 14463
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TransformLookAtTranform <>4__this; // 0x20
			private float <t>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <LookAt>d__10(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181266BD0-0x00000001812670F0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001812670F0-0x0000000181267140
		}
	
		// Constructors
		public TransformLookAtTranform(); // 0x00000001812662D0-0x0000000181266320
	
		// Methods
		protected override void OnExecute(); // 0x0000000181265F30-0x00000001812662D0
		[IteratorStateMachine] // 0x000000018012A260-0x000000018012A2B0
		private IEnumerator LookAt(); // 0x0000000181265ED0-0x0000000181265F30
	}
}
