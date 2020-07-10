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
	[Category] // 0x0000000180129660-0x00000001801296C0
	[Description] // 0x0000000180129660-0x00000001801296C0
	public class TransformLookAtLocalPlayer : ActionTask<Transform> // TypeDefIndex: 14460
	{
		// Fields
		public BBParameter<Vector3> playerOffset; // 0x68
		public BBParameter<float> duration; // 0x70
		public BBParameter<bool> waitToContinue; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000181265DF0-0x0000000181265ED0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <LookAt>d__6 : IEnumerator<object> // TypeDefIndex: 14461
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TransformLookAtLocalPlayer <>4__this; // 0x20
			private Vector3 <startPos>5__2; // 0x28
			private Vector3 <endPos>5__3; // 0x34
			private float <t>5__4; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <LookAt>d__6(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181267140-0x00000001812676A0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001812676A0-0x00000001812676F0
		}
	
		// Constructors
		public TransformLookAtLocalPlayer(); // 0x0000000181265D60-0x0000000181265DF0
	
		// Methods
		protected override void OnExecute(); // 0x0000000181265AE0-0x0000000181265D60
		[IteratorStateMachine] // 0x0000000180129890-0x00000001801298E0
		private IEnumerator LookAt(); // 0x0000000181265A80-0x0000000181265AE0
	}
}
