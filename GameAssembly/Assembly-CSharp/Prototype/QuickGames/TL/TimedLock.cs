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

namespace Prototype.QuickGames.TL
{
	public class TimedLock : QuickGamesBase // TypeDefIndex: 15007
	{
		// Fields
		[Header] // 0x000000018028CE40-0x000000018028CE70
		public TimedLock_Lock[] locks; // 0xF0
		public Texture rewardImage; // 0xF8
		public Texture unlockImage; // 0x100
		public float keyholeRotateSpeedMin; // 0x108
		public float keyholeRotateSpeedMax; // 0x10C
		public float winThreshold; // 0x110
		public float keyStartOffsetX; // 0x114
		public float flashTime; // 0x118
		public int flashes; // 0x11C
		[Header] // 0x00000001801D1640-0x00000001801D1670
		public float timeForIntro; // 0x120
		private int _currentLockIndex; // 0x124
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowIntro>d__12 : IEnumerator<object> // TypeDefIndex: 15008
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TimedLock <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowIntro>d__12(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A41650-0x0000000180A41B00
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A41B00-0x0000000180A41B50
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <ShowResults>d__14 : IEnumerator<object> // TypeDefIndex: 15009
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TimedLock <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <ShowResults>d__14(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180A41C70-0x0000000180A41F40
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180A41F40-0x0000000180A41F90
		}
	
		// Constructors
		public TimedLock(); // 0x0000000180A3E250-0x0000000180A3E2A0
	
		// Methods
		public override void MStart(); // 0x0000000180A3DDC0-0x0000000180A3DDD0
		[IteratorStateMachine] // 0x000000018028D220-0x000000018028D270
		public override IEnumerator ShowIntro(); // 0x0000000180A3E190-0x0000000180A3E1F0
		public override void QuickGameUpdate(); // 0x0000000180A3DDD0-0x0000000180A3E190
		[IteratorStateMachine] // 0x000000018028D420-0x000000018028D470
		public override IEnumerator ShowResults(); // 0x0000000180A3E1F0-0x0000000180A3E250
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__0(); // 0x0000000180982AD0-0x0000000180982AE0
		[CompilerGenerated] // 0x00000001801CDDD0-0x00000001801CDE00
		[DebuggerHidden] // 0x00000001801CDDD0-0x00000001801CDE00
		private IEnumerator <>n__1(); // 0x0000000180982AE0-0x0000000180982AF0
	}
}
