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
	public class PatternRepeat : QuickGamesBase // TypeDefIndex: 14926
	{
		// Fields
		[Header] // 0x0000000180262300-0x0000000180262330
		public PatternRepeatObject objectToRepeat; // 0xF0
		public Texture offImage; // 0xF8
		public Texture onImage; // 0x100
		public Texture goodImage; // 0x108
		public Texture badImage; // 0x110
		public int numberOfObjectsToChooseFrom; // 0x118
		public float distanceFromCenterToPlace; // 0x11C
		public int numberOfobjectsInPattern; // 0x120
		[Header] // 0x00000001801D1640-0x00000001801D1670
		public float timeToShowGood; // 0x124
		public float timeBetweenShowing; // 0x128
		private int _repeatIndex; // 0x12C
		private List<PatternRepeatObject> _repeatingObjects; // 0x130
		private List<PatternRepeatObject> _allObjects; // 0x138
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 14927
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<PatternRepeatObject> <>9__15_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180A61BC0-0x0000000180A61C20
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal int <ShowIntro>b__15_0(PatternRepeatObject y, PatternRepeatObject x); // 0x0000000180A616F0-0x0000000180A61730
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowIntro>d__15 : IEnumerator<object> // TypeDefIndex: 14928
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public PatternRepeat <>4__this; // 0x20
			private int <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowIntro>d__15(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A5E4E0-0x0000000180A5E900
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A5E900-0x0000000180A5E950
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__17 : IEnumerator<object> // TypeDefIndex: 14929
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public PatternRepeat <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__17(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A605E0-0x0000000180A607C0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A607C0-0x0000000180A60810
		}
	
		// Constructors
		public PatternRepeat(); // 0x0000000180A4DDC0-0x0000000180A4DE80
	
		// Methods
		public override void MStart(); // 0x0000000180A4D7F0-0x0000000180A4DBE0
		private Vector2 RotateV2(Vector2 v, float degrees); // 0x0000000180A4DBE0-0x0000000180A4DCA0
		[IteratorStateMachine] // 0x0000000180262750-0x00000001802627A0
		public override IEnumerator ShowIntro(); // 0x0000000180A4DCA0-0x0000000180A4DD00
		public bool ButtonClick(int inIndex); // 0x0000000180A4D6C0-0x0000000180A4D7F0
		[IteratorStateMachine] // 0x0000000180262A60-0x0000000180262AB0
		public override IEnumerator ShowResults(); // 0x0000000180A4DD00-0x0000000180A4DD60
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180A4DD60-0x0000000180A4DDC0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__1(); // 0x0000000180A4A590-0x0000000180A4A5F0
	}
}
