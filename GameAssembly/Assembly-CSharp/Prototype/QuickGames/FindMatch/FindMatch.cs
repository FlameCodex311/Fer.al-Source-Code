/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Prototype.QuickGames;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames.FindMatch
{
	public class FindMatch : QuickGamesBase // TypeDefIndex: 16297
	{
		// Fields
		[Header] // 0x00000001800B57D0-0x00000001800B5800
		public float timeForIntro; // 0xF0
		[Header] // 0x00000001800B8130-0x00000001800B8160
		public Texture[] matchImages; // 0xF8
		public Texture emberImage; // 0x100
		public FindMatchObject findMatchObject; // 0x108
		public int gridSpotsX; // 0x110
		public int gridSpotsY; // 0x114
		public float emberRiseTime; // 0x118
		public float emberRiseHeight; // 0x11C
		public float zonkTime; // 0x120
		[Header] // 0x00000001800B86F0-0x00000001800B8720
		public float resultsFadeTime; // 0x124
		internal bool canClick; // 0x128
		private Color _transparentWhite; // 0x12C
		private int _embersFound; // 0x13C
		private int _numberOfObjectsMatched; // 0x140
		private List<FindMatchObject> _objectsToMatch; // 0x148
		private int _indexToMatch; // 0x150
		private List<FindMatchObject> _zonkCards; // 0x158
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 16298
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<FindMatchObject> <>9__17_0; // 0x08
			public static Comparison<FindMatchObject> <>9__18_0; // 0x10
			public static Comparison<FindMatchObject> <>9__18_1; // 0x18
			public static Comparison<FindMatchObject> <>9__18_2; // 0x20
			public static Comparison<FindMatchObject> <>9__18_3; // 0x28
			public static Comparison<FindMatchObject> <>9__18_4; // 0x30
			public static Comparison<FindMatchObject> <>9__18_5; // 0x38
			public static Comparison<FindMatchObject> <>9__18_6; // 0x40
			public static Comparison<FindMatchObject> <>9__18_7; // 0x48
	
			// Constructors
			static <>c(); // 0x00000001813B0EF0-0x00000001813B0F50
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal int <MStart>b__17_0(FindMatchObject a, FindMatchObject b); // 0x00000001813B06C0-0x00000001813B0710
			internal int <ShowIntro>b__18_0(FindMatchObject b, FindMatchObject a); // 0x00000001813B0710-0x00000001813B0760
			internal int <ShowIntro>b__18_1(FindMatchObject a, FindMatchObject b); // 0x00000001813B0650-0x00000001813B06C0
			internal int <ShowIntro>b__18_2(FindMatchObject a, FindMatchObject b); // 0x00000001813B0760-0x00000001813B0810
			internal int <ShowIntro>b__18_3(FindMatchObject b, FindMatchObject a); // 0x00000001813B0810-0x00000001813B08C0
			internal int <ShowIntro>b__18_4(FindMatchObject a, FindMatchObject b); // 0x00000001813B08C0-0x00000001813B0970
			internal int <ShowIntro>b__18_5(FindMatchObject b, FindMatchObject a); // 0x00000001813B0970-0x00000001813B0A20
			internal int <ShowIntro>b__18_6(FindMatchObject a, FindMatchObject b); // 0x00000001813B0A20-0x00000001813B0AD0
			internal int <ShowIntro>b__18_7(FindMatchObject b, FindMatchObject a); // 0x00000001813B0AD0-0x00000001813B0B80
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowIntro>d__18 : IEnumerator<object> // TypeDefIndex: 16299
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FindMatch <>4__this; // 0x20
			private int <x>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowIntro>d__18(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813ACBF0-0x00000001813AD590
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813AD590-0x00000001813AD5E0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <EmberRise>d__20 : IEnumerator<object> // TypeDefIndex: 16300
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FindMatch <>4__this; // 0x20
			public RawImage inRawImage; // 0x28
			public UnityEngine.UI.Text inContentsInfoText; // 0x30
			private float <halfTime>5__2; // 0x38
			private Transform <emberTrans>5__3; // 0x40
			private Vector2 <startPos>5__4; // 0x48
			private Vector2 <endPos>5__5; // 0x50
			private float <f>5__6; // 0x58
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <EmberRise>d__20(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813A8360-0x00000001813A8700
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813A8700-0x00000001813A8750
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Zonk>d__21 : IEnumerator<object> // TypeDefIndex: 16301
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FindMatch <>4__this; // 0x20
			private float <halfTime>5__2; // 0x28
			private float <f>5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Zonk>d__21(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181400F70-0x0000000181401320
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181401320-0x0000000181401370
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__22 : IEnumerator<object> // TypeDefIndex: 16302
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FindMatch <>4__this; // 0x20
			private float <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__22(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813FE540-0x00000001813FEC90
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813FEC90-0x00000001813FECE0
		}
	
		// Constructors
		public FindMatch(); // 0x00000001813A39E0-0x00000001813A3AD0
	
		// Methods
		public override void MStart(); // 0x00000001813A3000-0x00000001813A38A0
		[IteratorStateMachine] // 0x00000001800C5480-0x00000001800C54D0
		public override IEnumerator ShowIntro(); // 0x00000001813A38A0-0x00000001813A3900
		public void FoundObject(FindMatchObject inObject); // 0x00000001813A2C60-0x00000001813A3000
		[IteratorStateMachine] // 0x00000001800C56C0-0x00000001800C5710
		private IEnumerator EmberRise(RawImage inRawImage, UnityEngine.UI.Text inContentsInfoText); // 0x00000001813A2BE0-0x00000001813A2C60
		[IteratorStateMachine] // 0x00000001800C5950-0x00000001800C59A0
		private IEnumerator Zonk(); // 0x00000001813A3970-0x00000001813A39E0
		[IteratorStateMachine] // 0x00000001800C5CA0-0x00000001800C5CF0
		public override IEnumerator ShowResults(); // 0x00000001813A3900-0x00000001813A3970
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181396DA0-0x0000000181396DB0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__1(); // 0x0000000181395900-0x0000000181395910
	}
}
