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

namespace World_Challenge.Parlor_Game.Shell_Game
{
	public class ShellGame : ParlorGame // TypeDefIndex: 14698
	{
		// Fields
		[Header] // 0x0000000180281B30-0x0000000180281B60
		public Transform shellStart; // 0x80
		public Transform ballStart; // 0x88
		public ShellGameShell shell; // 0x90
		public Transform ball; // 0x98
		public float dealDelay; // 0xA0
		public float dealSpeed; // 0xA4
		public float xShellSpacing; // 0xA8
		[Header] // 0x0000000180293EF0-0x0000000180293F20
		public float zShuffleOffset; // 0xAC
		public float standardShuffleSpeed; // 0xB0
		public float pauseBetweenShuffles; // 0xB4
		[Header] // 0x0000000180294000-0x0000000180294030
		public bool usePortalsForDealing; // 0xB8
		public float portalShuffleSpeed; // 0xBC
		public float portalSpinSpeed; // 0xC0
		public float portalDepth; // 0xC4
		public Color[] portalColors; // 0xC8
		[Header] // 0x00000001802942A0-0x00000001802942D0
		public float shellShowTime; // 0xD0
		public float shellShowHeight; // 0xD4
		public float shellShowRotate; // 0xD8
		private bool _standardShuffleNext; // 0xDC
		private int _numShellsInPortal; // 0xE0
		private int _shellWithBallIndex; // 0xE4
		private int _clickedShellIndex; // 0xE8
		private Vector3 _shellShowRotate; // 0xEC
		private Vector3 _shellHideRotate; // 0xF8
		private List<ShellGameShell> _shells; // 0x108
		private List<Vector3> _shellLocations; // 0x110
		private List<int> _shellIndexes; // 0x118
		private EShuffleType _shuffleType; // 0x120
	
