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
	public class ErrorEventArgs : EventArgs // TypeDefIndex: 7900
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private object <CurrentObject>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private ErrorContext <ErrorContext>k__BackingField; // 0x18
	
		// Properties
		private object CurrentObject { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018036B1E0-0x000000018036B1F0
		private ErrorContext ErrorContext { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018038B160-0x000000018038B170
	
		// Constructors
		public ErrorEventArgs(object currentObject, ErrorContext errorContext); // 0x00000001804E10D0-0x00000001804E1150
	}
}
