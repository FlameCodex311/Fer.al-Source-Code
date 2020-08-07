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
	public class WhackAMole : QuickGamesBase // TypeDefIndex: 14997
	{
		// Fields
		public GameObject holePrefab; // 0xF0
		private GameObject board; // 0xF8
		private Rect boardRect; // 0x100
		private Rect holeRect; // 0x110
		private GameObject topHole; // 0x120
		private GameObject rightHole; // 0x128
		private GameObject bottomHole; // 0x130
		private GameObject leftHole; // 0x138
		private WhackAMoleHoleController[] holeControllers; // 0x140
		private int[] holeOrder; // 0x148
		private int currentOrder; // 0x150
		private int score; // 0x154
		private float testF; // 0x158
		private bool madeRare; // 0x15C
		private bool needRare; // 0x15D
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__19 : IEnumerator<object> // TypeDefIndex: 14998
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public WhackAMole <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__19(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A42110-0x0000000180A421A0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A421A0-0x0000000180A421F0
		}
	
		// Constructors
		public WhackAMole(); // 0x0000000180A46040-0x0000000180A46050
	
		// Methods
		public override void MStart(); // 0x0000000180A45C30-0x0000000180A45D60
		private void Initialize(); // 0x0000000180A452E0-0x0000000180A45C30
		public override void QuickGameUpdate(); // 0x0000000180A45DA0-0x0000000180A45FE0
		public void MoleWhacked(WhackAMoleHoleController controller); // 0x0000000180A45D60-0x0000000180A45DA0
		[IteratorStateMachine] // 0x0000000180286D00-0x0000000180286D50
		public override IEnumerator ShowResults(); // 0x0000000180A45FE0-0x0000000180A46040
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180982AE0-0x0000000180982AF0
	}
}
