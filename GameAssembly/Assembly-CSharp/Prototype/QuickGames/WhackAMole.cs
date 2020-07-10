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
	public class WhackAMole : QuickGamesBase // TypeDefIndex: 16255
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
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__19 : IEnumerator<object> // TypeDefIndex: 16256
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public WhackAMole <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__19(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181605560-0x00000001816055F0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001816055F0-0x0000000181605640
		}
	
		// Constructors
		public WhackAMole(); // 0x0000000181395910-0x0000000181395920
	
		// Methods
		public override void MStart(); // 0x0000000181609860-0x0000000181609990
		private void Initialize(); // 0x0000000181608EC0-0x0000000181609860
		public override void QuickGameUpdate(); // 0x00000001816099D0-0x0000000181609C20
		public void MoleWhacked(WhackAMoleHoleController controller); // 0x0000000181609990-0x00000001816099D0
		[IteratorStateMachine] // 0x0000000180168540-0x0000000180168590
		public override IEnumerator ShowResults(); // 0x0000000181609C20-0x0000000181609C80
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181395900-0x0000000181395910
	}
}
