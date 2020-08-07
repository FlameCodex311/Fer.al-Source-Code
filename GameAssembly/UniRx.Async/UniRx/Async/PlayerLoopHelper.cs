/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UniRx.Async.Internal;
using UnityEngine;
using UnityEngine.LowLevel;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async
{
	public static class PlayerLoopHelper // TypeDefIndex: 8580
	{
		// Fields
		private static int mainThreadId; // 0x00
		private static SynchronizationContext unitySynchronizationContetext; // 0x08
		private static ContinuationQueue[] yielders; // 0x10
		private static PlayerLoopRunner[] runners; // 0x18
	
		// Properties
		public static SynchronizationContext UnitySynchronizationContext { get; } // 0x0000000180E1A3E0-0x0000000180E1A420 
		public static int MainThreadId { get; } // 0x0000000180E1A3A0-0x0000000180E1A3E0 
	
		// Methods
		private static PlayerLoopSystem[] InsertRunner(PlayerLoopSystem loopSystem, Type loopRunnerYieldType, ContinuationQueue cq, Type loopRunnerType, PlayerLoopRunner runner); // 0x0000000180E1A1C0-0x0000000180E1A3A0
		[RuntimeInitializeOnLoadMethod] // 0x00000001801E4110-0x00000001801E4130
		private static void Init(); // 0x0000000180E191B0-0x0000000180E19270
		public static void Initialize(ref PlayerLoopSystem playerLoop); // 0x0000000180E19270-0x0000000180E1A1C0
		public static void AddAction(PlayerLoopTiming timing, IPlayerLoopItem action); // 0x0000000180E19090-0x0000000180E19120
		public static void AddContinuation(PlayerLoopTiming timing, Action continuation); // 0x0000000180E19120-0x0000000180E191B0
	}
}
