/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal struct JsonPosition // TypeDefIndex: 7787
	{
		// Fields
		private static readonly char[] SpecialCharacters; // 0x00
		internal JsonContainerType Type; // 0x00
		internal int Position; // 0x04
		internal string PropertyName; // 0x08
		internal bool HasIndex; // 0x10
	
		// Constructors
		public JsonPosition(JsonContainerType type); // 0x000000018000C5B0-0x000000018000C8C0
		static JsonPosition(); // 0x000000018068DB30-0x000000018068DC10
	
		// Methods
		internal int CalculateLength(); // 0x000000018000C590-0x000000018000C5A0
		internal void WriteTo(StringBuilder sb); // 0x000000018000C5A0-0x000000018000C5B0
		internal static bool TypeHasIndex(JsonContainerType type); // 0x000000018068D9A0-0x000000018068DB30
		internal static string BuildPath(List<JsonPosition> positions, JsonPosition? currentPosition); // 0x000000018068D130-0x000000018068D7A0
		internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message); // 0x000000018068D7A0-0x000000018068D9A0
	}
}
