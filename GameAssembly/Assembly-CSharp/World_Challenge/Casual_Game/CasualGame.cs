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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace World_Challenge.Casual_Game
{
	public class CasualGame : ManagedBehaviour // TypeDefIndex: 14777
	{
		// Fields
		[Header] // 0x00000001802004B0-0x00000001802004E0
		public Transform hUDInstructions; // 0x50
		public Transform cameraPositionOverride; // 0x58
		public float timeForResults; // 0x60
		internal CasualGameTable casualGameTable; // 0x68
		internal EGamesState gamesState; // 0x70
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EGamesResults <gamesResults>k__BackingField; // 0x74
	
		// Properties
		public EGamesResults gamesResults { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001804428A0-0x00000001804428B0 0x00000001805CF180-0x00000001805CF190
	
		// Nested types
		internal enum EGamesState // TypeDefIndex: 14778
		{
			NONE = 0,
			INITIALIZED = 1,
			PLAYING = 2,
			RESULTS = 3
		}
	
		public enum EGamesResults // TypeDefIndex: 14779
		{
			NONE = 0,
			WIN = 1,
			SURVIVING = 2,
			LOSE = 3
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__16 : IEnumerator<object> // TypeDefIndex: 14780
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CasualGame <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__16(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001805DD1C0-0x00000001805DD320
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001805DD320-0x00000001805DD370
		}
	
		// Constructors
		public CasualGame(); // 0x00000001805CF120-0x00000001805CF180
	
		// Methods
		public override void MStart(); // 0x00000001805CED60-0x00000001805CEF50
		internal void ShowInstructions(bool inShow); // 0x00000001805CEF50-0x00000001805CF0C0
		internal virtual void ResultsDone(); // 0x00000001803774A0-0x00000001803774B0
		internal virtual void Intro(); // 0x00000001803774A0-0x00000001803774B0
		public void GameResults(); // 0x00000001805CED20-0x00000001805CED60
		[IteratorStateMachine] // 0x0000000180200AD0-0x0000000180200B20
		public virtual IEnumerator ShowResults(); // 0x00000001805CF0C0-0x00000001805CF120
		private void CasualGameOver(); // 0x00000001805CEC70-0x00000001805CED20
	}
}
