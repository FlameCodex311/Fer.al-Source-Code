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
	public class ErrorContext // TypeDefIndex: 7916
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <Traced>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Exception <Error>k__BackingField; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private object <OriginalObject>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private object <Member>k__BackingField; // 0x28
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private string <Path>k__BackingField; // 0x30
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <Handled>k__BackingField; // 0x38
	
		// Properties
		internal bool Traced { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180375540-0x0000000180375550 0x00000001803930B0-0x00000001803930C0
		public Exception Error { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		private object OriginalObject { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018036AC90-0x000000018036ACA0
		private object Member { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180422D30-0x0000000180422D40
		private string Path { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803A2800-0x00000001803A2810
		public bool Handled { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001804AEAD0-0x00000001804AEAE0 
	
		// Constructors
		internal ErrorContext(object originalObject, object member, string path, Exception error); // 0x00000001804E1070-0x00000001804E10D0
	}
}
