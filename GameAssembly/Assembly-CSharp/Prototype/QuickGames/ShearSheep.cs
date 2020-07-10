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
	public class ShearSheep : QuickGamesBase // TypeDefIndex: 16246
	{
		// Fields
		[Header] // 0x000000018015F1C0-0x000000018015F1F0
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
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ScissorShear>d__16 : IEnumerator<object> // TypeDefIndex: 16247
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ShearSheep <>4__this; // 0x20
			private bool <open>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ScissorShear>d__16(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153B980-0x000000018153BAD0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153BAD0-0x000000018153BB20
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__18 : IEnumerator<object> // TypeDefIndex: 16248
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ShearSheep <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__18(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153F340-0x000000018153F4C0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153F4C0-0x000000018153F510
		}
	
		// Constructors
		public ShearSheep(); // 0x0000000181539E70-0x0000000181539F50
	
		// Methods
		public override void MStart(); // 0x0000000181539630-0x0000000181539A00
		[IteratorStateMachine] // 0x000000018015F410-0x000000018015F460
		private IEnumerator ScissorShear(); // 0x0000000181539DB0-0x0000000181539E10
		public override void QuickGameUpdate(); // 0x0000000181539A00-0x0000000181539DB0
		[IteratorStateMachine] // 0x000000018015F6F0-0x000000018015F740
		public override IEnumerator ShowResults(); // 0x0000000181539E10-0x0000000181539E70
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181527E70-0x0000000181527ED0
	}
}
