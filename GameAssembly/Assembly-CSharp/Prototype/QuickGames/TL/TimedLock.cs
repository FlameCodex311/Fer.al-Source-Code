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

namespace Prototype.QuickGames.TL
{
	public class TimedLock : QuickGamesBase // TypeDefIndex: 16265
	{
		// Fields
		[Header] // 0x000000018016F3D0-0x000000018016F400
		public TimedLock_Lock[] locks; // 0xF0
		public Texture rewardImage; // 0xF8
		public Texture unlockImage; // 0x100
		public float keyholeRotateSpeedMin; // 0x108
		public float keyholeRotateSpeedMax; // 0x10C
		public float winThreshold; // 0x110
		public float keyStartOffsetX; // 0x114
		public float flashTime; // 0x118
		public int flashes; // 0x11C
		[Header] // 0x00000001800B57D0-0x00000001800B5800
		public float timeForIntro; // 0x120
		private int _currentLockIndex; // 0x124
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowIntro>d__12 : IEnumerator<object> // TypeDefIndex: 16266
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TimedLock <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowIntro>d__12(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181604D00-0x00000001816051D0
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001816051D0-0x0000000181605220
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <ShowResults>d__14 : IEnumerator<object> // TypeDefIndex: 16267
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TimedLock <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <ShowResults>d__14(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000181605220-0x0000000181605510
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000181605510-0x0000000181605560
		}
	
		// Constructors
		public TimedLock(); // 0x00000001816015C0-0x0000000181601610
	
		// Methods
		public override void MStart(); // 0x0000000181395890-0x00000001813958A0
		[IteratorStateMachine] // 0x000000018016F9B0-0x000000018016FA00
		public override IEnumerator ShowIntro(); // 0x0000000181601500-0x0000000181601560
		public override void QuickGameUpdate(); // 0x0000000181601120-0x0000000181601500
		[IteratorStateMachine] // 0x000000018016FC10-0x000000018016FC60
		public override IEnumerator ShowResults(); // 0x0000000181601560-0x00000001816015C0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__0(); // 0x0000000181396DA0-0x0000000181396DB0
		[CompilerGenerated] // 0x00000001800B4050-0x00000001800B4080
		[DebuggerHidden] // 0x00000001800B4050-0x00000001800B4080
		private IEnumerator <>n__1(); // 0x0000000181395900-0x0000000181395910
	}
}
