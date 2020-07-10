/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class StopwatchTracking // TypeDefIndex: 13225
{
	// Fields
	private const bool ENABLED = false; // Metadata: 0x007839BE
	private static List<StopwatchEntry> _stopwatchTrackingList; // 0x00
	private static Dictionary<string, Stopwatch> _currentStopwatches; // 0x08

	// Properties
	private static List<StopwatchEntry> StopwatchTrackingList { get; } // 0x000000018135E020-0x000000018135E0B0 
	private static Dictionary<string, Stopwatch> CurrentStopwatches { get; } // 0x000000018135DF90-0x000000018135E020 

	// Nested types
	private class StopwatchEntry // TypeDefIndex: 13226
	{
		// Fields
		public string name; // 0x10
		public long millisecs; // 0x18

		// Constructors
		public StopwatchEntry(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 13227
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<StopwatchEntry, long> <>9__10_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000181360A90-0x0000000181360AF0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal long <WriteStopwatchTrackingToDisk>b__10_0(StopwatchEntry kvp); // 0x0000000180897C80-0x0000000180897CA0
	}

	// Methods
	[Conditional] // 0x00000001800E0B50-0x00000001800E0B80
	public static void StartStopwatch(string inName); // 0x00000001803581E0-0x00000001803581F0
	[Conditional] // 0x00000001800E0B50-0x00000001800E0B80
	public static void FinishStopwatch(string inName); // 0x00000001803581E0-0x00000001803581F0
	[Conditional] // 0x00000001800E0B50-0x00000001800E0B80
	public static void WriteStopwatchTrackingToDisk(bool inSorted = true /* Metadata: 0x007839BD */); // 0x000000018135DF30-0x000000018135DF90
}

