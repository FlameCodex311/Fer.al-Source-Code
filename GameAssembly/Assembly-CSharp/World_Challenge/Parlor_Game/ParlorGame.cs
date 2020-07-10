/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using World_Challenge.Parlor_Table;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace World_Challenge.Parlor_Game
{
	public class ParlorGame : ManagedBehaviour // TypeDefIndex: 15539
	{
		// Fields
		[Header] // 0x000000018010C640-0x000000018010C670
		public Transform hUDInstructions; // 0x50
		public Transform cameraPositionOverride; // 0x58
		public float timeForResults; // 0x60
		public int wager1; // 0x64
		public int wager2; // 0x68
		public int wager3; // 0x6C
		internal ParlorTable parlorTable; // 0x70
		internal EGamesState gamesState; // 0x78
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private EGamesResults <gamesResults>k__BackingField; // 0x7C
	
		// Properties
		public EGamesResults gamesResults { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001808CAC70-0x00000001808CAC80 0x00000001809337D0-0x00000001809337E0
	
		// Nested types
		internal enum EGamesState // TypeDefIndex: 15540
		{
			NONE = 0,
			INITIALIZED = 1,
			PLAYING = 2,
			RESULTS = 3
		}
	
		public enum EGamesResults // TypeDefIndex: 15541
		{
			NONE = 0,
			WIN = 1,
			SURVIVING = 2,
			LOSE = 3
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__19 : IEnumerator<object> // TypeDefIndex: 15542
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ParlorGame <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__19(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171EEE0-0x000000018171F040
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171F040-0x000000018171F090
		}
	
		// Constructors
		public ParlorGame(); // 0x000000018170C6B0-0x000000018170C720
	
		// Methods
		public override void MStart(); // 0x000000018170C290-0x000000018170C480
		internal void ShowInstructions(bool inShow); // 0x000000018170C540-0x000000018170C6B0
		internal virtual void ResultsDone(); // 0x00000001803581E0-0x00000001803581F0
		internal virtual void Intro(); // 0x00000001803581E0-0x00000001803581F0
		public void GameResults(); // 0x000000018170C250-0x000000018170C290
		[IteratorStateMachine] // 0x000000018010C9E0-0x000000018010CA30
		public virtual IEnumerator ShowResults(); // 0x000000018170BEC0-0x000000018170BF20
		private void ParlorGameOver(); // 0x000000018170C480-0x000000018170C540
	}
}
