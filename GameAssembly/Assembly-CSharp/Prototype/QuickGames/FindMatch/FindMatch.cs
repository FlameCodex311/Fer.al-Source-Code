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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames.FindMatch
{
	public class FindMatch : QuickGamesBase // TypeDefIndex: 15039
	{
		// Fields
		[Header] // 0x00000001801D1640-0x00000001801D1670
		public float timeForIntro; // 0xF0
		[Header] // 0x00000001801D6F60-0x00000001801D6F90
		public Texture[] matchImages; // 0xF8
		public Texture emberImage; // 0x100
		public FindMatchObject findMatchObject; // 0x108
		public int gridSpotsX; // 0x110
		public int gridSpotsY; // 0x114
		public float emberRiseTime; // 0x118
		public float emberRiseHeight; // 0x11C
		public float zonkTime; // 0x120
		[Header] // 0x00000001801D7080-0x00000001801D70B0
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15040
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
			static <>c(); // 0x0000000180AE55C0-0x0000000180AE5620
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal int <MStart>b__17_0(FindMatchObject a, FindMatchObject b); // 0x0000000180A616A0-0x0000000180A616F0
			internal int <ShowIntro>b__18_0(FindMatchObject b, FindMatchObject a); // 0x0000000180A61730-0x0000000180A61780
			internal int <ShowIntro>b__18_1(FindMatchObject a, FindMatchObject b); // 0x0000000180A61780-0x0000000180A617F0
			internal int <ShowIntro>b__18_2(FindMatchObject a, FindMatchObject b); // 0x0000000180A617F0-0x0000000180A61890
			internal int <ShowIntro>b__18_3(FindMatchObject b, FindMatchObject a); // 0x0000000180A61890-0x0000000180A61930
			internal int <ShowIntro>b__18_4(FindMatchObject a, FindMatchObject b); // 0x0000000180A61930-0x0000000180A619E0
			internal int <ShowIntro>b__18_5(FindMatchObject b, FindMatchObject a); // 0x0000000180A619E0-0x0000000180A61A80
			internal int <ShowIntro>b__18_6(FindMatchObject a, FindMatchObject b); // 0x0000000180A61A80-0x0000000180A61B20
			internal int <ShowIntro>b__18_7(FindMatchObject b, FindMatchObject a); // 0x0000000180A61B20-0x0000000180A61BC0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowIntro>d__18 : IEnumerator<object> // TypeDefIndex: 15041
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FindMatch <>4__this; // 0x20
			private int <x>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowIntro>d__18(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE0F40-0x0000000180AE1940
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE1940-0x0000000180AE1990
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <EmberRise>d__20 : IEnumerator<object> // TypeDefIndex: 15042
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <EmberRise>d__20(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180ADE9C0-0x0000000180ADED50
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180ADED50-0x0000000180ADEDA0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Zonk>d__21 : IEnumerator<object> // TypeDefIndex: 15043
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FindMatch <>4__this; // 0x20
			private float <halfTime>5__2; // 0x28
			private float <f>5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Zonk>d__21(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE5620-0x0000000180AE59C0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE59C0-0x0000000180AEA050
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__22 : IEnumerator<object> // TypeDefIndex: 15044
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public FindMatch <>4__this; // 0x20
			private float <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__22(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE2690-0x0000000180AE2DB0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE2DB0-0x0000000180AE2E00
		}
	
		// Constructors
		public FindMatch(); // 0x0000000180ADA030-0x0000000180ADA120
	
		// Methods
		public override void MStart(); // 0x0000000180AD9690-0x0000000180AD9F10
		[IteratorStateMachine] // 0x00000001801D7170-0x00000001801D71C0
		public override IEnumerator ShowIntro(); // 0x0000000180AD9F10-0x0000000180AD9F70
		public void FoundObject(FindMatchObject inObject); // 0x0000000180AD9300-0x0000000180AD9690
		[IteratorStateMachine] // 0x00000001801D7340-0x00000001801D7390
		private IEnumerator EmberRise(RawImage inRawImage, UnityEngine.UI.Text inContentsInfoText); // 0x0000000180AD9280-0x0000000180AD9300
		[IteratorStateMachine] // 0x00000001801D7780-0x00000001801D77D0
		private IEnumerator Zonk(); // 0x0000000180AD9FD0-0x0000000180ADA030
		[IteratorStateMachine] // 0x00000001801D7920-0x00000001801D7970
		public override IEnumerator ShowResults(); // 0x0000000180AD9F70-0x0000000180AD9FD0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180982AD0-0x0000000180982AE0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__1(); // 0x0000000180982AE0-0x0000000180982AF0
	}
}
