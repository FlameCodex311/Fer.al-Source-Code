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
	[Category] // 0x0000000180289EF0-0x0000000180289F50
	[Description] // 0x0000000180289EF0-0x0000000180289F50
	public class ParticleSystemsPlay : ActionTask // TypeDefIndex: 15522
	{
		// Fields
		public bool enableFirst; // 0x68
		public float disableDelay; // 0x6C
		public List<ParticleSystem> particleSystems; // 0x70
		public List<BBParameter<ParticleSystem>> particleSystemsVARS; // 0x78
	
		// Properties
		protected override string info { get; } // 0x0000000180BBD8C0-0x0000000180BBDD70 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Disable>d__7 : IEnumerator<object> // TypeDefIndex: 15523
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ParticleSystemsPlay <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Disable>d__7(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180BBE950-0x0000000180BBEB60
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180BBEB60-0x0000000180BBEBB0
		}
	
		// Constructors
		public ParticleSystemsPlay(); // 0x0000000180BBD830-0x0000000180BBD8C0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BBD5D0-0x0000000180BBD830
		[IteratorStateMachine] // 0x000000018028A190-0x000000018028A1E0
		private IEnumerator Disable(); // 0x0000000180BBD570-0x0000000180BBD5D0
	}
}
