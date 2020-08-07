/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class JTokenReader : JsonReader, IJsonLineInfo // TypeDefIndex: 8144
	{
		// Fields
		private readonly JToken _root; // 0x78
		private string _initialPath; // 0x80
		private JToken _parent; // 0x88
		private JToken _current; // 0x90
	
		// Properties
		public JToken CurrentToken { get; } // 0x00000001803D6D80-0x00000001803D6D90 
		int IJsonLineInfo.LineNumber { get; } // 0x000000018183CFA0-0x000000018183D000 
		int IJsonLineInfo.LinePosition { get; } // 0x000000018183D000-0x000000018183D060 
		public override string Path { get; } // 0x000000018183DD50-0x000000018183DE40 
	
		// Constructors
		public JTokenReader(JToken token); // 0x000000018183DCF0-0x000000018183DD50
	
		// Methods
		public override bool Read(); // 0x000000018183D200-0x000000018183D510
		private bool ReadOver(JToken t); // 0x000000018183D0E0-0x000000018183D1E0
		private bool ReadToEnd(); // 0x000000018183D1E0-0x000000018183D200
		private JsonToken? GetEndToken(JContainer c); // 0x000000018183CE00-0x000000018183CF40
		private bool ReadInto(JContainer c); // 0x000000018183D060-0x000000018183D0E0
		private bool SetEnd(JContainer c); // 0x000000018183D530-0x000000018183D6B0
		private void SetToken(JToken token); // 0x000000018183D6B0-0x000000018183DCF0
		private string SafeToString(object value); // 0x000000018183D510-0x000000018183D530
		bool IJsonLineInfo.HasLineInfo(); // 0x000000018183CF40-0x000000018183CFA0
	}
}
