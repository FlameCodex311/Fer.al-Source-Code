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
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal sealed class Stopwatch : StopwatchBase // TypeDefIndex: 7075
	{
		// Fields
		private const long YnQgBhHRpyDmnfjnZmvBtWNjuKfO = 10000000; // Metadata: 0x0076697D
		public static readonly Stopwatch Global; // 0x00
		private static long zJJzUrJFxJcslcyYvcHgatFQPpxy; // 0x08
		private System.Diagnostics.Stopwatch FKwdqzuvPRrWeVDIWsADAjGZLcc; // 0x10
		private long FKKmiPTZzEiFnlZpobvjjujKfvY; // 0x18
	
		// Properties
		public static long frequency { get; } // 0x00000001813FC3F0-0x00000001813FC4B0 
		public override double offsetSeconds { get; set; } // 0x00000001813FC4D0-0x00000001813FC550 0x00000001813FC550-0x00000001813FC5D0
		public override long offsetTicks { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public override double elapsedSeconds { get; } // 0x00000001813FC2F0-0x00000001813FC3A0 
		public override double elapsedSecondsRaw { get; } // 0x00000001813FC260-0x00000001813FC2F0 
		public override long elapsedMilliseconds { get; } // 0x00000001813FC1A0-0x00000001813FC260 
		public override long elapsedMillisecondsRaw { get; } // 0x00000001813FC180-0x00000001813FC1A0 
		public override long elapsedTicks { get; } // 0x00000001813FC3C0-0x00000001813FC3F0 
		public override long elapsedTicksRaw { get; } // 0x00000001813FC3A0-0x00000001813FC3C0 
		public override bool isRunning { get; } // 0x00000001813FC4B0-0x00000001813FC4D0 
	
		// Constructors
		static Stopwatch(); // 0x00000001813FBFF0-0x00000001813FC120
		public Stopwatch(); // 0x00000001813FC120-0x00000001813FC180
	
		// Methods
		public static Stopwatch StartNew(); // 0x00000001813FBE00-0x00000001813FBEA0
		public static long ConvertTo100NSTicks(long ticks); // 0x00000001813FBCB0-0x00000001813FBD50
		public override void Stop(); // 0x00000001813FBF20-0x00000001813FBFF0
		public override void Start(); // 0x00000001813FBEA0-0x00000001813FBF20
		public override void Reset(); // 0x00000001813FBD50-0x00000001813FBE00
	}
}
