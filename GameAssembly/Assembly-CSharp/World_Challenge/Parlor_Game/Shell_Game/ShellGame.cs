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

namespace World_Challenge.Parlor_Game.Shell_Game
{
	public class ShellGame : ParlorGame // TypeDefIndex: 15543
	{
		// Fields
		[Header] // 0x000000018010CE10-0x000000018010CE40
		public Transform shellStart; // 0x80
		public Transform ballStart; // 0x88
		public ShellGameShell shell; // 0x90
		public Transform ball; // 0x98
		public float dealDelay; // 0xA0
		public float dealSpeed; // 0xA4
		public float xShellSpacing; // 0xA8
		[Header] // 0x000000018010CF60-0x000000018010CF90
		public float zShuffleOffset; // 0xAC
		public float standardShuffleSpeed; // 0xB0
		public float pauseBetweenShuffles; // 0xB4
		[Header] // 0x000000018010D0C0-0x000000018010D0F0
		public bool usePortalsForDealing; // 0xB8
		public float portalShuffleSpeed; // 0xBC
		public float portalSpinSpeed; // 0xC0
		public float portalDepth; // 0xC4
		public Color[] portalColors; // 0xC8
		[Header] // 0x000000018010D220-0x000000018010D250
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
		private enum EShuffleType // TypeDefIndex: 15544
		{
			STANDARD = 0,
			PORTAL = 1
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowShell>d__31 : IEnumerator<object> // TypeDefIndex: 15545
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowShell>d__31(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181F39680-0x0000000181F39C30
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181F39C30-0x0000000181F39C80
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Intro_DealAndShuffle>d__32 : IEnumerator<object> // TypeDefIndex: 15546
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Intro_DealAndShuffle>d__32(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181F36090-0x0000000181F36CA0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181F36CA0-0x0000000181F36CF0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <StandardShuffle>d__34 : IEnumerator<object> // TypeDefIndex: 15547
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <StandardShuffle>d__34(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181F39F70-0x0000000181F3AF40
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181F3AF40-0x0000000181F3AF90
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Intro_PortalDealShell>d__35 : IEnumerator<object> // TypeDefIndex: 15548
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ShellGame <>4__this; // 0x20
			public int inIndex; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Intro_PortalDealShell>d__35(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181F36CF0-0x0000000181F37290
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181F37290-0x0000000181F372E0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Intro_StandardDealShell>d__36 : IEnumerator<object> // TypeDefIndex: 15549
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Intro_StandardDealShell>d__36(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181F372E0-0x0000000181F378D0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181F378D0-0x0000000181F37920
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Results_PortalReturnShell>d__37 : IEnumerator<object> // TypeDefIndex: 15550
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ShellGame <>4__this; // 0x20
			public int inIndex; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Results_PortalReturnShell>d__37(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181F383B0-0x0000000181F38890
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181F38890-0x0000000181F388E0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Results_StandardReturnShell>d__38 : IEnumerator<object> // TypeDefIndex: 15551
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Results_StandardReturnShell>d__38(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181F388E0-0x0000000181F38E50
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181F38E50-0x0000000181F38EA0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__40 : IEnumerator<object> // TypeDefIndex: 15552
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public ShellGame <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__40(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181F390C0-0x0000000181F39350
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181F39350-0x0000000181F393A0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CleanupAndReset>d__42 : IEnumerator<object> // TypeDefIndex: 15553
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <CleanupAndReset>d__42(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181F35730-0x0000000181F35C20
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181F35C20-0x0000000181F35C70
		}
	
		// Constructors
		public ShellGame(); // 0x0000000181F34A60-0x0000000181F34BC0
	
		// Methods
		public override void MStart(); // 0x0000000181F33DC0-0x0000000181F34160
		internal override void Intro(); // 0x0000000181F33D40-0x0000000181F33DC0
		[IteratorStateMachine] // 0x000000018010D3E0-0x000000018010D430
		private IEnumerator ShowShell(int inIndex, bool inShow, float inDT, float inShowTime, float inHalfTime); // 0x0000000181F34940-0x0000000181F349F0
		[IteratorStateMachine] // 0x000000018010D800-0x000000018010D850
		private IEnumerator Intro_DealAndShuffle(); // 0x0000000181F33C00-0x0000000181F33C60
		private void PortalShuffle(bool inPortalsUpOnly, bool inPortalsAllUp); // 0x0000000181F34160-0x0000000181F34700
		[IteratorStateMachine] // 0x000000018010DAD0-0x000000018010DB20
		private IEnumerator StandardShuffle(); // 0x0000000181F349F0-0x0000000181F34A50
		[IteratorStateMachine] // 0x000000018010DEC0-0x000000018010DF10
		private IEnumerator Intro_PortalDealShell(int inIndex); // 0x0000000181F33C60-0x0000000181F33CD0
		[IteratorStateMachine] // 0x000000018010E100-0x000000018010E150
		private IEnumerator Intro_StandardDealShell(int inIndex); // 0x0000000181F33CD0-0x0000000181F33D40
		[IteratorStateMachine] // 0x000000018010E300-0x000000018010E350
		private IEnumerator Results_PortalReturnShell(int inIndex); // 0x0000000181F34770-0x0000000181F347E0
		[IteratorStateMachine] // 0x000000018010E680-0x000000018010E6D0
		private IEnumerator Results_StandardReturnShell(int inIndex); // 0x0000000181F347E0-0x0000000181F34850
		internal void ShellSelected(ShellGameShell inShellClicked); // 0x0000000181F34850-0x0000000181F348E0
		[IteratorStateMachine] // 0x000000018010E950-0x000000018010E9A0
		public override IEnumerator ShowResults(); // 0x0000000181F348E0-0x0000000181F34940
		internal override void ResultsDone(); // 0x0000000181F34700-0x0000000181F34770
		[IteratorStateMachine] // 0x000000018010EB90-0x000000018010EBE0
		private IEnumerator CleanupAndReset(); // 0x0000000181F33BA0-0x0000000181F33C00
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181F34A50-0x0000000181F34A60
	}
}
