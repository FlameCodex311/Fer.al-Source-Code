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
	[Category] // 0x000000018027C430-0x000000018027C490
	[Description] // 0x000000018027C430-0x000000018027C490
	public class InstantiateBurstObjects : ActionTask<Transform> // TypeDefIndex: 15466
	{
		// Fields
		public BBParameter<GameObject> gameObjectToSpawn; // 0x68
		public BBParameter<int> numToSpawnMin; // 0x70
		public BBParameter<int> numToSpawnMax; // 0x78
		public BBParameter<float> burstForceMin; // 0x80
		public BBParameter<float> burstForceMax; // 0x88
		public BBParameter<float> timeToSpawn; // 0x90
		public BBParameter<bool> waitToContinue; // 0x98
		private float _spawnTime; // 0xA0
		private int _numToSpawn; // 0xA4
	
		// Properties
		protected override string info { get; } // 0x0000000180BB3450-0x0000000180BB37B0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Spawn>d__12 : IEnumerator<object> // TypeDefIndex: 15467
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public InstantiateBurstObjects <>4__this; // 0x20
			private int <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Spawn>d__12(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180BC05C0-0x0000000180BC0AE0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180BC0AE0-0x0000000180BC0B30
		}
	
		// Constructors
		public InstantiateBurstObjects(); // 0x0000000180BB3390-0x0000000180BB3450
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB31F0-0x0000000180BB3330
		[IteratorStateMachine] // 0x000000018027C6E0-0x000000018027C730
		private IEnumerator Spawn(); // 0x0000000180BB3330-0x0000000180BB3390
	}
}
