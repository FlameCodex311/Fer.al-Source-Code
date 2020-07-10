/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x0000000180120400-0x0000000180120440
	public class JConstructor : JContainer // TypeDefIndex: 7970
	{
		// Fields
		private string _name; // 0x50
		private readonly List<JToken> _values; // 0x58
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get; } // 0x0000000180357120-0x0000000180357130 
		public string Name { get; } // 0x00000001803A27A0-0x00000001803A27B0 
		public override JTokenType Type { get; } // 0x000000018038FAD0-0x000000018038FAE0 
	
		// Constructors
		public JConstructor(); // 0x000000018094F060-0x000000018094F100
		public JConstructor(JConstructor other); // 0x000000018094F230-0x000000018094F2C0
		public JConstructor(string name); // 0x000000018094F100-0x000000018094F230
	
		// Methods
		internal override int IndexOfItem(JToken item); // 0x000000018094EBF0-0x000000018094EC40
		internal override bool DeepEquals(JToken node); // 0x000000018094E9C0-0x000000018094EBA0
		internal override JToken CloneToken(); // 0x000000018094E910-0x000000018094E9C0
		public override void WriteTo(JsonWriter writer, params /* 0x00000001800B36B0-0x00000001800B36C0 */ JsonConverter[] converters); // 0x000000018094EE40-0x000000018094F060
		internal override int GetDeepHashCode(); // 0x000000018094EBA0-0x000000018094EBF0
		public static JConstructor Load(JsonReader reader, JsonLoadSettings settings); // 0x000000018094EC40-0x000000018094EE40
	}
}
