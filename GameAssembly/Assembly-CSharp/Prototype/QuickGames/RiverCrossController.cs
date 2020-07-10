/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class RiverCrossController : QuickGamesBase, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 16232
	{
		// Fields
		public GameObject instructions; // 0xF0
		public float instructionTime; // 0xF8
		public GameObject groundStartPrefab; // 0x100
		public GameObject groundFinishPrefab; // 0x108
		public GameObject logPrefab; // 0x110
		public GameObject playerPrefab; // 0x118
		public int numLogRows; // 0x120
		private GameObject player; // 0x128
		private GameObject groundStart; // 0x130
		private GameObject groundFinish; // 0x138
		private GameObject board; // 0x140
		private RectTransform playerRectTransform; // 0x148
		private Rigidbody2D playerBody; // 0x150
		private List<List<GameObject>> logRows; // 0x158
		private List<int> rowDirections; // 0x160
		private int playerRow; // 0x168
		private GameObject currentLog; // 0x170
		private float logSpeed; // 0x178
		private bool updatePlayerState; // 0x17C
		private bool pointerDown; // 0x17D
		private Vector2 pointerDownPos; // 0x180
		private int _verticalDir; // 0x188
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowIntro>d__22 : IEnumerator<object> // TypeDefIndex: 16233
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RiverCrossController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowIntro>d__22(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153DDA0-0x000000018153DF10
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153DF10-0x000000018153DF60
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__37 : IEnumerator<object> // TypeDefIndex: 16234
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RiverCrossController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__37(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153FF80-0x0000000181540170
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181540170-0x00000001815401C0
		}
	
		// Constructors
		public RiverCrossController(); // 0x00000001815364E0-0x0000000181536500
	
		// Methods
		public override void MStart(); // 0x0000000181535DA0-0x0000000181535EC0
		[IteratorStateMachine] // 0x0000000180158E50-0x0000000180158EA0
		public override IEnumerator ShowIntro(); // 0x0000000181536250-0x00000001815362B0
		private void Initialize(); // 0x00000001815359D0-0x0000000181535DA0
		private void CreateLogs(); // 0x00000001815353E0-0x0000000181535720
		public override void QuickGameUpdate(); // 0x00000001815361D0-0x0000000181536250
		private void FixedUpdate(); // 0x0000000181535730-0x0000000181535980
		public void OnPointerDown(PointerEventData pointerEventData); // 0x0000000181535EC0-0x0000000181535F10
		public void OnPointerUp(PointerEventData pointerEventData); // 0x0000000181535F10-0x0000000181536150
		public void HandlePlayerLogCollision(GameObject log); // 0x0000000181535980-0x0000000181535990
		public void HandlePlayerLogExit(GameObject log); // 0x0000000181535990-0x00000001815359D0
		public void StartPlayerMove(int vDirection); // 0x0000000181442220-0x0000000181442230
		public void FinishPlayerMove(); // 0x0000000181535720-0x0000000181535730
		private void UpdatePlayerState(); // 0x0000000181536310-0x00000001815364E0
		public void PlayerReachedGoal(); // 0x0000000181536190-0x00000001815361D0
		public void PlayerDied(); // 0x0000000181536150-0x0000000181536190
		[IteratorStateMachine] // 0x0000000180159040-0x0000000180159090
		public override IEnumerator ShowResults(); // 0x00000001815362B0-0x0000000181536310
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x000000018152B740-0x000000018152B7A0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__1(); // 0x0000000181527E70-0x0000000181527ED0
	}
}
