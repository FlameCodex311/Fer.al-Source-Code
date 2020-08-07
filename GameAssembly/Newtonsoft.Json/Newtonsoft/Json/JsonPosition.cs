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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal struct JsonPosition // TypeDefIndex: 7953
	{
		// Fields
		private static readonly char[] SpecialCharacters; // 0x00
		internal JsonContainerType Type; // 0x00
		internal int Position; // 0x04
		internal string PropertyName; // 0x08
		internal bool HasIndex; // 0x10
	
		// Constructors
		public JsonPosition(JsonContainerType type); // 0x00000001800642B0-0x0000000180064920
		static JsonPosition(); // 0x0000000180C64FB0-0x0000000180C65090
	
		// Methods
		internal int CalculateLength(); // 0x0000000180064290-0x00000001800642A0
		internal void WriteTo(StringBuilder sb); // 0x00000001800642A0-0x00000001800642B0
		internal static bool TypeHasIndex(JsonContainerType type); // 0x0000000180C64E30-0x0000000180C64FB0
		internal static string BuildPath(List<JsonPosition> positions, JsonPosition? currentPosition); // 0x0000000180C645F0-0x0000000180C64C40
		internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message); // 0x0000000180C64C40-0x0000000180C64E30
	}
}
