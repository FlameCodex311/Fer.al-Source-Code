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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class RiverCrossController : QuickGamesBase, IPointerDownHandler, IPointerUpHandler // TypeDefIndex: 14974
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowIntro>d__22 : IEnumerator<object> // TypeDefIndex: 14975
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RiverCrossController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowIntro>d__22(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A5F410-0x0000000180A5F580
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A5F580-0x0000000180A5F5D0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__37 : IEnumerator<object> // TypeDefIndex: 14976
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RiverCrossController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__37(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A61250-0x0000000180A61430
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A61430-0x0000000180A61480
		}
	
		// Constructors
		public RiverCrossController(); // 0x0000000180A58840-0x0000000180A58860
	
		// Methods
		public override void MStart(); // 0x0000000180A58110-0x0000000180A58230
		[IteratorStateMachine] // 0x00000001802789D0-0x0000000180278A20
		public override IEnumerator ShowIntro(); // 0x0000000180A585C0-0x0000000180A58620
		private void Initialize(); // 0x0000000180A57D60-0x0000000180A58110
		private void CreateLogs(); // 0x0000000180A57770-0x0000000180A57AB0
		public override void QuickGameUpdate(); // 0x0000000180A58540-0x0000000180A585C0
		private void FixedUpdate(); // 0x0000000180A57AC0-0x0000000180A57D10
		public void OnPointerDown(PointerEventData pointerEventData); // 0x0000000180A58230-0x0000000180A58280
		public void OnPointerUp(PointerEventData pointerEventData); // 0x0000000180A58280-0x0000000180A584C0
		public void HandlePlayerLogCollision(GameObject log); // 0x0000000180A57D10-0x0000000180A57D20
		public void HandlePlayerLogExit(GameObject log); // 0x0000000180A57D20-0x0000000180A57D60
		public void StartPlayerMove(int vDirection); // 0x000000018091FA00-0x000000018091FA10
		public void FinishPlayerMove(); // 0x0000000180A57AB0-0x0000000180A57AC0
		private void UpdatePlayerState(); // 0x0000000180A58680-0x0000000180A58840
		public void PlayerReachedGoal(); // 0x0000000180A58500-0x0000000180A58540
		public void PlayerDied(); // 0x0000000180A584C0-0x0000000180A58500
		[IteratorStateMachine] // 0x0000000180278C90-0x0000000180278CE0
		public override IEnumerator ShowResults(); // 0x0000000180A58620-0x0000000180A58680
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180A4DD60-0x0000000180A4DDC0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__1(); // 0x0000000180A4A590-0x0000000180A4A5F0
	}
}
