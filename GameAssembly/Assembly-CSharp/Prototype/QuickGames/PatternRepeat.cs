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
	public class PatternRepeat : QuickGamesBase // TypeDefIndex: 16184
	{
		// Fields
		[Header] // 0x0000000180143700-0x0000000180143730
		public PatternRepeatObject objectToRepeat; // 0xF0
		public Texture offImage; // 0xF8
		public Texture onImage; // 0x100
		public Texture goodImage; // 0x108
		public Texture badImage; // 0x110
		public int numberOfObjectsToChooseFrom; // 0x118
		public float distanceFromCenterToPlace; // 0x11C
		public int numberOfobjectsInPattern; // 0x120
		[Header] // 0x00000001800B57D0-0x00000001800B5800
		public float timeToShowGood; // 0x124
		public float timeBetweenShowing; // 0x128
		private int _repeatIndex; // 0x12C
		private List<PatternRepeatObject> _repeatingObjects; // 0x130
		private List<PatternRepeatObject> _allObjects; // 0x138
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 16185
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<PatternRepeatObject> <>9__15_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001815407E0-0x0000000181540840
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal int <ShowIntro>b__15_0(PatternRepeatObject y, PatternRepeatObject x); // 0x0000000181540790-0x00000001815407E0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowIntro>d__15 : IEnumerator<object> // TypeDefIndex: 16186
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public PatternRepeat <>4__this; // 0x20
			private int <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowIntro>d__15(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153CE30-0x000000018153D260
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153D260-0x000000018153D2B0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__17 : IEnumerator<object> // TypeDefIndex: 16187
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public PatternRepeat <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__17(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153F100-0x000000018153F2F0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153F2F0-0x000000018153F340
		}
	
		// Constructors
		public PatternRepeat(); // 0x000000018152B7A0-0x000000018152B860
	
		// Methods
		public override void MStart(); // 0x000000018152B1C0-0x000000018152B5C0
		private Vector2 RotateV2(Vector2 v, float degrees); // 0x000000018152B5C0-0x000000018152B680
		[IteratorStateMachine] // 0x0000000180143960-0x00000001801439B0
		public override IEnumerator ShowIntro(); // 0x000000018152B680-0x000000018152B6E0
		public bool ButtonClick(int inIndex); // 0x000000018152B090-0x000000018152B1C0
		[IteratorStateMachine] // 0x0000000180143B40-0x0000000180143B90
		public override IEnumerator ShowResults(); // 0x000000018152B6E0-0x000000018152B740
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x000000018152B740-0x000000018152B7A0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__1(); // 0x0000000181527E70-0x0000000181527ED0
	}
}
