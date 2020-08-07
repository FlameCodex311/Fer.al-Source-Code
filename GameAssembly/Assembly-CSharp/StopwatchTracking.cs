/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class StopwatchTracking // TypeDefIndex: 10891
{
	// Fields
	private const bool ENABLED = false; // Metadata: 0x0077C479
	private static List<StopwatchEntry> _stopwatchTrackingList; // 0x00
	private static Dictionary<string, Stopwatch> _currentStopwatches; // 0x08

	// Properties
	private static List<StopwatchEntry> StopwatchTrackingList { get; } // 0x0000000180CB8FB0-0x0000000180CB9040 
	private static Dictionary<string, Stopwatch> CurrentStopwatches { get; } // 0x0000000180CB8F20-0x0000000180CB8FB0 

	// Nested types
	private class StopwatchEntry // TypeDefIndex: 10892
	{
		// Fields
		public string name; // 0x10
		public long millisecs; // 0x18

		// Constructors
		public StopwatchEntry(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10893
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<StopwatchEntry, long> <>9__10_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180CBE1D0-0x0000000180CBE230
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal long <WriteStopwatchTrackingToDisk>b__10_0(StopwatchEntry kvp); // 0x000000018038CAA0-0x000000018038CAC0
	}

	// Methods
	[Conditional] // 0x00000001801E3BC0-0x00000001801E3BF0
	public static void StartStopwatch(string inName); // 0x00000001803774A0-0x00000001803774B0
	[Conditional] // 0x00000001801E3BC0-0x00000001801E3BF0
	public static void FinishStopwatch(string inName); // 0x00000001803774A0-0x00000001803774B0
	[Conditional] // 0x00000001801E3BC0-0x00000001801E3BF0
	public static void WriteStopwatchTrackingToDisk(bool inSorted = true /* Metadata: 0x0077C478 */); // 0x0000000180CB8EC0-0x0000000180CB8F20
}

