/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal sealed class UnityStopwatch : StopwatchBase // TypeDefIndex: 7076
	{
		// Fields
		private const long YnQgBhHRpyDmnfjnZmvBtWNjuKfO = 10000000; // Metadata: 0x00766985
		private static UnityStopwatch PDmDuWDrtvQltiZYnNvLHWSwCgZ; // 0x00
		private readonly QctczeYYmbrYeRdeeIZvUVoyxed FKwdqzuvPRrWeVDIWsADAjGZLcc; // 0x10
		private readonly bool MdtyGyMexgxbFhNEbQpEWNAIMEm; // 0x18
		private double bJzTEnglxAwystzTAnUItTkBopD; // 0x20
	
		// Properties
		public static UnityStopwatch Global { get; } // 0x00000001813FFFB0-0x0000000181400020 
		public static long frequency { get; } // 0x00000001814001F0-0x0000000181400200 
		public override double offsetSeconds { get; set; } // 0x0000000181400220-0x0000000181400230 0x0000000181400310-0x0000000181400320
		public override long offsetTicks { get; set; } // 0x0000000181400230-0x0000000181400250 0x0000000181400320-0x0000000181400340
		public override double elapsedSeconds { get; } // 0x0000000181400120-0x0000000181400190 
		public override double elapsedSecondsRaw { get; } // 0x00000001814000E0-0x0000000181400120 
		public override long elapsedMilliseconds { get; } // 0x0000000181400080-0x00000001814000E0 
		public override long elapsedMillisecondsRaw { get; } // 0x0000000181400020-0x0000000181400080 
		public override long elapsedTicks { get; } // 0x00000001814001C0-0x00000001814001F0 
		public override long elapsedTicksRaw { get; } // 0x0000000181400190-0x00000001814001C0 
		public override bool isRunning { get; } // 0x0000000181400200-0x0000000181400220 
	
		// Nested types
		private class QctczeYYmbrYeRdeeIZvUVoyxed // TypeDefIndex: 7077
		{
			// Fields
			public const long JkXXyGocETbiJeiYpxlDcVdiOHvx = 10000000; // Metadata: 0x0076698D
			private float fBPSYjoOQnIVHkNNkfQPuTifrul; // 0x10
			private bool kjtzKmhFdsTjZhJRubaabYqJdEE; // 0x14
			private float hiNQNqdOtHYBhVZibpwRUsJJyGU; // 0x18
			private double qFgFdLDjBGNxrjSPDGaMUcYOGBp; // 0x20
	
			// Properties
			public bool wSDkGfsBipsaIaHdtiMbCPyRCp { get; } // 0x00000001809A8910-0x00000001809A8920 
			public double MtRTRerSHfUMjdBtvHvldPzInJl { get; } // 0x00000001813F9470-0x00000001813F94A0 
	
			// Constructors
			public QctczeYYmbrYeRdeeIZvUVoyxed(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			public void MrPMknIMZzaXDjcXZFUzCeTcWDAs(); // 0x00000001813F93D0-0x00000001813F93F0
			public void JHzUZUsFQTvSmWjmIewXSnYsiSq(); // 0x00000001813F9390-0x00000001813F93D0
			public void AGASRXthoscAbPvuERLUlyaRAws(); // 0x00000001813F9360-0x00000001813F9390
			public void SmPrdLxmfnoOLIRlFAKVSpooigo(); // 0x00000001813F93F0-0x00000001813F9470
		}
	
		// Constructors
		public UnityStopwatch(); // 0x00000001813FFFA0-0x00000001813FFFB0
		private UnityStopwatch(bool isGlobal); // 0x00000001813FFEA0-0x00000001813FFFA0
	
		// Methods
		public static UnityStopwatch StartNew(); // 0x00000001813FFD30-0x00000001813FFDA0
		public static long ConvertTo100NSTicks(long ticks); // 0x0000000180411160-0x0000000180411170
		~UnityStopwatch(); // 0x00000001813FFBB0-0x00000001813FFC40
		public override void Stop(); // 0x00000001813FFE00-0x00000001813FFEA0
		public override void Start(); // 0x00000001813FFDA0-0x00000001813FFE00
		public override void Reset(); // 0x00000001813FFC40-0x00000001813FFD30
		private void wXhePAGrbpJThFnQCKdbzGCiBiIi(); // 0x0000000181400340-0x00000001814003D0
		private void iZUzMPCBHqbjYCCaVRJifidXZbQs(); // 0x0000000181400250-0x00000001814002E0
		private void kEjGWRDBbQIibaQyqmAVnMEsGYGe(UpdateLoopType param_0000f62a); // 0x00000001814002E0-0x0000000181400310
	}
}
