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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class MemoryTraceWriter : ITraceWriter // TypeDefIndex: 7891
	{
		// Fields
		private readonly Queue<string> _traceMessages; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private TraceLevel <LevelFilter>k__BackingField; // 0x18
	
		// Properties
		public TraceLevel LevelFilter { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180367710-0x0000000180367720 0x000000018036B1F0-0x000000018036B200
	
		// Constructors
		public MemoryTraceWriter(); // 0x00000001805940E0-0x0000000180594150
	
		// Methods
		public void Trace(TraceLevel level, string message, Exception ex); // 0x0000000180593F00-0x00000001805940E0
		public override string ToString(); // 0x0000000180593D50-0x0000000180593F00
	}
}