		// Nested types
		private enum EShuffleType // TypeDefIndex: 14699
		{
			STANDARD = 0,
			PORTAL = 1
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowShell>d__31 : IEnumerator<object> // TypeDefIndex: 14700
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ShellGame <>4__this; // 0x20
			public int inIndex; // 0x28
			public float inShowTime; // 0x2C
			public bool inShow; // 0x30
			public float inDT; // 0x34
			public float inHalfTime; // 0x38
			private Vector3 <downPos>5__2; // 0x3C
			private Vector3 <upPos>5__3; // 0x48
			private Transform <trans>5__4; // 0x58
			private float <t>5__5; // 0x60
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowShell>d__31(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181986A60-0x0000000181986FF0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181986FF0-0x0000000181987040
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Intro_DealAndShuffle>d__32 : IEnumerator<object> // TypeDefIndex: 14701
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ShellGame <>4__this; // 0x20
			private List<int> <colors>5__2; // 0x28
			private float <thirdTime>5__3; // 0x30
			private float <sixthTime>5__4; // 0x34
			private float <dt>5__5; // 0x38
			private Vector3 <ballStartPos>5__6; // 0x3C
			private Vector3 <ballEndPos>5__7; // 0x48
			private int <i>5__8; // 0x54
			private float <t>5__9; // 0x58
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Intro_DealAndShuffle>d__32(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181982CF0-0x00000001819838C0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001819838C0-0x0000000181983910
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <StandardShuffle>d__34 : IEnumerator<object> // TypeDefIndex: 14702
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ShellGame <>4__this; // 0x20
			private Vector3[] <shellsStarts>5__2; // 0x28
			private Vector3[] <shellsEnds>5__3; // 0x30
			private bool <rightGoHigh>5__4; // 0x38
			private float <td>5__5; // 0x3C
			private float <halfWay>5__6; // 0x40
			private float <t>5__7; // 0x44
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <StandardShuffle>d__34(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181987320-0x0000000181988260
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181988260-0x00000001819882B0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Intro_PortalDealShell>d__35 : IEnumerator<object> // TypeDefIndex: 14703
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ShellGame <>4__this; // 0x20
			public int inIndex; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Intro_PortalDealShell>d__35(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181983910-0x0000000181983E80
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181983E80-0x0000000181983ED0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Intro_StandardDealShell>d__36 : IEnumerator<object> // TypeDefIndex: 14704
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ShellGame <>4__this; // 0x20
			public int inIndex; // 0x28
			private Transform <trans>5__2; // 0x30
			private Vector3 <startPos>5__3; // 0x38
			private Vector3 <endPos>5__4; // 0x44
			private float <dt>5__5; // 0x50
			private float <upTime>5__6; // 0x54
			private float <t>5__7; // 0x58
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Intro_StandardDealShell>d__36(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181983ED0-0x00000001819844A0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001819844A0-0x00000001819844F0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Results_PortalReturnShell>d__37 : IEnumerator<object> // TypeDefIndex: 14705
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ShellGame <>4__this; // 0x20
			public int inIndex; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Results_PortalReturnShell>d__37(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181984FE0-0x0000000181985490
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181985490-0x00000001819854E0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Results_StandardReturnShell>d__38 : IEnumerator<object> // TypeDefIndex: 14706
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ShellGame <>4__this; // 0x20
			public int inIndex; // 0x28
			private Transform <trans>5__2; // 0x30
			private Vector3 <startPos>5__3; // 0x38
			private Vector3 <endPos>5__4; // 0x44
			private float <dt>5__5; // 0x50
			private float <downTime>5__6; // 0x54
			private float <t>5__7; // 0x58
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Results_StandardReturnShell>d__38(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181985690-0x0000000181985BE0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181985BE0-0x0000000181985C30
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__40 : IEnumerator<object> // TypeDefIndex: 14707
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ShellGame <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__40(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001819864B0-0x0000000181986730
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181986730-0x0000000181986780
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CleanupAndReset>d__42 : IEnumerator<object> // TypeDefIndex: 14708
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ShellGame <>4__this; // 0x20
			private float <dt>5__2; // 0x28
			private float <thirdTime>5__3; // 0x2C
			private float <sixthTime>5__4; // 0x30
			private Vector3 <ballStartPos>5__5; // 0x34
			private float <t>5__6; // 0x40
			private int <i>5__7; // 0x44
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <CleanupAndReset>d__42(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000181981FA0-0x0000000181982470
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181982470-0x00000001819824C0
		}
	
		// Constructors
		public ShellGame(); // 0x0000000181981310-0x0000000181981470
	
		// Methods
		public override void MStart(); // 0x00000001819806A0-0x0000000181980A30
		internal override void Intro(); // 0x0000000181980620-0x00000001819806A0
		[IteratorStateMachine] // 0x00000001802944A0-0x00000001802944F0
		private IEnumerator ShowShell(int inIndex, bool inShow, float inDT, float inShowTime, float inHalfTime); // 0x00000001819811F0-0x00000001819812A0
		[IteratorStateMachine] // 0x00000001802946C0-0x0000000180294710
		private IEnumerator Intro_DealAndShuffle(); // 0x00000001819804E0-0x0000000181980540
		private void PortalShuffle(bool inPortalsUpOnly, bool inPortalsAllUp); // 0x0000000181980A30-0x0000000181980FB0
		[IteratorStateMachine] // 0x00000001802949B0-0x0000000180294A00
		private IEnumerator StandardShuffle(); // 0x00000001819812A0-0x0000000181981300
		[IteratorStateMachine] // 0x0000000180294F70-0x0000000180294FC0
		private IEnumerator Intro_PortalDealShell(int inIndex); // 0x0000000181980540-0x00000001819805B0
		[IteratorStateMachine] // 0x00000001802950D0-0x0000000180295120
		private IEnumerator Intro_StandardDealShell(int inIndex); // 0x00000001819805B0-0x0000000181980620
		[IteratorStateMachine] // 0x0000000180295360-0x00000001802953B0
		private IEnumerator Results_PortalReturnShell(int inIndex); // 0x0000000181981020-0x0000000181981090
		[IteratorStateMachine] // 0x00000001802956A0-0x00000001802956F0
		private IEnumerator Results_StandardReturnShell(int inIndex); // 0x0000000181981090-0x0000000181981100
		internal void ShellSelected(ShellGameShell inShellClicked); // 0x0000000181981100-0x0000000181981190
		[IteratorStateMachine] // 0x0000000180295BB0-0x0000000180295C00
		public override IEnumerator ShowResults(); // 0x0000000181981190-0x00000001819811F0
		internal override void ResultsDone(); // 0x0000000181980FB0-0x0000000181981020
		[IteratorStateMachine] // 0x0000000180295DB0-0x0000000180295E00
		private IEnumerator CleanupAndReset(); // 0x0000000181980480-0x00000001819804E0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000181981300-0x0000000181981310
	}
}
