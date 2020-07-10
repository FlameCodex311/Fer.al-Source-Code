/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype.QuickGames
{
	public class BasicQGEController : QuickGamesBase // TypeDefIndex: 16117
	{
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__2 : IEnumerator<object> // TypeDefIndex: 16118
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public BasicQGEController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__2(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001813AEB50-0x00000001813AEBC0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001813AEBC0-0x00000001813AEC10
		}
	
		// Constructors
		public BasicQGEController(); // 0x0000000181395910-0x0000000181395920
	
		// Methods
		public override void MStart(); // 0x0000000181395890-0x00000001813958A0
		public override void QuickGameUpdate(); // 0x000000018036B6C0-0x000000018036B6D0
		[IteratorStateMachine] // 0x0000000180113800-0x0000000180113850
		public override IEnumerator ShowResults(); // 0x00000001813958A0-0x0000000181395900
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181395900-0x0000000181395910
	}
}
