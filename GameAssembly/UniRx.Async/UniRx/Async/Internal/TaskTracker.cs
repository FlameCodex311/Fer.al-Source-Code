/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;

// Image 68: UniRx.Async.dll - Assembly: UniRx.Async, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8376-8739

namespace UniRx.Async.Internal
{
	public static class TaskTracker // TypeDefIndex: 8709
	{
		// Fields
		[TupleElementNames] // 0x000000018013A200-0x000000018013A290
		private static List<KeyValuePair<IAwaiter, ValueTuple<int, DateTime, string>>> listPool; // 0x00
		[TupleElementNames] // 0x000000018013A580-0x000000018013A610
		private static readonly WeakDictionary<IAwaiter, ValueTuple<int, DateTime, string>> tracking; // 0x08
		private static bool dirty; // 0x10
	
		// Constructors
		static TaskTracker(); // 0x000000018166FA80-0x000000018166FC70
	
		// Methods
		[Conditional] // 0x00000001800C0AC0-0x00000001800C0AF0
		public static void TrackActiveTask(IAwaiter task, int skipFrame = 1 /* Metadata: 0x00743401 */); // 0x00000001803581E0-0x00000001803581F0
		[Conditional] // 0x00000001800C0AC0-0x00000001800C0AF0
		public static void TrackActiveTask(IAwaiter task, string stackTrace); // 0x00000001803581E0-0x00000001803581F0
		public static string CaptureStackTrace(int skipFrame); // 0x000000018035FCC0-0x000000018035FCD0
		[Conditional] // 0x00000001800C0AC0-0x00000001800C0AF0
		public static void RemoveTracking(IAwaiter task); // 0x00000001803581E0-0x00000001803581F0
		public static bool CheckAndResetDirty(); // 0x000000018166F4C0-0x000000018166F520
		public static void ForEachActiveTask(Action<int, string, AwaiterStatus, DateTime, string> action); // 0x000000018166F520-0x000000018166FA80
	}
}
