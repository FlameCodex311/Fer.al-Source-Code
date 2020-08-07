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
	public class JumpGaps : QuickGamesBase // TypeDefIndex: 14871
	{
		// Fields
		[Header] // 0x000000018023FB10-0x000000018023FB40
		public Rigidbody2D plank; // 0xF0
		public Transform ball; // 0xF8
		public GameObject failZone; // 0x100
		public Transform midFrame; // 0x108
		public float ballStartPositionX; // 0x110
		public float plankStartPositionX; // 0x114
		public float gapWidth; // 0x118
		public float plankSpacing; // 0x11C
		public float plankSpeed; // 0x120
		public float plankCycles; // 0x124
		public float jumpForce; // 0x128
		public float ballGravity; // 0x12C
		public int numStartingPlanks; // 0x130
		private bool _isJumping; // 0x134
		private int _plankSiblingIndex; // 0x138
		private Vector3 _positionHolder; // 0x13C
		private Vector2 _jumpForce; // 0x148
		private Vector2 _plankVelocity; // 0x150
		private Rigidbody2D _ballRB; // 0x158
		private List<Rigidbody2D> _planks; // 0x160
		private FailZone _failZone; // 0x168
	
		// Nested types
		private class FailZone : MonoBehaviour // TypeDefIndex: 14872
		{
			// Fields
			public JumpGaps Game; // 0x20
	
			// Constructors
			public FailZone(); // 0x00000001803743C0-0x00000001803743D0
	
			// Methods
			private void OnTriggerEnter2D(Collider2D collision); // 0x000000018097E7E0-0x000000018097E860
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__26 : IEnumerator<object> // TypeDefIndex: 14873
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public JumpGaps <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__26(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180995360-0x00000001809955F0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001809955F0-0x0000000180995640
		}
	
		// Constructors
		public JumpGaps(); // 0x0000000180984A20-0x0000000180984B50
	
		// Methods
		public override void MStart(); // 0x0000000180984380-0x0000000180984690
		public override void QuickGameUpdate(); // 0x0000000180984900-0x00000001809849C0
		private void MakePlank(); // 0x0000000180984690-0x00000001809848E0
		private void MissedJump(); // 0x00000001809848E0-0x0000000180984900
		[IteratorStateMachine] // 0x000000018023FDD0-0x000000018023FE20
		public override IEnumerator ShowResults(); // 0x00000001809849C0-0x0000000180984A20
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180982AE0-0x0000000180982AF0
	}
}
