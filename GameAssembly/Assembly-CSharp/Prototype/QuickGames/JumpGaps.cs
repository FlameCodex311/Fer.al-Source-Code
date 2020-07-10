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
	public class JumpGaps : QuickGamesBase // TypeDefIndex: 16129
	{
		// Fields
		[Header] // 0x000000018011E600-0x000000018011E630
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
		private class FailZone : MonoBehaviour // TypeDefIndex: 16130
		{
			// Fields
			public JumpGaps Game; // 0x20
	
			// Constructors
			public FailZone(); // 0x0000000180E095D0-0x0000000180E095E0
	
			// Methods
			private void OnTriggerEnter2D(Collider2D collision); // 0x00000001813E6180-0x00000001813E6200
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__26 : IEnumerator<object> // TypeDefIndex: 16131
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public JumpGaps <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__26(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FF0D0-0x00000001813FF370
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FF370-0x00000001813FF3C0
		}
	
		// Constructors
		public JumpGaps(); // 0x00000001813ED500-0x00000001813ED630
	
		// Methods
		public override void MStart(); // 0x00000001813ECE50-0x00000001813ED160
		public override void QuickGameUpdate(); // 0x00000001813ED3E0-0x00000001813ED4A0
		private void MakePlank(); // 0x00000001813ED160-0x00000001813ED3C0
		private void MissedJump(); // 0x00000001813ED3C0-0x00000001813ED3E0
		[IteratorStateMachine] // 0x000000018011E790-0x000000018011E7E0
		public override IEnumerator ShowResults(); // 0x00000001813ED4A0-0x00000001813ED500
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181395900-0x0000000181395910
	}
}
