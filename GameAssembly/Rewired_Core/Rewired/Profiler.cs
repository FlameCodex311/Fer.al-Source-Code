/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001801D51A0-0x00000001801D51F0
	[CustomObfuscation] // 0x00000001801D51A0-0x00000001801D51F0
	internal static class Profiler // TypeDefIndex: 5942
	{
		// Fields
		private const string dZDghludsKNFVhhyDxwLRtVVENd = "USE_PROFILER must be set in Rewired Core to use the profiler."; // Metadata: 0x00763844
	
		// Properties
		public static bool enableBinaryLog { get; set; } // 0x0000000180B36D90-0x0000000180B36DD0 0x0000000180B36D10-0x0000000180B36D50
		public static bool enabled { get; set; } // 0x0000000180B36D90-0x0000000180B36DD0 0x0000000180B36D10-0x0000000180B36D50
		public static string logFile { get; set; } // 0x0000000180B36DD0-0x0000000180B36E30 0x0000000180B36D10-0x0000000180B36D50
		public static bool supported { get; } // 0x0000000180B36D90-0x0000000180B36DD0 
		public static uint usedHeapSize { get; } // 0x0000000180B36D50-0x0000000180B36D90 
		public static long usedHeapSizeLong { get; } // 0x0000000180B36D50-0x0000000180B36D90 
	
		// Methods
		private static void fYQpZsjADBzJFmMzTCGrWtbjPzd(); // 0x0000000180B36D10-0x0000000180B36D50
		[Conditional] // 0x00000001801D52C0-0x00000001801D52F0
		public static void AddFramesFromFile(string file); // 0x0000000180B36D10-0x0000000180B36D50
		[Conditional] // 0x00000001801D52C0-0x00000001801D52F0
		public static void BeginSample(string name); // 0x0000000180B36D10-0x0000000180B36D50
		[Conditional] // 0x00000001801D52C0-0x00000001801D52F0
		public static void BeginSample(string name, UnityEngine.Object targetObject); // 0x0000000180B36D10-0x0000000180B36D50
		[Conditional] // 0x00000001801D52C0-0x00000001801D52F0
		public static void EndSample(); // 0x0000000180B36D10-0x0000000180B36D50
		public static uint GetMonoHeapSize(); // 0x0000000180B36D50-0x0000000180B36D90
		public static long GetMonoHeapSizeLong(); // 0x000000018037DDC0-0x000000018037DDD0
		public static uint GetMonoUsedSize(); // 0x0000000180B36D50-0x0000000180B36D90
		public static long GetMonoUsedSizeLong(); // 0x000000018037DDC0-0x000000018037DDD0
		public static int GetRuntimeMemorySize(UnityEngine.Object o); // 0x0000000180B36D50-0x0000000180B36D90
		public static long GetRuntimeMemorySizeLong(UnityEngine.Object o); // 0x000000018037DDC0-0x000000018037DDD0
		public static uint GetTotalAllocatedMemory(); // 0x0000000180B36D50-0x0000000180B36D90
		public static long GetTotalAllocatedMemoryLong(); // 0x000000018037DDC0-0x000000018037DDD0
		public static uint GetTotalReservedMemory(); // 0x000000018037DDC0-0x000000018037DDD0
		public static long GetTotalReservedMemoryLong(); // 0x000000018037DDC0-0x000000018037DDD0
		public static uint GetTotalUnusedReservedMemory(); // 0x000000018037DDC0-0x000000018037DDD0
		public static long GetTotalUnusedReservedMemoryLong(); // 0x000000018037DDC0-0x000000018037DDD0
	}
}
