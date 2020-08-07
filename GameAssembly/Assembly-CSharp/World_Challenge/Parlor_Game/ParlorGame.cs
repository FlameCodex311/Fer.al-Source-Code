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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace World_Challenge.Parlor_Game
{
	public class ParlorGame : ManagedBehaviour // TypeDefIndex: 14694
	{
		// Fields
		[Header] // 0x0000000180290BF0-0x0000000180290C20
		public Transform hUDInstructions; // 0x50
		public Transform cameraPositionOverride; // 0x58
		public float timeForResults; // 0x60
		public int wager1; // 0x64
		public int wager2; // 0x68
		public int wager3; // 0x6C
		internal ParlorTable parlorTable; // 0x70
		internal EGamesState gamesState; // 0x78
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private EGamesResults <gamesResults>k__BackingField; // 0x7C
	
		// Properties
		public EGamesResults gamesResults { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803A1570-0x00000001803A1580 0x00000001804794D0-0x00000001804794E0
	
		// Nested types
		internal enum EGamesState // TypeDefIndex: 14695
		{
			NONE = 0,
			INITIALIZED = 1,
			PLAYING = 2,
			RESULTS = 3
		}
	
		public enum EGamesResults // TypeDefIndex: 14696
		{
			NONE = 0,
			WIN = 1,
			SURVIVING = 2,
			LOSE = 3
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__19 : IEnumerator<object> // TypeDefIndex: 14697
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ParlorGame <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__19(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E81D70-0x0000000180E81ED0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E81ED0-0x0000000180E81F20
		}
	
		// Constructors
		public ParlorGame(); // 0x0000000180E71320-0x0000000180E71390
	
		// Methods
		public override void MStart(); // 0x0000000180E70F10-0x0000000180E71100
		internal void ShowInstructions(bool inShow); // 0x0000000180E711B0-0x0000000180E71320
		internal virtual void ResultsDone(); // 0x00000001803774A0-0x00000001803774B0
		internal virtual void Intro(); // 0x00000001803774A0-0x00000001803774B0
		public void GameResults(); // 0x0000000180E70ED0-0x0000000180E70F10
		[IteratorStateMachine] // 0x0000000180292360-0x00000001802923B0
		public virtual IEnumerator ShowResults(); // 0x0000000180E70B50-0x0000000180E70BB0
		private void ParlorGameOver(); // 0x0000000180E71100-0x0000000180E711B0
	}
}
