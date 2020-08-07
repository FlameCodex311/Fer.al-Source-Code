/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Internal
{
	internal sealed class PlayerLoopRunner // TypeDefIndex: 8866
	{
		// Fields
		private const int InitialSize = 16; // Metadata: 0x007780EB
		private readonly object runningAndQueueLock; // 0x10
		private readonly object arrayLock; // 0x18
		private readonly Action<Exception> unhandledExceptionCallback; // 0x20
		private int tail; // 0x28
		private bool running; // 0x2C
		private IPlayerLoopItem[] loopItems; // 0x30
		private MinimumQueue<IPlayerLoopItem> waitQueue; // 0x38
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 8867
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Action<Exception> <>9__8_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180E1E870-0x0000000180E1E8D0
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <.ctor>b__8_0(Exception ex); // 0x0000000180E1E810-0x0000000180E1E870
		}
	
		// Constructors
		public PlayerLoopRunner(); // 0x0000000180E1AD30-0x0000000180E1AEA0
	
		// Methods
		public void AddAction(IPlayerLoopItem item); // 0x0000000180E1A4D0-0x0000000180E1A760
		public void Run(); // 0x0000000180E1A760-0x0000000180E1AD30
	}
}
