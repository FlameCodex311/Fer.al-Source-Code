/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;

// Image 69: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8542-8905

namespace UniRx.Async.Internal
{
	public static class TaskTracker // TypeDefIndex: 8875
	{
		// Fields
		[TupleElementNames] // 0x00000001801D6030-0x00000001801D60C0
		private static List<KeyValuePair<IAwaiter, ValueTuple<int, DateTime, string>>> listPool; // 0x00
		[TupleElementNames] // 0x00000001801D6450-0x00000001801D64E0
		private static readonly WeakDictionary<IAwaiter, ValueTuple<int, DateTime, string>> tracking; // 0x08
		private static bool dirty; // 0x10
	
		// Constructors
		static TaskTracker(); // 0x0000000180E1C4D0-0x0000000180E1C6C0
	
		// Methods
		[Conditional] // 0x00000001801D54F0-0x00000001801D5520
		public static void TrackActiveTask(IAwaiter task, int skipFrame = 1 /* Metadata: 0x007780EF */); // 0x00000001803774A0-0x00000001803774B0
		[Conditional] // 0x00000001801D54F0-0x00000001801D5520
		public static void TrackActiveTask(IAwaiter task, string stackTrace); // 0x00000001803774A0-0x00000001803774B0
		public static string CaptureStackTrace(int skipFrame); // 0x000000018037DDC0-0x000000018037DDD0
		[Conditional] // 0x00000001801D54F0-0x00000001801D5520
		public static void RemoveTracking(IAwaiter task); // 0x00000001803774A0-0x00000001803774B0
		public static bool CheckAndResetDirty(); // 0x0000000180E1BF20-0x0000000180E1BF80
		public static void ForEachActiveTask(Action<int, string, AwaiterStatus, DateTime, string> action); // 0x0000000180E1BF80-0x0000000180E1C4D0
	}
}
