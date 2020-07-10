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
	public class RoadCross : QuickGamesBase // TypeDefIndex: 16241
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
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Move>d__31 : IEnumerator<object> // TypeDefIndex: 16242
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RoadCross <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Move>d__31(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153B670-0x000000018153B930
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153B930-0x000000018153B980
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AnimateMovement>d__32 : IEnumerator<object> // TypeDefIndex: 16243
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RoadCross <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AnimateMovement>d__32(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153A480-0x000000018153A600
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153A600-0x000000018153A650
		}
	
		// Constructors
		public RoadCross(); // 0x0000000181537EF0-0x0000000181537F10
	
		// Methods
		public override void MStart(); // 0x0000000181537810-0x0000000181537970
		private void Initialize(); // 0x0000000181537190-0x0000000181537810
		public override void QuickGameUpdate(); // 0x00000001815379D0-0x0000000181537DD0
		private void TryMovePlayer(); // 0x0000000181537DD0-0x0000000181537EF0
		[IteratorStateMachine] // 0x000000018015D7B0-0x000000018015D800
		private IEnumerator Move(); // 0x0000000181537970-0x00000001815379D0
		[IteratorStateMachine] // 0x000000018015DA30-0x000000018015DA80
		private IEnumerator AnimateMovement(); // 0x00000001815370C0-0x0000000181537120
		private void CheckPlayerPosition(); // 0x0000000181537120-0x0000000181537190
		public void HandlePlayerEnemyCollision(); // 0x0000000181536150-0x0000000181536190
		public void HandlePlayerWin(); // 0x00000001803581E0-0x00000001803581F0
	}
}
