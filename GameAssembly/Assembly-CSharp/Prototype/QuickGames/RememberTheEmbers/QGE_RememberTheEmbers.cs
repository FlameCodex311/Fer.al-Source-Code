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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames.RememberTheEmbers
{
	public class QGE_RememberTheEmbers : QuickGamesBase // TypeDefIndex: 16279
	{
		// Fields
		[Header] // 0x00000001800B8130-0x00000001800B8160
		public GameObject instructions; // 0xF0
		public Texture matchImage1; // 0xF8
		public Texture matchImage2; // 0x100
		public Texture matchImage3; // 0x108
		public Texture ingredientImage; // 0x110
		public Texture emberImage; // 0x118
		public QGE_RememberTheEmbersObject findMatchObject; // 0x120
		public int gridSpotsX; // 0x128
		public int gridSpotsY; // 0x12C
		[Header] // 0x00000001800B57D0-0x00000001800B5800
		public float timeForIntro; // 0x130
		[Header] // 0x00000001800B86F0-0x00000001800B8720
		public float resultsFadeTime; // 0x134
		private bool _foundIngredient; // 0x138
		private int _embersFound; // 0x13C
		private int _numberOfObjectsMatched; // 0x140
		private List<QGE_RememberTheEmbersObject> _objectsToMatch; // 0x148
		private QGE_RememberTheEmbersObject.EMatchObjectType _typeToMatch; // 0x150
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 16280
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<QGE_RememberTheEmbersObject> <>9__16_0; // 0x08
			public static Comparison<QGE_RememberTheEmbersObject> <>9__17_0; // 0x10
			public static Comparison<QGE_RememberTheEmbersObject> <>9__17_1; // 0x18
			public static Comparison<QGE_RememberTheEmbersObject> <>9__17_2; // 0x20
			public static Comparison<QGE_RememberTheEmbersObject> <>9__17_3; // 0x28
			public static Comparison<QGE_RememberTheEmbersObject> <>9__17_4; // 0x30
			public static Comparison<QGE_RememberTheEmbersObject> <>9__17_5; // 0x38
			public static Comparison<QGE_RememberTheEmbersObject> <>9__17_6; // 0x40
			public static Comparison<QGE_RememberTheEmbersObject> <>9__17_7; // 0x48
	
			// Constructors
			static <>c(); // 0x0000000181540840-0x00000001815408A0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal int <MStart>b__16_0(QGE_RememberTheEmbersObject a, QGE_RememberTheEmbersObject b); // 0x00000001813B06C0-0x00000001813B0710
			internal int <ShowIntro>b__17_0(QGE_RememberTheEmbersObject b, QGE_RememberTheEmbersObject a); // 0x00000001813B0710-0x00000001813B0760
			internal int <ShowIntro>b__17_1(QGE_RememberTheEmbersObject a, QGE_RememberTheEmbersObject b); // 0x00000001813B0650-0x00000001813B06C0
			internal int <ShowIntro>b__17_2(QGE_RememberTheEmbersObject a, QGE_RememberTheEmbersObject b); // 0x00000001813B0760-0x00000001813B0810
			internal int <ShowIntro>b__17_3(QGE_RememberTheEmbersObject b, QGE_RememberTheEmbersObject a); // 0x00000001813B0810-0x00000001813B08C0
			internal int <ShowIntro>b__17_4(QGE_RememberTheEmbersObject a, QGE_RememberTheEmbersObject b); // 0x00000001813B08C0-0x00000001813B0970
			internal int <ShowIntro>b__17_5(QGE_RememberTheEmbersObject b, QGE_RememberTheEmbersObject a); // 0x00000001813B0970-0x00000001813B0A20
			internal int <ShowIntro>b__17_6(QGE_RememberTheEmbersObject a, QGE_RememberTheEmbersObject b); // 0x00000001813B0A20-0x00000001813B0AD0
			internal int <ShowIntro>b__17_7(QGE_RememberTheEmbersObject b, QGE_RememberTheEmbersObject a); // 0x00000001813B0AD0-0x00000001813B0B80
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowIntro>d__17 : IEnumerator<object> // TypeDefIndex: 16281
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public QGE_RememberTheEmbers <>4__this; // 0x20
			private int <x>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowIntro>d__17(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153D2B0-0x000000018153DD50
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153DD50-0x000000018153DDA0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__19 : IEnumerator<object> // TypeDefIndex: 16282
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public QGE_RememberTheEmbers <>4__this; // 0x20
			private Color <transparentWhite>5__2; // 0x28
			private float <i>5__3; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__19(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018153F510-0x000000018153FC60
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018153FC60-0x000000018153FCB0
		}
	
		// Constructors
		public QGE_RememberTheEmbers(); // 0x0000000181531C20-0x0000000181531C50
	
		// Methods
		public override void MStart(); // 0x0000000181530FF0-0x0000000181531B60
		[IteratorStateMachine] // 0x00000001800B88A0-0x00000001800B88F0
		public override IEnumerator ShowIntro(); // 0x0000000181531B60-0x0000000181531BC0
		public void FoundObject(QGE_RememberTheEmbersObject.EMatchObjectType inMatchObjectType); // 0x0000000181530F30-0x0000000181530FF0
		[IteratorStateMachine] // 0x00000001800B8B80-0x00000001800B8BD0
		public override IEnumerator ShowResults(); // 0x0000000181531BC0-0x0000000181531C20
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x000000018152B740-0x000000018152B7A0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__1(); // 0x0000000181527E70-0x0000000181527ED0
	}
}
