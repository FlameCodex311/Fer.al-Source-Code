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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001802802E0-0x0000000180280340
	[Description] // 0x00000001802802E0-0x0000000180280340
	public class LocalPlayerScreenShake : ActionTask<CinemachineImpulseSource> // TypeDefIndex: 15476
	{
		// Fields
		public DurationsType durationsType; // 0x68
		[ShowIf] // 0x0000000180280500-0x0000000180280530
		public BBParameter<float> fadeInTime; // 0x70
		[ShowIf] // 0x0000000180280500-0x0000000180280530
		public BBParameter<float> sustainTime; // 0x78
		[ShowIf] // 0x0000000180280500-0x0000000180280530
		public BBParameter<float> fadeOutTime; // 0x80
		public BBParameter<float> intensity; // 0x88
		public BBParameter<bool> useLocalPlayerPosition; // 0x90
		public BBParameter<bool> waitToContinue; // 0x98
		private float _oldFadeIn; // 0xA0
		private float _oldSustain; // 0xA4
		private float _oldFadeOut; // 0xA8
	
		// Properties
		protected override string info { get; } // 0x0000000180BB51A0-0x0000000180BB51D0 
	
		// Nested types
		public enum DurationsType // TypeDefIndex: 15477
		{
			AgentBased = 0,
			NodeValues = 1
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Chill>d__14 : IEnumerator<object> // TypeDefIndex: 15478
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public float inWait; // 0x20
			public LocalPlayerScreenShake <>4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Chill>d__14(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180BBE820-0x0000000180BBE900
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180BBE900-0x0000000180BBE950
		}
	
		// Constructors
		public LocalPlayerScreenShake(); // 0x0000000180BB5100-0x0000000180BB51A0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB4B20-0x0000000180BB5100
		[IteratorStateMachine] // 0x0000000180280880-0x00000001802808D0
		private IEnumerator Chill(float inWait); // 0x0000000180BB4AB0-0x0000000180BB4B20
	}
}
