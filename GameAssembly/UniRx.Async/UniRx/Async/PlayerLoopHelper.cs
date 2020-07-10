/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async.Internal;
using UnityEngine;
using UnityEngine.Experimental.LowLevel;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async
{
	public static class PlayerLoopHelper // TypeDefIndex: 8414
	{
		// Fields
		private static int mainThreadId; // 0x00
		private static SynchronizationContext unitySynchronizationContetext; // 0x08
		private static ContinuationQueue[] yielders; // 0x10
		private static PlayerLoopRunner[] runners; // 0x18
	
		// Properties
		public static SynchronizationContext UnitySynchronizationContext { get; } // 0x000000018166D910-0x000000018166D950 
		public static int MainThreadId { get; } // 0x000000018166D8D0-0x000000018166D910 
	
		// Methods
		private static PlayerLoopSystem[] InsertRunner(PlayerLoopSystem loopSystem, Type loopRunnerYieldType, ContinuationQueue cq, Type loopRunnerType, PlayerLoopRunner runner); // 0x000000018166D6E0-0x000000018166D8D0
		[RuntimeInitializeOnLoadMethod] // 0x00000001800B6700-0x00000001800B6720
		private static void Init(); // 0x000000018166C640-0x000000018166C700
		public static void Initialize(ref PlayerLoopSystem playerLoop); // 0x000000018166C700-0x000000018166D6E0
		public static void AddAction(PlayerLoopTiming timing, IPlayerLoopItem action); // 0x000000018166C520-0x000000018166C5B0
		public static void AddContinuation(PlayerLoopTiming timing, Action continuation); // 0x000000018166C5B0-0x000000018166C640
	}
}
