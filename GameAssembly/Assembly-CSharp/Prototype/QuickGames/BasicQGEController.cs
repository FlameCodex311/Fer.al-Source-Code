/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype.QuickGames
{
	public class BasicQGEController : QuickGamesBase // TypeDefIndex: 14859
	{
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__2 : IEnumerator<object> // TypeDefIndex: 14860
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public BasicQGEController <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__2(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180AE3B10-0x0000000180AE3B70
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180AE3B70-0x0000000180AE3BC0
		}
	
		// Constructors
		public BasicQGEController(); // 0x0000000180A46040-0x0000000180A46050
	
		// Methods
		public override void MStart(); // 0x0000000180A3DDC0-0x0000000180A3DDD0
		public override void QuickGameUpdate(); // 0x0000000180373240-0x0000000180373250
		[IteratorStateMachine] // 0x00000001802376F0-0x0000000180237740
		public override IEnumerator ShowResults(); // 0x0000000180ACCD60-0x0000000180ACCDC0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180982AE0-0x0000000180982AF0
	}
}
