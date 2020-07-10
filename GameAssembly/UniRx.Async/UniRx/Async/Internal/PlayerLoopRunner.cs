/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Internal
{
	internal sealed class PlayerLoopRunner // TypeDefIndex: 8700
	{
		// Fields
		private const int InitialSize = 16; // Metadata: 0x007433FD
		private readonly object runningAndQueueLock; // 0x10
		private readonly object arrayLock; // 0x18
		private readonly Action<Exception> unhandledExceptionCallback; // 0x20
		private int tail; // 0x28
		private bool running; // 0x2C
		private IPlayerLoopItem[] loopItems; // 0x30
		private MinimumQueue<IPlayerLoopItem> waitQueue; // 0x38
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 8701
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Action<Exception> <>9__8_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000181671EA0-0x0000000181671F00
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <.ctor>b__8_0(Exception ex); // 0x0000000181671E40-0x0000000181671EA0
		}
	
		// Constructors
		public PlayerLoopRunner(); // 0x000000018166E2A0-0x000000018166E410
	
		// Methods
		public void AddAction(IPlayerLoopItem item); // 0x000000018166D9F0-0x000000018166DC90
		public void Run(); // 0x000000018166DC90-0x000000018166E2A0
	}
}
