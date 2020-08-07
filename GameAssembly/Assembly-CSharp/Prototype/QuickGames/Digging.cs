/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class Digging : QuickGamesBase // TypeDefIndex: 14839
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
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float difficultyChance; // 0x19C
		public int maxDifficults; // 0x1A0
		private GameObject board; // 0x1A8
		private Rect boardRect; // 0x1B0
		private Rect cellRect; // 0x1C0
		private int collectedEmbers; // 0x1D0
		private int collectedUncommons; // 0x1D4
		private int collectedRares; // 0x1D8
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowIntro>d__34 : IEnumerator<object> // TypeDefIndex: 14840
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Digging <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowIntro>d__34(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE1EE0-0x0000000180AE2000
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE2000-0x0000000180AE2050
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__38 : IEnumerator<object> // TypeDefIndex: 14841
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public Digging <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__38(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE44A0-0x0000000180AE48B0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE48B0-0x0000000180AE4900
		}
	
		// Constructors
		public Digging(); // 0x0000000180AD6560-0x0000000180AD65D0
	
		// Methods
		public override void MStart(); // 0x0000000180AD6320-0x0000000180AD64A0
		[IteratorStateMachine] // 0x00000001802272F0-0x0000000180227340
		public override IEnumerator ShowIntro(); // 0x0000000180AD64A0-0x0000000180AD6500
		private void Initialize(); // 0x0000000180AD5900-0x0000000180AD6320
		public override void QuickGameUpdate(); // 0x0000000180373240-0x0000000180373250
		public void Collect(DiggingCellController diggingCell); // 0x0000000180AD5880-0x0000000180AD5900
		[IteratorStateMachine] // 0x00000001802274F0-0x0000000180227540
		public override IEnumerator ShowResults(); // 0x0000000180AD6500-0x0000000180AD6560
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180982AD0-0x0000000180982AE0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__1(); // 0x0000000180982AE0-0x0000000180982AF0
	}
}
