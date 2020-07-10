/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using World_Challenge.Casual_Game_Table;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace World_Challenge.Casual_Game
{
	public class CasualGame : ManagedBehaviour // TypeDefIndex: 15622
	{
		// Fields
		[Header] // 0x000000018013F560-0x000000018013F590
		public Transform hUDInstructions; // 0x50
		public Transform cameraPositionOverride; // 0x58
		public float timeForResults; // 0x60
		internal CasualGameTable casualGameTable; // 0x68
		internal EGamesState gamesState; // 0x70
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private EGamesResults <gamesResults>k__BackingField; // 0x74
	
		// Properties
		public EGamesResults gamesResults { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803DAD10-0x00000001803DAD20 0x00000001803DAEB0-0x00000001803DAEC0
	
		// Nested types
		internal enum EGamesState // TypeDefIndex: 15623
		{
			NONE = 0,
			INITIALIZED = 1,
			PLAYING = 2,
			RESULTS = 3
		}
	
		public enum EGamesResults // TypeDefIndex: 15624
		{
			NONE = 0,
			WIN = 1,
			SURVIVING = 2,
			LOSE = 3
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__16 : IEnumerator<object> // TypeDefIndex: 15625
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CasualGame <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__16(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000180FF5B90-0x0000000180FF5CF0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180FF5CF0-0x0000000180FF5D40
		}
	
		// Constructors
		public CasualGame(); // 0x0000000180FE5870-0x0000000180FE58D0
	
		// Methods
		public override void MStart(); // 0x0000000180FE54B0-0x0000000180FE56A0
		internal void ShowInstructions(bool inShow); // 0x0000000180FE56A0-0x0000000180FE5810
		internal virtual void ResultsDone(); // 0x00000001803581E0-0x00000001803581F0
		internal virtual void Intro(); // 0x00000001803581E0-0x00000001803581F0
		public void GameResults(); // 0x0000000180FE5470-0x0000000180FE54B0
		[IteratorStateMachine] // 0x000000018013F940-0x000000018013F990
		public virtual IEnumerator ShowResults(); // 0x0000000180FE5810-0x0000000180FE5870
		private void CasualGameOver(); // 0x0000000180FE53B0-0x0000000180FE5470
	}
}
