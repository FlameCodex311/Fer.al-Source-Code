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
	public class RiverCrossLogController : MonoBehaviour // TypeDefIndex: 14977
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AnimateMovement>d__15 : IEnumerator<object> // TypeDefIndex: 14978
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RiverCrossLogController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AnimateMovement>d__15(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A5BA50-0x0000000180A5BC20
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A5BC20-0x0000000180A5BC70
		}
	
		// Constructors
		public RiverCrossLogController(); // 0x00000001803743C0-0x00000001803743D0
	
		// Methods
		public void SetUp(float speed, int direction, int type, Vector2 position); // 0x0000000180A58930-0x0000000180A58B00
		public void Move(bool value); // 0x0000000180A588C0-0x0000000180A58930
		[IteratorStateMachine] // 0x000000018027B5C0-0x000000018027B610
		private IEnumerator AnimateMovement(); // 0x0000000180A58860-0x0000000180A588C0
		public void UpdatePosition(); // 0x0000000180A58B00-0x0000000180A58C80
	}
}
