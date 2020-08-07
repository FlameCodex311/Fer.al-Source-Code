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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames.RememberTheEmbers
{
	public class QGE_RememberTheEmbers : QuickGamesBase // TypeDefIndex: 15021
	{
		// Fields
		[Header] // 0x00000001801D6F60-0x00000001801D6F90
		public GameObject instructions; // 0xF0
		public Texture matchImage1; // 0xF8
		public Texture matchImage2; // 0x100
		public Texture matchImage3; // 0x108
		public Texture ingredientImage; // 0x110
		public Texture emberImage; // 0x118
		public QGE_RememberTheEmbersObject findMatchObject; // 0x120
		public int gridSpotsX; // 0x128
		public int gridSpotsY; // 0x12C
		[Header] // 0x00000001801D1640-0x00000001801D1670
		public float timeForIntro; // 0x130
		[Header] // 0x00000001801D7080-0x00000001801D70B0
		public float resultsFadeTime; // 0x134
		private bool _foundIngredient; // 0x138
		private int _embersFound; // 0x13C
		private int _numberOfObjectsMatched; // 0x140
		private List<QGE_RememberTheEmbersObject> _objectsToMatch; // 0x148
		private QGE_RememberTheEmbersObject.EMatchObjectType _typeToMatch; // 0x150
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15022
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
			static <>c(); // 0x0000000180A61C20-0x0000000180A61C80
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal int <MStart>b__16_0(QGE_RememberTheEmbersObject a, QGE_RememberTheEmbersObject b); // 0x0000000180A616A0-0x0000000180A616F0
			internal int <ShowIntro>b__17_0(QGE_RememberTheEmbersObject b, QGE_RememberTheEmbersObject a); // 0x0000000180A61730-0x0000000180A61780
			internal int <ShowIntro>b__17_1(QGE_RememberTheEmbersObject a, QGE_RememberTheEmbersObject b); // 0x0000000180A61780-0x0000000180A617F0
			internal int <ShowIntro>b__17_2(QGE_RememberTheEmbersObject a, QGE_RememberTheEmbersObject b); // 0x0000000180A617F0-0x0000000180A61890
			internal int <ShowIntro>b__17_3(QGE_RememberTheEmbersObject b, QGE_RememberTheEmbersObject a); // 0x0000000180A61890-0x0000000180A61930
			internal int <ShowIntro>b__17_4(QGE_RememberTheEmbersObject a, QGE_RememberTheEmbersObject b); // 0x0000000180A61930-0x0000000180A619E0
			internal int <ShowIntro>b__17_5(QGE_RememberTheEmbersObject b, QGE_RememberTheEmbersObject a); // 0x0000000180A619E0-0x0000000180A61A80
			internal int <ShowIntro>b__17_6(QGE_RememberTheEmbersObject a, QGE_RememberTheEmbersObject b); // 0x0000000180A61A80-0x0000000180A61B20
			internal int <ShowIntro>b__17_7(QGE_RememberTheEmbersObject b, QGE_RememberTheEmbersObject a); // 0x0000000180A61B20-0x0000000180A61BC0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowIntro>d__17 : IEnumerator<object> // TypeDefIndex: 15023
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public QGE_RememberTheEmbers <>4__this; // 0x20
			private int <x>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowIntro>d__17(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A5E950-0x0000000180A5F3C0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A5F3C0-0x0000000180A5F410
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__19 : IEnumerator<object> // TypeDefIndex: 15024
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public QGE_RememberTheEmbers <>4__this; // 0x20
			private Color <transparentWhite>5__2; // 0x28
			private float <i>5__3; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__19(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A60810-0x0000000180A60F40
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A60F40-0x0000000180A60F90
		}
	
		// Constructors
		public QGE_RememberTheEmbers(); // 0x0000000180A540C0-0x0000000180A540F0
	
		// Methods
		public override void MStart(); // 0x0000000180A534C0-0x0000000180A54000
		[IteratorStateMachine] // 0x0000000180296570-0x00000001802965C0
		public override IEnumerator ShowIntro(); // 0x0000000180A54000-0x0000000180A54060
		public void FoundObject(QGE_RememberTheEmbersObject.EMatchObjectType inMatchObjectType); // 0x0000000180A53400-0x0000000180A534C0
		[IteratorStateMachine] // 0x00000001801CDAE0-0x00000001801CDB30
		public override IEnumerator ShowResults(); // 0x0000000180A54060-0x0000000180A540C0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180A4DD60-0x0000000180A4DDC0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__1(); // 0x0000000180A4A590-0x0000000180A4A5F0
	}
}
