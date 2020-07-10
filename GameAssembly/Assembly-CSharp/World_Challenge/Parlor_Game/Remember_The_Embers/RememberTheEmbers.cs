/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using World_Challenge.Parlor_Game;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace World_Challenge.Parlor_Game.Remember_The_Embers
{
	public class RememberTheEmbers : ParlorGame // TypeDefIndex: 15565
	{
		// Fields
		[Header] // 0x000000018011D2A0-0x000000018011D2D0
		public Transform deckLocator; // 0x80
		public RememberTheEmbersCard card; // 0x88
		public Texture matchImage1; // 0x90
		public Texture matchImage2; // 0x98
		public Texture matchImage3; // 0xA0
		public Texture emberImage; // 0xA8
		public int gridSpotsX; // 0xB0
		public int gridSpotsZ; // 0xB4
		public float cardSpacing; // 0xB8
		public float dealDelay; // 0xBC
		public float dealSpeed; // 0xC0
		public float flipHeight; // 0xC4
		public float flipTime; // 0xC8
		private int _embersFound; // 0xCC
		private int _numberOfObjectsMatched; // 0xD0
		private List<RememberTheEmbersCard> _cardsToMatch; // 0xD8
		private RememberTheEmbersCard.EMatchObjectType _typeToMatch; // 0xE0
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Intro_ShowAndHide>d__19 : IEnumerator<object> // TypeDefIndex: 15566
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RememberTheEmbers <>4__this; // 0x20
			private float <t>5__2; // 0x28
			private int <i>5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Intro_ShowAndHide>d__19(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181719860-0x0000000181719B90
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181719B90-0x0000000181719BE0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Intro_DealCard>d__20 : IEnumerator<object> // TypeDefIndex: 15567
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RememberTheEmbers <>4__this; // 0x20
			public int inIndex; // 0x28
			public Vector3 inEndPos; // 0x2C
			private Transform <trans>5__2; // 0x38
			private Vector3 <startPos>5__3; // 0x40
			private float <halfTime>5__4; // 0x4C
			private float <t>5__5; // 0x50
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Intro_DealCard>d__20(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181718E90-0x00000001817192C0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001817192C0-0x0000000181719310
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 15568
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<RememberTheEmbersCard> <>9__21_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001817210D0-0x0000000181721130
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal int <Intro_DealCards>b__21_0(RememberTheEmbersCard a, RememberTheEmbersCard b); // 0x0000000181721090-0x00000001817210D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Intro_DealCards>d__21 : IEnumerator<object> // TypeDefIndex: 15569
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RememberTheEmbers <>4__this; // 0x20
			private float <buttonSizeX>5__2; // 0x28
			private float <buttonSizeZ>5__3; // 0x2C
			private Vector2 <gridTopLeft>5__4; // 0x30
			private int <placedIndex>5__5; // 0x38
			private int <i>5__6; // 0x3C
			private int <x>5__7; // 0x40
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Intro_DealCards>d__21(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181719310-0x0000000181719810
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181719810-0x0000000181719860
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Results_ReturnCard>d__22 : IEnumerator<object> // TypeDefIndex: 15570
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RememberTheEmbers <>4__this; // 0x20
			public int inIndex; // 0x28
			private Transform <trans>5__2; // 0x30
			private Vector3 <startPos>5__3; // 0x38
			private Vector3 <endPos>5__4; // 0x44
			private float <halfTime>5__5; // 0x50
			private float <t>5__6; // 0x54
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Results_ReturnCard>d__22(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171D2F0-0x000000018171D780
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171D780-0x000000018171D7D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Results_ReturnCards>d__23 : IEnumerator<object> // TypeDefIndex: 15571
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RememberTheEmbers <>4__this; // 0x20
			private int <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Results_ReturnCards>d__23(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171D7D0-0x000000018171D930
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171D930-0x000000018171D980
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__25 : IEnumerator<object> // TypeDefIndex: 15572
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RememberTheEmbers <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__25(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018171F090-0x000000018171F260
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018171F260-0x000000018171F2B0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CleanupResultsCards>d__26 : IEnumerator<object> // TypeDefIndex: 15573
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RememberTheEmbers <>4__this; // 0x20
			private int <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <CleanupResultsCards>d__26(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001817168A0-0x0000000181716B80
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181716B80-0x0000000181716BD0
		}
	
		// Constructors
		public RememberTheEmbers(); // 0x000000018170DCA0-0x000000018170DD50
	
		// Methods
		public override void MStart(); // 0x000000018170D3E0-0x000000018170DB00
		internal override void Intro(); // 0x000000018170D360-0x000000018170D3E0
		[IteratorStateMachine] // 0x000000018011D370-0x000000018011D3C0
		private IEnumerator Intro_ShowAndHide(); // 0x000000018170D300-0x000000018170D360
		[IteratorStateMachine] // 0x000000018011D5C0-0x000000018011D610
		private IEnumerator Intro_DealCard(int inIndex, Vector3 inEndPos); // 0x000000018170D210-0x000000018170D2A0
		[IteratorStateMachine] // 0x000000018011D750-0x000000018011D7A0
		private IEnumerator Intro_DealCards(); // 0x000000018170D2A0-0x000000018170D300
		[IteratorStateMachine] // 0x000000018011D980-0x000000018011D9D0
		private IEnumerator Results_ReturnCard(int inIndex); // 0x000000018170DB70-0x000000018170DBE0
		[IteratorStateMachine] // 0x000000018011DB60-0x000000018011DBB0
		private IEnumerator Results_ReturnCards(); // 0x000000018170DBE0-0x000000018170DC40
		internal void FoundObject(RememberTheEmbersCard.EMatchObjectType inMatchObjectType); // 0x000000018170D170-0x000000018170D210
		[IteratorStateMachine] // 0x000000018011DE00-0x000000018011DE50
		public override IEnumerator ShowResults(); // 0x000000018170DC40-0x000000018170DCA0
		[IteratorStateMachine] // 0x000000018011E050-0x000000018011E0A0
		private IEnumerator CleanupResultsCards(); // 0x000000018170D110-0x000000018170D170
		internal override void ResultsDone(); // 0x000000018170DB00-0x000000018170DB70
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x000000018170BEC0-0x000000018170BF20
	}
}
