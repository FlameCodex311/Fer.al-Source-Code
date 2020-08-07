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
	internal abstract class StopwatchBase // TypeDefIndex: 7074
	{
		// Properties
		public abstract double offsetSeconds { get; set; }
		public abstract long offsetTicks { get; set; }
		public abstract double elapsedSeconds { get; }
		public abstract double elapsedSecondsRaw { get; }
		public abstract long elapsedMilliseconds { get; }
		public abstract long elapsedMillisecondsRaw { get; }
		public abstract long elapsedTicks { get; }
		public abstract long elapsedTicksRaw { get; }
		public abstract bool isRunning { get; }
	
		// Constructors
		protected StopwatchBase(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public abstract void Stop();
		public abstract void Start();
		public abstract void Reset();
	}
}
