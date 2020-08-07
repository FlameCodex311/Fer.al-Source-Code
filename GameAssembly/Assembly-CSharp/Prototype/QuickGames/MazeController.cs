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
	public class MazeController : QuickGamesBase // TypeDefIndex: 14918
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
		public class MazeChunk // TypeDefIndex: 14919
		{
			// Fields
			public List<MazeCellController> cells; // 0x10
	
			// Constructors
			public MazeChunk(MazeCellController cell); // 0x0000000180A49430-0x0000000180A494D0
	
			// Methods
			public void Connect(MazeChunk other); // 0x0000000180A49320-0x0000000180A49430
		}
	
		private class MazeEdge // TypeDefIndex: 14920
		{
			// Fields
			public int x; // 0x10
			public int y; // 0x14
			public int dx; // 0x18
			public int dy; // 0x1C
			public int direction; // 0x20
			public int opposite; // 0x24
	
			// Constructors
			public MazeEdge(int x, int y, int dx, int dy, int direction, int opposite); // 0x0000000180A4AB00-0x0000000180A4AB60
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <MovePlayer>d__28 : IEnumerator<object> // TypeDefIndex: 14921
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MazeController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <MovePlayer>d__28(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A5CB40-0x0000000180A5CC80
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A5CC80-0x0000000180A5CCD0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AnimatePlayerMovement>d__29 : IEnumerator<object> // TypeDefIndex: 14922
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MazeController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AnimatePlayerMovement>d__29(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A5BFF0-0x0000000180A5C170
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A5C170-0x0000000180A5C1C0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__31 : IEnumerator<object> // TypeDefIndex: 14923
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public MazeController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__31(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A610D0-0x0000000180A611B0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A611B0-0x0000000180A61200
		}
	
		// Constructors
		public MazeController(); // 0x0000000180A4AAE0-0x0000000180A4AB00
	
		// Methods
		public override void MStart(); // 0x0000000180A49B60-0x0000000180A49E00
		private void Initialize(); // 0x0000000180A49A60-0x0000000180A49B60
		private void UpdatePlayerPos(int dx, int dy); // 0x0000000180A4A5F0-0x0000000180A4AAE0
		[IteratorStateMachine] // 0x000000018025DB70-0x000000018025DBC0
		private IEnumerator MovePlayer(); // 0x0000000180A49EB0-0x0000000180A49F10
		[IteratorStateMachine] // 0x000000018025DDE0-0x000000018025DE30
		private IEnumerator AnimatePlayerMovement(); // 0x0000000180A494D0-0x0000000180A49530
		public override void MUpdate(); // 0x0000000180A49E00-0x0000000180A49EB0
		[IteratorStateMachine] // 0x000000018025E020-0x000000018025E070
		public override IEnumerator ShowResults(); // 0x0000000180A4A530-0x0000000180A4A590
		private void SetUpMaze(); // 0x0000000180A49F10-0x0000000180A4A530
		private void GenerateMaze(); // 0x0000000180A49530-0x0000000180A49A60
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180A4A590-0x0000000180A4A5F0
	}
}
