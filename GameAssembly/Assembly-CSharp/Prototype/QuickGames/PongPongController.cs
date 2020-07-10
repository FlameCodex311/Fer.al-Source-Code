/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class PongPongController : QuickGamesBase // TypeDefIndex: 16206
	{
		// Fields
		public GameObject paddlePrefab; // 0xF0
		public GameObject ballPrefab; // 0xF8
		public GameObject playerGoal; // 0x100
		public GameObject enemyGoal; // 0x108
		public GameObject playerScoreTextHolder; // 0x110
		public GameObject enemyScoreTextHolder; // 0x118
		public float playerPaddleSpeed; // 0x120
		public float enemyPaddleSpeed; // 0x124
		private GameObject board; // 0x128
		private Rect boardRect; // 0x130
		private Rect paddleRect; // 0x140
		private Rect ballRect; // 0x150
		private GameObject playerPaddle; // 0x160
		private GameObject enemyPaddle; // 0x168
		private PongPongPaddleController playerPaddleController; // 0x170
		private PongPongPaddleController enemyPaddleController; // 0x178
		private GameObject ball; // 0x180
		private PongPongBallController ballController; // 0x188
		private Vector2 playerStartPos; // 0x190
		private Vector2 enemyStartPos; // 0x198
		private Vector2 ballStartPos; // 0x1A0
		private int playerScore; // 0x1A8
		private int enemyScore; // 0x1AC
		private UnityEngine.UI.Text playerScoreText; // 0x1B0
		private UnityEngine.UI.Text enemyScoreText; // 0x1B8
		private bool isPlaying; // 0x1C0
		private bool isResetting; // 0x1C1
		private bool needsReset; // 0x1C2
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__31 : IEnumerator<object> // TypeDefIndex: 16207
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public PongPongController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__31(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153FCB0-0x000000018153FD50
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153FF30-0x000000018153FF80
		}
	
		// Constructors
		public PongPongController(); // 0x0000000181395910-0x0000000181395920
	
		// Methods
		public override void MStart(); // 0x000000018152F0A0-0x000000018152F3A0
		private void Initialize(); // 0x000000018152ECB0-0x000000018152F0A0
		public override void QuickGameUpdate(); // 0x000000018152F3A0-0x000000018152F510
		[IteratorStateMachine] // 0x000000018014D120-0x000000018014D170
		public override IEnumerator ShowResults(); // 0x000000018152F700-0x000000018152F760
		private void StartRound(); // 0x000000018152F760-0x000000018152F7B0
		private void ResetGame(); // 0x000000018152F510-0x000000018152F700
		public void BallEnteredGoal(GameObject goal); // 0x000000018152E910-0x000000018152EA50
		public Vector2 CheckForPaddleForce(GameObject o); // 0x000000018152EA50-0x000000018152ECB0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181527E70-0x0000000181527ED0
	}
}
