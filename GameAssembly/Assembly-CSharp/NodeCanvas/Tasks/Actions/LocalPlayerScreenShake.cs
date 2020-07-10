/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180111DE0-0x0000000180111E40
	[Description] // 0x0000000180111DE0-0x0000000180111E40
	public class LocalPlayerScreenShake : ActionTask<CinemachineImpulseSource> // TypeDefIndex: 14373
	{
		// Fields
		public DurationsType durationsType; // 0x68
		[ShowIf] // 0x0000000180112080-0x00000001801120B0
		public BBParameter<float> fadeInTime; // 0x70
		[ShowIf] // 0x0000000180112080-0x00000001801120B0
		public BBParameter<float> sustainTime; // 0x78
		[ShowIf] // 0x0000000180112080-0x00000001801120B0
		public BBParameter<float> fadeOutTime; // 0x80
		public BBParameter<float> intensity; // 0x88
		public BBParameter<bool> useLocalPlayerPosition; // 0x90
		public BBParameter<bool> waitToContinue; // 0x98
		private float _oldFadeIn; // 0xA0
		private float _oldSustain; // 0xA4
		private float _oldFadeOut; // 0xA8
	
		// Properties
		protected override string info { get; } // 0x000000018154F3F0-0x000000018154F420 
	
		// Nested types
		public enum DurationsType // TypeDefIndex: 14374
		{
			AgentBased = 0,
			NodeValues = 1
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Chill>d__14 : IEnumerator<object> // TypeDefIndex: 14375
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public float inWait; // 0x20
			public LocalPlayerScreenShake <>4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Chill>d__14(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018155A040-0x000000018155A120
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018155A120-0x000000018155A170
		}
	
		// Constructors
		public LocalPlayerScreenShake(); // 0x000000018154F350-0x000000018154F3F0
	
		// Methods
		protected override void OnExecute(); // 0x000000018154ED50-0x000000018154F350
		[IteratorStateMachine] // 0x0000000180112440-0x0000000180112490
		private IEnumerator Chill(float inWait); // 0x000000018154ECE0-0x000000018154ED50
	}
}
