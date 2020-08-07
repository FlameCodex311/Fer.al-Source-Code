/*
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
	public class ErrorContext // TypeDefIndex: 8082
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <Traced>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Exception <Error>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private object <OriginalObject>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private object <Member>k__BackingField; // 0x28
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string <Path>k__BackingField; // 0x30
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <Handled>k__BackingField; // 0x38
	
		// Properties
		internal bool Traced { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803FD450-0x00000001803FD460 0x00000001803FD630-0x00000001803FD640
		public Exception Error { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		private object OriginalObject { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803F70C0-0x00000001803F70D0
		private object Member { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803FA0C0-0x00000001803FA0D0
		private string Path { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803FA0A0-0x00000001803FA0B0
		public bool Handled { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180379B20-0x0000000180379B30 
	
		// Constructors
		internal ErrorContext(object originalObject, object member, string path, Exception error); // 0x0000000180E8B820-0x0000000180E8B880
	}
}
