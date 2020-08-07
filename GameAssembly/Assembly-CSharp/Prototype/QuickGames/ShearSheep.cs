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
	public class ShearSheep : QuickGamesBase // TypeDefIndex: 14988
	{
		// Fields
		[Header] // 0x0000000180280450-0x0000000180280480
		public GameObject woolHolder; // 0xF0
		public RawImage sheepImage; // 0xF8
		public Texture scissors_open; // 0x100
		public Texture scissors_closed; // 0x108
		public float scissorSpeed; // 0x110
		public float woolMultiplier; // 0x114
		public float woolGravity; // 0x118
		public float woolMass; // 0x11C
		public float clickDistance; // 0x120
		private Vector2 _woolDir; // 0x124
		private bool _isClicking; // 0x12C
		private QuickGamesMoveCursor _cursorMover; // 0x130
		private RawImage _scissors_image; // 0x138
		private List<Transform> _wools; // 0x140
		private List<Vector2> _woolsPositions; // 0x148
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ScissorShear>d__16 : IEnumerator<object> // TypeDefIndex: 14989
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ShearSheep <>4__this; // 0x20
			private bool <open>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ScissorShear>d__16(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A40AE0-0x0000000180A40C30
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A40C30-0x0000000180A40C80
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__18 : IEnumerator<object> // TypeDefIndex: 14990
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ShearSheep <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__18(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A41F90-0x0000000180A420C0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A420C0-0x0000000180A42110
		}
	
		// Constructors
		public ShearSheep(); // 0x0000000180A3CC70-0x0000000180A3CD50
	
		// Methods
		public override void MStart(); // 0x0000000180A3C4A0-0x0000000180A3C830
		[IteratorStateMachine] // 0x00000001802805C0-0x0000000180280610
		private IEnumerator ScissorShear(); // 0x0000000180A3CBB0-0x0000000180A3CC10
		public override void QuickGameUpdate(); // 0x0000000180A3C830-0x0000000180A3CBB0
		[IteratorStateMachine] // 0x00000001802807E0-0x0000000180280830
		public override IEnumerator ShowResults(); // 0x0000000180A3CC10-0x0000000180A3CC70
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180982AE0-0x0000000180982AF0
	}
}
