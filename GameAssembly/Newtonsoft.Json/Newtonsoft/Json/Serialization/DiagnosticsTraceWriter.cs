/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class DiagnosticsTraceWriter : ITraceWriter // TypeDefIndex: 7887
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private TraceLevel <LevelFilter>k__BackingField; // 0x10
	
		// Properties
		public TraceLevel LevelFilter { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018036CFF0-0x000000018036D000 
	
		// Constructors
		public DiagnosticsTraceWriter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		private TraceEventType GetTraceEventType(TraceLevel level); // 0x00000001804E08C0-0x00000001804E0960
		public void Trace(TraceLevel level, string message, Exception ex); // 0x00000001804E0960-0x00000001804E0CF0
	}
}
