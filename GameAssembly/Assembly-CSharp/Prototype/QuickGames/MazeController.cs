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
	public class MazeController : QuickGamesBase // TypeDefIndex: 16176
	{
		// Fields
		public GameObject playerPrefab; // 0xF0
		public GameObject cellPrefab; // 0xF8
		public int numRows; // 0x100
		public int numColumns; // 0x104
		private GameObject board; // 0x108
		private Rect boardRect; // 0x110
		private Rect cellRect; // 0x120
		private Rect playerRect; // 0x130
		private RectTransform playerRectTransform; // 0x140
		private MazeCellController[][] cellControllers; // 0x148
		private GameObject player; // 0x150
		private int playerX; // 0x158
		private int playerY; // 0x15C
		private float playerOffsetX; // 0x160
		private float playerOffsetY; // 0x164
		private bool playerMoving; // 0x168
		private float moveTime; // 0x16C
		private float elapsedMoveTime; // 0x170
		private float normalizedTime; // 0x174
		private Vector2 movePosA; // 0x178
		private Vector2 movePosB; // 0x180
		private int startX; // 0x188
		private int startY; // 0x18C
		private int goalX; // 0x190
		private int goalY; // 0x194
	
		// Nested types
		public class MazeChunk // TypeDefIndex: 16177
		{
			// Fields
			public List<MazeCellController> cells; // 0x10
	
			// Constructors
			public MazeChunk(MazeCellController cell); // 0x0000000181526C90-0x0000000181526D30
	
			// Methods
			public void Connect(MazeChunk other); // 0x0000000181526B70-0x0000000181526C90
		}
	
		private class MazeEdge // TypeDefIndex: 16178
		{
			// Fields
			public int x; // 0x10
			public int y; // 0x14
			public int dx; // 0x18
			public int dy; // 0x1C
			public int direction; // 0x20
			public int opposite; // 0x24
	
			// Constructors
			public MazeEdge(int x, int y, int dx, int dy, int direction, int opposite); // 0x0000000181528410-0x0000000181528470
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <MovePlayer>d__28 : IEnumerator<object> // TypeDefIndex: 16179
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MazeController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <MovePlayer>d__28(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153B1F0-0x000000018153B340
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153B340-0x000000018153B390
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AnimatePlayerMovement>d__29 : IEnumerator<object> // TypeDefIndex: 16180
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MazeController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AnimatePlayerMovement>d__29(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153A650-0x000000018153A7D0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153A7D0-0x000000018153A820
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__31 : IEnumerator<object> // TypeDefIndex: 16181
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MazeController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__31(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153FDF0-0x000000018153FEE0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153FEE0-0x000000018153FF30
		}
	
		// Constructors
		public MazeController(); // 0x00000001815283F0-0x0000000181528410
	
		// Methods
		public override void MStart(); // 0x0000000181527400-0x00000001815276B0
		private void Initialize(); // 0x0000000181527300-0x0000000181527400
		private void UpdatePlayerPos(int dx, int dy); // 0x0000000181527ED0-0x00000001815283F0
		[IteratorStateMachine] // 0x000000018013F170-0x000000018013F1C0
		private IEnumerator MovePlayer(); // 0x0000000181527760-0x00000001815277C0
		[IteratorStateMachine] // 0x000000018013F420-0x000000018013F470
		private IEnumerator AnimatePlayerMovement(); // 0x0000000181526D30-0x0000000181526D90
		public override void MUpdate(); // 0x00000001815276B0-0x0000000181527760
		[IteratorStateMachine] // 0x000000018013F760-0x000000018013F7B0
		public override IEnumerator ShowResults(); // 0x0000000181527E10-0x0000000181527E70
		private void SetUpMaze(); // 0x00000001815277C0-0x0000000181527E10
		private void GenerateMaze(); // 0x0000000181526D90-0x0000000181527300
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181527E70-0x0000000181527ED0
	}
}
