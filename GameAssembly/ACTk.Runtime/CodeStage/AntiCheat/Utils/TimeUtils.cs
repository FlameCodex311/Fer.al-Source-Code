/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.Utils
{
	internal class TimeUtils // TypeDefIndex: 7170
	{
		// Fields
		public const long TicksPerSecond = 10000000; // Metadata: 0x007411FF
	
		// Constructors
		public TimeUtils(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public static long GetReliableTicks(); // 0x000000018229F810-0x000000018229F880
		public static long GetEnvironmentTicks(); // 0x000000018229F7D0-0x000000018229F7F0
		public static long GetRealtimeTicks(); // 0x000000018229F7F0-0x000000018229F810
	}
}
