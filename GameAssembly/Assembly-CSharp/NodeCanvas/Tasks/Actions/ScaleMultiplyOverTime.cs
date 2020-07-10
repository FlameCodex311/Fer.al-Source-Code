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
	[Category] // 0x0000000180125030-0x0000000180125090
	[Description] // 0x0000000180125030-0x0000000180125090
	public class ScaleMultiplyOverTime : ActionTask<Transform> // TypeDefIndex: 14446
	{
		// Fields
		public BBParameter<float> scaleAmount; // 0x68
		public BBParameter<float> duration; // 0x70
		public BBParameter<bool> waitToContinue; // 0x78
	
		// Properties
		protected override string info { get; } // 0x000000018125D610-0x000000018125D910 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Scale>d__6 : IEnumerator<object> // TypeDefIndex: 14447
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ScaleMultiplyOverTime <>4__this; // 0x20
			private Vector3 <startScale>5__2; // 0x28
			private Vector3 <endScale>5__3; // 0x34
			private float <t>5__4; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Scale>d__6(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001812681C0-0x0000000181268540
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181268540-0x0000000181268590
		}
	
		// Constructors
		public ScaleMultiplyOverTime(); // 0x000000018125D5A0-0x000000018125D610
	
		// Methods
		protected override void OnExecute(); // 0x000000018125D2B0-0x000000018125D540
		[IteratorStateMachine] // 0x0000000180125280-0x00000001801252D0
		private IEnumerator Scale(); // 0x000000018125D540-0x000000018125D5A0
	}
}
