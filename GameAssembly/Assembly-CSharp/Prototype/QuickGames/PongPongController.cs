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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class PongPongController : QuickGamesBase // TypeDefIndex: 14948
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__31 : IEnumerator<object> // TypeDefIndex: 14949
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public PongPongController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__31(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A60F90-0x0000000180A61030
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A61200-0x0000000180A61250
		}
	
		// Constructors
		public PongPongController(); // 0x0000000180A46040-0x0000000180A46050
	
		// Methods
		public override void MStart(); // 0x0000000180A515C0-0x0000000180A518B0
		private void Initialize(); // 0x0000000180A511E0-0x0000000180A515C0
		public override void QuickGameUpdate(); // 0x0000000180A518B0-0x0000000180A51A20
		[IteratorStateMachine] // 0x000000018026BDF0-0x000000018026BE40
		public override IEnumerator ShowResults(); // 0x0000000180A51C10-0x0000000180A51C70
		private void StartRound(); // 0x0000000180A51C70-0x0000000180A51CC0
		private void ResetGame(); // 0x0000000180A51A20-0x0000000180A51C10
		public void BallEnteredGoal(GameObject goal); // 0x0000000180A50E40-0x0000000180A50F80
		public Vector2 CheckForPaddleForce(GameObject o); // 0x0000000180A50F80-0x0000000180A511E0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180A4A590-0x0000000180A4A5F0
	}
}
