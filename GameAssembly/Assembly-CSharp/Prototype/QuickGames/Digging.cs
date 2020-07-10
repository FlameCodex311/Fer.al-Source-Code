/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class Digging : QuickGamesBase // TypeDefIndex: 16097
	{
		// Fields
		public GameObject instructions; // 0xF0
		public float instructionTime; // 0xF8
		public GameObject cellPrefab; // 0x100
		public GameObject borderPrefab; // 0x108
		public Sprite defaultContentsPartial; // 0x110
		public Sprite defaultContents; // 0x118
		public Sprite tripleEmberContentsPartial; // 0x120
		public Sprite tripleEmberContents; // 0x128
		public Sprite uncommonContentsPartial; // 0x130
		public Sprite uncommonContents; // 0x138
		public Sprite uncommonContentsOpen; // 0x140
		public Sprite rareContentsPartial; // 0x148
		public Sprite rareContents; // 0x150
		public Sprite rareContentsOpen; // 0x158
		public Sprite bombContentsPartial; // 0x160
		public Sprite bombContents; // 0x168
		public Sprite emptyContentsPartial; // 0x170
		public Sprite emptyContents; // 0x178
		public int numRows; // 0x180
		public int numColumns; // 0x184
		public int numRares; // 0x188
		public int numUncommons; // 0x18C
		public int numBombs; // 0x190
		public int numTripleEmbers; // 0x194
		public int numEmbers; // 0x198
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float difficultyChance; // 0x19C
		public int maxDifficults; // 0x1A0
		private GameObject board; // 0x1A8
		private Rect boardRect; // 0x1B0
		private Rect cellRect; // 0x1C0
		private int collectedEmbers; // 0x1D0
		private int collectedUncommons; // 0x1D4
		private int collectedRares; // 0x1D8
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowIntro>d__34 : IEnumerator<object> // TypeDefIndex: 16098
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Digging <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowIntro>d__34(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813ADB30-0x00000001813ADC50
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813ADC50-0x00000001813ADCA0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__38 : IEnumerator<object> // TypeDefIndex: 16099
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Digging <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__38(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813AF530-0x00000001813AF960
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813AF960-0x00000001813AF9B0
		}
	
		// Constructors
		public Digging(); // 0x00000001813A00F0-0x00000001813A0160
	
		// Methods
		public override void MStart(); // 0x000000018139FEB0-0x00000001813A0030
		[IteratorStateMachine] // 0x0000000180106FD0-0x0000000180107020
		public override IEnumerator ShowIntro(); // 0x00000001813A0030-0x00000001813A0090
		private void Initialize(); // 0x000000018139F460-0x000000018139FEB0
		public override void QuickGameUpdate(); // 0x000000018036B6C0-0x000000018036B6D0
		public void Collect(DiggingCellController diggingCell); // 0x000000018139F3E0-0x000000018139F460
		[IteratorStateMachine] // 0x00000001801071F0-0x0000000180107240
		public override IEnumerator ShowResults(); // 0x00000001813A0090-0x00000001813A00F0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181396DA0-0x0000000181396DB0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__1(); // 0x0000000181395900-0x0000000181395910
	}
}
