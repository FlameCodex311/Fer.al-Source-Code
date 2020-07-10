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
	public class MatchThree : QuickGamesBase // TypeDefIndex: 16162
	{
		// Fields
		[RootSelector] // 0x0000000180132150-0x00000001801321B0
		public string recipeDefId; // 0xF0
		public GameObject instructions; // 0xF8
		public GameObject cellPrefab; // 0x100
		public GameObject cursorPrefab; // 0x108
		public GameObject glowPrefab; // 0x110
		public int numRows; // 0x118
		public int numColumns; // 0x11C
		private GameObject board; // 0x120
		private GameObject boardOverlay; // 0x128
		private GameObject cursor; // 0x130
		private MatchThreeCursorController cursorController; // 0x138
		private Rect boardRect; // 0x140
		private Rect cellRect; // 0x150
		private int cursorDirection; // 0x160
		private int cursorX; // 0x164
		private int cursorY; // 0x168
		private int checkNumber; // 0x16C
		private MatchThreeCellController[][] cellControllers; // 0x170
		private int numStandardTypes; // 0x178
		private int numSpecialTypes; // 0x17C
		private List<int[]> keyRoots; // 0x180
		private List<MatchThreeCellController> keyControllers; // 0x188
		private List<List<MatchThreeCellController>> keyDependents; // 0x190
		private bool useKeyboardControls; // 0x198
		private int keysCollected; // 0x19C
		private GameObject keyHolder; // 0x1A0
		private GameObject keySlot_a; // 0x1A8
		private GameObject keySlot_b; // 0x1B0
		private GameObject keySlot_c; // 0x1B8
		private bool _isSwapping; // 0x1C0
		private bool _isMouseSwap; // 0x1C1
		private float _swapTime; // 0x1C4
		private float _currentTime; // 0x1C8
		private float _normalizedTime; // 0x1CC
		private Vector2 _swapPosA; // 0x1D0
		private Vector2 _swapPosB; // 0x1D8
		private RectTransform _swapRectA; // 0x1E0
		private RectTransform _swapRectB; // 0x1E8
		private int swapTargetX; // 0x1F0
		private int swapTargetY; // 0x1F4
		private Vector3 pendingPosition; // 0x1F8
		private int selectionX; // 0x204
		private int selectionY; // 0x208
		private Vector3 selectionPos; // 0x20C
		private bool selecting; // 0x218
		private string resultString; // 0x220
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowIntro>d__30 : IEnumerator<object> // TypeDefIndex: 16163
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MatchThree <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowIntro>d__30(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FD960-0x00000001813FDA30
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FDA30-0x00000001813FDA80
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <SwapCells>d__49 : IEnumerator<object> // TypeDefIndex: 16164
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MatchThree <>4__this; // 0x20
			private int[] <cellIndices>5__2; // 0x28
			private MatchThreeCellController <cellControllerA>5__3; // 0x30
			private MatchThreeCellController <cellControllerB>5__4; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <SwapCells>d__49(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001814004F0-0x0000000181400ED0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181400ED0-0x0000000181400F20
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AnimateCellMovement>d__50 : IEnumerator<object> // TypeDefIndex: 16165
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MatchThree <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AnimateCellMovement>d__50(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813F8DD0-0x00000001813F8FB0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813F8FB0-0x00000001813F9000
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__64 : IEnumerator<object> // TypeDefIndex: 16166
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MatchThree <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__64(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FFD20-0x0000000181400240
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181400240-0x0000000181400290
		}
	
		// Constructors
		public MatchThree(); // 0x00000001813F85B0-0x00000001813F85E0
	
		// Methods
		public override void MStart(); // 0x00000001813F72B0-0x00000001813F76D0
		[IteratorStateMachine] // 0x00000001801323C0-0x0000000180132410
		public override IEnumerator ShowIntro(); // 0x00000001813F78A0-0x00000001813F7900
		private void Initialize(); // 0x00000001813F6940-0x00000001813F7140
		private int[][] InitPrizes(); // 0x00000001813F5750-0x00000001813F6940
		private bool Swap(int[][] state, int[][] shuffledCoords, int numMoves); // 0x00000001813F7C00-0x00000001813F85B0
		private void InitCursor(float xStart, float yStart); // 0x00000001813F5560-0x00000001813F5750
		public override void QuickGameUpdate(); // 0x00000001813F76D0-0x00000001813F78A0
		private void HandleKeyInput(); // 0x00000001813F52C0-0x00000001813F5560
		[IteratorStateMachine] // 0x00000001801326E0-0x0000000180132730
		private IEnumerator SwapCells(); // 0x00000001813F7BA0-0x00000001813F7C00
		[IteratorStateMachine] // 0x0000000180132A00-0x0000000180132A50
		private IEnumerator AnimateCellMovement(); // 0x00000001813F4150-0x00000001813F41B0
		private void CheckMatches(); // 0x00000001813F43A0-0x00000001813F4AC0
		private void CheckKeyState(); // 0x00000001813F4220-0x00000001813F43A0
		public void KeyOpened(MatchThreeCellController cellController); // 0x00000001813F7140-0x00000001813F72B0
		public void CellClicked(MatchThreeCellController cellController); // 0x00000001813F41B0-0x00000001813F4210
		public void CellReleased(MatchThreeCellController cellController); // 0x00000001813F4210-0x00000001813F4220
		private void CheckMouseMove(); // 0x00000001813F4AC0-0x00000001813F4C80
		private MatchThreeCellController[] GetNeighbors(int x, int y); // 0x00000001813F4F00-0x00000001813F52C0
		private void CheckResults(); // 0x00000001813F4C80-0x00000001813F4F00
		[IteratorStateMachine] // 0x0000000180132D10-0x0000000180132D60
		public override IEnumerator ShowResults(); // 0x00000001813F7900-0x00000001813F7960
		private int[] Shuffle(int[] arr); // 0x00000001813F7AC0-0x00000001813F7BA0
		private int[][] Shuffle(int[][] arr, int l); // 0x00000001813F7960-0x00000001813F7AC0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181396DA0-0x0000000181396DB0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__1(); // 0x0000000181395900-0x0000000181395910
	}
}
