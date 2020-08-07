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
	public class MatchThree : QuickGamesBase // TypeDefIndex: 14904
	{
		// Fields
		[RootSelector] // 0x0000000180252440-0x00000001802524A0
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowIntro>d__30 : IEnumerator<object> // TypeDefIndex: 14905
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MatchThree <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowIntro>d__30(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001809948B0-0x0000000180994980
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180994980-0x00000001809949D0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <SwapCells>d__49 : IEnumerator<object> // TypeDefIndex: 14906
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MatchThree <>4__this; // 0x20
			private int[] <cellIndices>5__2; // 0x28
			private MatchThreeCellController <cellControllerA>5__3; // 0x30
			private MatchThreeCellController <cellControllerB>5__4; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <SwapCells>d__49(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001809966F0-0x0000000180997050
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180997050-0x00000001809970A0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AnimateCellMovement>d__50 : IEnumerator<object> // TypeDefIndex: 14907
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MatchThree <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AnimateCellMovement>d__50(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180990110-0x00000001809902F0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001809902F0-0x0000000180990340
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__64 : IEnumerator<object> // TypeDefIndex: 14908
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MatchThree <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__64(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180995F60-0x0000000180996450
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180996450-0x00000001809964A0
		}
	
		// Constructors
		public MatchThree(); // 0x000000018098F900-0x000000018098F930
	
		// Methods
		public override void MStart(); // 0x000000018098E700-0x000000018098EAF0
		[IteratorStateMachine] // 0x0000000180252830-0x0000000180252880
		public override IEnumerator ShowIntro(); // 0x000000018098ECC0-0x000000018098ED20
		private void Initialize(); // 0x000000018098DC90-0x000000018098E590
		private int[][] InitPrizes(); // 0x000000018098CBD0-0x000000018098DC90
		private bool Swap(int[][] state, int[][] shuffledCoords, int numMoves); // 0x000000018098F000-0x000000018098F900
		private void InitCursor(float xStart, float yStart); // 0x000000018098C9E0-0x000000018098CBD0
		public override void QuickGameUpdate(); // 0x000000018098EAF0-0x000000018098ECC0
		private void HandleKeyInput(); // 0x000000018098C740-0x000000018098C9E0
		[IteratorStateMachine] // 0x0000000180252B10-0x0000000180252B60
		private IEnumerator SwapCells(); // 0x000000018098EFA0-0x000000018098F000
		[IteratorStateMachine] // 0x0000000180252D20-0x0000000180252D70
		private IEnumerator AnimateCellMovement(); // 0x000000018098B540-0x000000018098B5A0
		private void CheckMatches(); // 0x000000018098B790-0x000000018098BF90
		private void CheckKeyState(); // 0x000000018098B610-0x000000018098B790
		public void KeyOpened(MatchThreeCellController cellController); // 0x000000018098E590-0x000000018098E700
		public void CellClicked(MatchThreeCellController cellController); // 0x000000018098B5A0-0x000000018098B600
		public void CellReleased(MatchThreeCellController cellController); // 0x000000018098B600-0x000000018098B610
		private void CheckMouseMove(); // 0x000000018098BF90-0x000000018098C150
		private MatchThreeCellController[] GetNeighbors(int x, int y); // 0x000000018098C3C0-0x000000018098C740
		private void CheckResults(); // 0x000000018098C150-0x000000018098C3C0
		[IteratorStateMachine] // 0x0000000180253120-0x0000000180253170
		public override IEnumerator ShowResults(); // 0x000000018098ED20-0x000000018098ED80
		private int[] Shuffle(int[] arr); // 0x000000018098EED0-0x000000018098EFA0
		private int[][] Shuffle(int[][] arr, int l); // 0x000000018098ED80-0x000000018098EED0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180982AD0-0x0000000180982AE0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__1(); // 0x0000000180982AE0-0x0000000180982AF0
	}
}
