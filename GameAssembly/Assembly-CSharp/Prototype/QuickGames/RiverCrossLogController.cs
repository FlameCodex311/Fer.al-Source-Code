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
	public class RiverCrossLogController : MonoBehaviour // TypeDefIndex: 16235
	{
		// Fields
		public float speed; // 0x20
		public int direction; // 0x24
		public int type; // 0x28
		private GameObject log; // 0x30
		private Rigidbody2D logBody; // 0x38
		private RectTransform logRectTransform; // 0x40
		private float minX; // 0x48
		private float maxX; // 0x4C
		private bool moving; // 0x50
		private Vector2 positionA; // 0x54
		private Vector2 positionB; // 0x5C
		private Vector2 nextPosition; // 0x64
		private bool resetPosition; // 0x6C
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AnimateMovement>d__15 : IEnumerator<object> // TypeDefIndex: 16236
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RiverCrossLogController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AnimateMovement>d__15(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153A0A0-0x000000018153A280
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153A280-0x000000018153A2D0
		}
	
		// Constructors
		public RiverCrossLogController(); // 0x0000000180E095D0-0x0000000180E095E0
	
		// Methods
		public void SetUp(float speed, int direction, int type, Vector2 position); // 0x00000001815365D0-0x00000001815367B0
		public void Move(bool value); // 0x0000000181536560-0x00000001815365D0
		[IteratorStateMachine] // 0x000000018015A870-0x000000018015A8C0
		private IEnumerator AnimateMovement(); // 0x0000000181536500-0x0000000181536560
		public void UpdatePosition(); // 0x00000001815367B0-0x0000000181536930
	}
}
