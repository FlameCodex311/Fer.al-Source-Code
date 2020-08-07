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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace World_Challenge.Parlor_Game.Remember_The_Embers
{
	public class RememberTheEmbers : ParlorGame // TypeDefIndex: 14720
	{
		// Fields
		[Header] // 0x00000001801D8B90-0x00000001801D8BC0
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Intro_ShowAndHide>d__19 : IEnumerator<object> // TypeDefIndex: 14721
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RememberTheEmbers <>4__this; // 0x20
			private float <t>5__2; // 0x28
			private int <i>5__3; // 0x2C
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Intro_ShowAndHide>d__19(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E7CF30-0x0000000180E7D240
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E7D240-0x0000000180E7D290
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Intro_DealCard>d__20 : IEnumerator<object> // TypeDefIndex: 14722
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Intro_DealCard>d__20(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E7C580-0x0000000180E7C9A0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E7C9A0-0x0000000180E7C9F0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 14723
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<RememberTheEmbersCard> <>9__21_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180E83C90-0x0000000180E83CF0
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal int <Intro_DealCards>b__21_0(RememberTheEmbersCard a, RememberTheEmbersCard b); // 0x0000000180E83C50-0x0000000180E83C90
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Intro_DealCards>d__21 : IEnumerator<object> // TypeDefIndex: 14724
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Intro_DealCards>d__21(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E7C9F0-0x0000000180E7CEE0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E7CEE0-0x0000000180E7CF30
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Results_ReturnCard>d__22 : IEnumerator<object> // TypeDefIndex: 14725
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Results_ReturnCard>d__22(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E80830-0x0000000180E80CB0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E80CB0-0x0000000180E80D00
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Results_ReturnCards>d__23 : IEnumerator<object> // TypeDefIndex: 14726
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RememberTheEmbers <>4__this; // 0x20
			private int <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Results_ReturnCards>d__23(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001819854E0-0x0000000181985640
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181985640-0x0000000181985690
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__25 : IEnumerator<object> // TypeDefIndex: 14727
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RememberTheEmbers <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__25(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181986300-0x0000000181986460
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181986460-0x00000001819864B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CleanupResultsCards>d__26 : IEnumerator<object> // TypeDefIndex: 14728
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public RememberTheEmbers <>4__this; // 0x20
			private int <i>5__2; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <CleanupResultsCards>d__26(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180E7A370-0x0000000180E7A630
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180E7A630-0x0000000180E7A680
		}
	
		// Constructors
		public RememberTheEmbers(); // 0x0000000180E725B0-0x0000000180E72660
	
		// Methods
		public override void MStart(); // 0x0000000180E71D00-0x0000000180E723F0
		internal override void Intro(); // 0x0000000180E71C80-0x0000000180E71D00
		[IteratorStateMachine] // 0x00000001801D8DD0-0x00000001801D8E20
		private IEnumerator Intro_ShowAndHide(); // 0x0000000180E71C20-0x0000000180E71C80
		[IteratorStateMachine] // 0x00000001801D9040-0x00000001801D9090
		private IEnumerator Intro_DealCard(int inIndex, Vector3 inEndPos); // 0x0000000180E71B30-0x0000000180E71BC0
		[IteratorStateMachine] // 0x00000001801D91A0-0x00000001801D91F0
		private IEnumerator Intro_DealCards(); // 0x0000000180E71BC0-0x0000000180E71C20
		[IteratorStateMachine] // 0x00000001801D9520-0x00000001801D9570
		private IEnumerator Results_ReturnCard(int inIndex); // 0x0000000180E72460-0x0000000180E724D0
		[IteratorStateMachine] // 0x00000001801D9700-0x00000001801D9750
		private IEnumerator Results_ReturnCards(); // 0x0000000180E724D0-0x0000000180E72540
		internal void FoundObject(RememberTheEmbersCard.EMatchObjectType inMatchObjectType); // 0x0000000180E71A90-0x0000000180E71B30
		[IteratorStateMachine] // 0x00000001801D9A00-0x00000001801D9A50
		public override IEnumerator ShowResults(); // 0x0000000180E72540-0x0000000180E725B0
		[IteratorStateMachine] // 0x00000001801D9B80-0x00000001801D9BD0
		private IEnumerator CleanupResultsCards(); // 0x0000000180E71A30-0x0000000180E71A90
		internal override void ResultsDone(); // 0x0000000180E723F0-0x0000000180E72460
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180E70B50-0x0000000180E70BB0
	}
}
