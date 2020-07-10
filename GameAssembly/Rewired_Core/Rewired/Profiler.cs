/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[CustomClassObfuscation] // 0x0000000180137F10-0x0000000180137F60
	[CustomObfuscation] // 0x0000000180137F10-0x0000000180137F60
	internal static class Profiler // TypeDefIndex: 5783
	{
		// Fields
		private const string dZDghludsKNFVhhyDxwLRtVVENd = "USE_PROFILER must be set in Rewired Core to use the profiler."; // Metadata: 0x0072EBA7
	
		// Properties
		public static bool enableBinaryLog { get; set; } // 0x000000018050EB90-0x000000018050EBD0 0x000000018050EB10-0x000000018050EB50
		public static bool enabled { get; set; } // 0x000000018050EB90-0x000000018050EBD0 0x000000018050EB10-0x000000018050EB50
		public static string logFile { get; set; } // 0x000000018050EBD0-0x000000018050EC30 0x000000018050EB10-0x000000018050EB50
		public static bool supported { get; } // 0x000000018050EB90-0x000000018050EBD0 
		public static uint usedHeapSize { get; } // 0x000000018050EB50-0x000000018050EB90 
		public static long usedHeapSizeLong { get; } // 0x000000018050EB50-0x000000018050EB90 
	
		// Methods
		private static void fYQpZsjADBzJFmMzTCGrWtbjPzd(); // 0x000000018050EB10-0x000000018050EB50
		[Conditional] // 0x0000000180138030-0x0000000180138060
		public static void AddFramesFromFile(string file); // 0x000000018050EB10-0x000000018050EB50
		[Conditional] // 0x0000000180138030-0x0000000180138060
		public static void BeginSample(string name); // 0x000000018050EB10-0x000000018050EB50
		[Conditional] // 0x0000000180138030-0x0000000180138060
		public static void BeginSample(string name, UnityEngine.Object targetObject); // 0x000000018050EB10-0x000000018050EB50
		[Conditional] // 0x0000000180138030-0x0000000180138060
		public static void EndSample(); // 0x000000018050EB10-0x000000018050EB50
		public static uint GetMonoHeapSize(); // 0x000000018050EB50-0x000000018050EB90
		public static long GetMonoHeapSizeLong(); // 0x000000018035FCC0-0x000000018035FCD0
		public static uint GetMonoUsedSize(); // 0x000000018050EB50-0x000000018050EB90
		public static long GetMonoUsedSizeLong(); // 0x000000018035FCC0-0x000000018035FCD0
		public static int GetRuntimeMemorySize(UnityEngine.Object o); // 0x000000018050EB50-0x000000018050EB90
		public static long GetRuntimeMemorySizeLong(UnityEngine.Object o); // 0x000000018035FCC0-0x000000018035FCD0
		public static uint GetTotalAllocatedMemory(); // 0x000000018050EB50-0x000000018050EB90
		public static long GetTotalAllocatedMemoryLong(); // 0x000000018035FCC0-0x000000018035FCD0
		public static uint GetTotalReservedMemory(); // 0x000000018035FCC0-0x000000018035FCD0
		public static long GetTotalReservedMemoryLong(); // 0x000000018035FCC0-0x000000018035FCD0
		public static uint GetTotalUnusedReservedMemory(); // 0x000000018035FCC0-0x000000018035FCD0
		public static long GetTotalUnusedReservedMemoryLong(); // 0x000000018035FCC0-0x000000018035FCD0
	}
}
