﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class DiagnosticsTraceWriter : ITraceWriter // TypeDefIndex: 8053
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TraceLevel <LevelFilter>k__BackingField; // 0x10
	
		// Properties
		public TraceLevel LevelFilter { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180387590-0x0000000180387930 
	
		// Constructors
		public DiagnosticsTraceWriter(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		private TraceEventType GetTraceEventType(TraceLevel level); // 0x0000000180E8B090-0x0000000180E8B130
		public void Trace(TraceLevel level, string message, Exception ex); // 0x0000000180E8B130-0x0000000180E8B4B0
	}
}
