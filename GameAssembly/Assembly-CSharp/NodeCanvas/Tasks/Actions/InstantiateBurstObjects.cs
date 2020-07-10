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
	[Category] // 0x000000018010F140-0x000000018010F1A0
	[Description] // 0x000000018010F140-0x000000018010F1A0
	public class InstantiateBurstObjects : ActionTask<Transform> // TypeDefIndex: 14363
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
		protected override string info { get; } // 0x000000018154D5F0-0x000000018154D980 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Spawn>d__12 : IEnumerator<object> // TypeDefIndex: 14364
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public InstantiateBurstObjects <>4__this; // 0x20
			private int <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Spawn>d__12(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018155BC10-0x000000018155C140
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018155C140-0x000000018155C190
		}
	
		// Constructors
		public InstantiateBurstObjects(); // 0x000000018154D530-0x000000018154D5F0
	
		// Methods
		protected override void OnExecute(); // 0x000000018154D390-0x000000018154D4D0
		[IteratorStateMachine] // 0x000000018010F300-0x000000018010F350
		private IEnumerator Spawn(); // 0x000000018154D4D0-0x000000018154D530
	}
}
