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
	public class QGE_ShellGame : QuickGamesBase // TypeDefIndex: 14991
	{
		// Fields
		[Header] // 0x0000000180281B30-0x0000000180281B60
		public QGE_ShellGameObject obj_shell; // 0xF0
		public GameObject obj_ball; // 0xF8
		[Header] // 0x0000000180281D20-0x0000000180281D50
		public float xOffset; // 0x100
		public float yShuffleOffset; // 0x104
		[Header] // 0x00000001801D1640-0x00000001801D1670
		public float timeToShowBall; // 0x108
		public int numberOfShuffles; // 0x10C
		public float timePerShuffle; // 0x110
		[Header] // 0x00000001801D7080-0x00000001801D70B0
		public float fadeOutTime; // 0x114
		private QGE_ShellGameObject[] _shells; // 0x118
		private Transform[] _shells_transforms; // 0x120
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowIntro>d__11 : IEnumerator<object> // TypeDefIndex: 14992
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowIntro>d__11(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A5D2B0-0x0000000180A5E490
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A5E490-0x0000000180A5E4E0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__13 : IEnumerator<object> // TypeDefIndex: 14993
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public QGE_ShellGame <>4__this; // 0x20
			private Color <transparentWhite>5__2; // 0x28
			private float <i>5__3; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__13(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A5FFB0-0x0000000180A60590
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A60590-0x0000000180A605E0
		}
	
		// Constructors
		public QGE_ShellGame(); // 0x0000000180A54C10-0x0000000180A54CB0
	
		// Methods
		public override void MStart(); // 0x0000000180A54380-0x0000000180A54B50
		[IteratorStateMachine] // 0x0000000180282130-0x0000000180282180
		public override IEnumerator ShowIntro(); // 0x0000000180A54B50-0x0000000180A54BB0
		public void ButtonClick(bool inFoundBall); // 0x0000000180A54320-0x0000000180A54380
		[IteratorStateMachine] // 0x00000001802823B0-0x0000000180282400
		public override IEnumerator ShowResults(); // 0x0000000180A54BB0-0x0000000180A54C10
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180A4DD60-0x0000000180A4DDC0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__1(); // 0x0000000180A4A590-0x0000000180A4A5F0
	}
}
