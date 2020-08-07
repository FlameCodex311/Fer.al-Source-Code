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
	public class RoadCross : QuickGamesBase // TypeDefIndex: 14983
	{
		// Fields
		public GameObject playerPrefab; // 0xF0
		public GameObject enemyPrefab; // 0xF8
		public GameObject finishLinePrefab; // 0x100
		public int numEnemyRows; // 0x108
		public float enemySpeed; // 0x10C
		private GameObject player; // 0x110
		private List<List<GameObject>> enemyRows; // 0x118
		private GameObject finishLine; // 0x120
		private GameObject board; // 0x128
		private Rect boardRect; // 0x130
		private Rect enemyRect; // 0x140
		private RectTransform playerRectTransform; // 0x150
		private Rigidbody2D playerBody; // 0x158
		private int enemyStartDirection; // 0x160
		private float enemyMinX; // 0x164
		private float enemyMaxX; // 0x168
		private int maxEnemiesPerRow; // 0x16C
		private float enemyPadding; // 0x170
		private float finishLineY; // 0x174
		private float movementAmount; // 0x178
		private bool _isMoving; // 0x17C
		private float _moveTime; // 0x180
		private float _currentTime; // 0x184
		private float _normalizedTime; // 0x188
		private Vector2 _originalPos; // 0x18C
		private Vector2 _targetPos; // 0x194
		private Vector2 _movementDir; // 0x19C
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Move>d__31 : IEnumerator<object> // TypeDefIndex: 14984
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RoadCross <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Move>d__31(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A5CFB0-0x0000000180A5D260
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A5D260-0x0000000180A5D2B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AnimateMovement>d__32 : IEnumerator<object> // TypeDefIndex: 14985
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RoadCross <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AnimateMovement>d__32(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A5BE20-0x0000000180A5BFA0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A5BFA0-0x0000000180A5BFF0
		}
	
		// Constructors
		public RoadCross(); // 0x0000000180A5A210-0x0000000180A5A230
	
		// Methods
		public override void MStart(); // 0x0000000180A59B40-0x0000000180A59CA0
		private void Initialize(); // 0x0000000180A594E0-0x0000000180A59B40
		public override void QuickGameUpdate(); // 0x0000000180A59D00-0x0000000180A5A0F0
		private void TryMovePlayer(); // 0x0000000180A5A0F0-0x0000000180A5A210
		[IteratorStateMachine] // 0x000000018027DAC0-0x000000018027DB10
		private IEnumerator Move(); // 0x0000000180A59CA0-0x0000000180A59D00
		[IteratorStateMachine] // 0x000000018027DD20-0x000000018027DD70
		private IEnumerator AnimateMovement(); // 0x0000000180A59410-0x0000000180A59470
		private void CheckPlayerPosition(); // 0x0000000180A59470-0x0000000180A594E0
		public void HandlePlayerEnemyCollision(); // 0x0000000180A584C0-0x0000000180A58500
		public void HandlePlayerWin(); // 0x00000001803774A0-0x00000001803774B0
	}
}
