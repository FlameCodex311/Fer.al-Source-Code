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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class JTokenReader : JsonReader, IJsonLineInfo // TypeDefIndex: 7978
	{
		// Fields
		private readonly JToken _root; // 0x78
		private string _initialPath; // 0x80
		private JToken _parent; // 0x88
		private JToken _current; // 0x90
	
		// Properties
		public JToken CurrentToken { get; } // 0x0000000180382A80-0x0000000180382A90 
		int IJsonLineInfo.LineNumber { get; } // 0x00000001804E1BF0-0x00000001804E1C50 
		int IJsonLineInfo.LinePosition { get; } // 0x00000001804E1C50-0x00000001804E1CB0 
		public override string Path { get; } // 0x00000001804E29E0-0x00000001804E2AD0 
	
		// Constructors
		public JTokenReader(JToken token); // 0x00000001804E2980-0x00000001804E29E0
	
		// Methods
		public override bool Read(); // 0x00000001804E1E60-0x00000001804E2170
		private bool ReadOver(JToken t); // 0x00000001804E1D40-0x00000001804E1E40
		private bool ReadToEnd(); // 0x00000001804E1E40-0x00000001804E1E60
		private JsonToken? GetEndToken(JContainer c); // 0x00000001804E1A50-0x00000001804E1B90
		private bool ReadInto(JContainer c); // 0x00000001804E1CB0-0x00000001804E1D40
		private bool SetEnd(JContainer c); // 0x00000001804E2190-0x00000001804E2320
		private void SetToken(JToken token); // 0x00000001804E2320-0x00000001804E2980
		private string SafeToString(object value); // 0x00000001804E2170-0x00000001804E2190
		bool IJsonLineInfo.HasLineInfo(); // 0x00000001804E1B90-0x00000001804E1BF0
	}
}
