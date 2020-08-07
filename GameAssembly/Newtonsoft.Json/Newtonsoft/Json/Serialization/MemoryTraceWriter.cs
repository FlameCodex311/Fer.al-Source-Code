/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class MemoryTraceWriter : ITraceWriter // TypeDefIndex: 8057
	{
		// Fields
		private readonly Queue<string> _traceMessages; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TraceLevel <LevelFilter>k__BackingField; // 0x18
	
		// Properties
		public TraceLevel LevelFilter { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803F46B0-0x00000001803F46C0 0x00000001803F46C0-0x00000001803F46D0
	
		// Constructors
		public MemoryTraceWriter(); // 0x0000000180C2C270-0x0000000180C2C2E0
	
		// Methods
		public void Trace(TraceLevel level, string message, Exception ex); // 0x0000000180C2C090-0x0000000180C2C270
		public override string ToString(); // 0x0000000180C2BEF0-0x0000000180C2C090
	}
}
