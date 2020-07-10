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
	public class QGE_ShellGame : QuickGamesBase // TypeDefIndex: 16249
	{
		// Fields
		[Header] // 0x000000018010CE10-0x000000018010CE40
		public QGE_ShellGameObject obj_shell; // 0xF0
		public GameObject obj_ball; // 0xF8
		[Header] // 0x0000000180162030-0x0000000180162060
		public float xOffset; // 0x100
		public float yShuffleOffset; // 0x104
		[Header] // 0x00000001800B57D0-0x00000001800B5800
		public float timeToShowBall; // 0x108
		public int numberOfShuffles; // 0x10C
		public float timePerShuffle; // 0x110
		[Header] // 0x00000001800B86F0-0x00000001800B8720
		public float fadeOutTime; // 0x114
		private QGE_ShellGameObject[] _shells; // 0x118
		private Transform[] _shells_transforms; // 0x120
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowIntro>d__11 : IEnumerator<object> // TypeDefIndex: 16250
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public QGE_ShellGame <>4__this; // 0x20
			private int <i>5__2; // 0x28
			private int <index_1>5__3; // 0x2C
			private int <index_2>5__4; // 0x30
			private float <x>5__5; // 0x34
			private float <halfTime>5__6; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowIntro>d__11(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153BB20-0x000000018153CDE0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153CDE0-0x000000018153CE30
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__13 : IEnumerator<object> // TypeDefIndex: 16251
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public QGE_ShellGame <>4__this; // 0x20
			private Color <transparentWhite>5__2; // 0x28
			private float <i>5__3; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__13(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153EA80-0x000000018153F0B0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153F0B0-0x000000018153F100
		}
	
		// Constructors
		public QGE_ShellGame(); // 0x00000001815327C0-0x0000000181532860
	
		// Methods
		public override void MStart(); // 0x0000000181531ED0-0x0000000181532700
		[IteratorStateMachine] // 0x00000001801626D0-0x0000000180162720
		public override IEnumerator ShowIntro(); // 0x0000000181532700-0x0000000181532760
		public void ButtonClick(bool inFoundBall); // 0x0000000181531E70-0x0000000181531ED0
		[IteratorStateMachine] // 0x0000000180162B40-0x0000000180162B90
		public override IEnumerator ShowResults(); // 0x0000000181532760-0x00000001815327C0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x000000018152B740-0x000000018152B7A0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__1(); // 0x0000000181527E70-0x0000000181527ED0
	}
}
