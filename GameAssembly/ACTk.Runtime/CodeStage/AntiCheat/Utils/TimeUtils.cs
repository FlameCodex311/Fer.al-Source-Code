/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.Utils
{
	internal class TimeUtils // TypeDefIndex: 7336
	{
		// Fields
		public const long TicksPerSecond = 10000000; // Metadata: 0x00775EED
	
		// Constructors
		public TimeUtils(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public static long GetReliableTicks(); // 0x000000018200AD50-0x000000018200ADC0
		public static long GetEnvironmentTicks(); // 0x000000018200AD10-0x000000018200AD30
		public static long GetRealtimeTicks(); // 0x000000018200AD30-0x000000018200AD50
	}
}
