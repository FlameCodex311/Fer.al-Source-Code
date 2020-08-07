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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Linq
{
	[Preserve] // 0x0000000180257B50-0x0000000180257B90
	public class JConstructor : JContainer // TypeDefIndex: 8136
	{
		// Fields
		private string _name; // 0x50
		private readonly List<JToken> _values; // 0x58
	
		// Properties
		protected override IList<JToken> ChildrenTokens { get; } // 0x00000001803A1580-0x00000001803A1590 
		public string Name { get; } // 0x0000000180378320-0x0000000180378330 
		public override JTokenType Type { get; } // 0x000000018043E010-0x000000018043E020 
	
		// Constructors
		public JConstructor(); // 0x0000000181835700-0x00000001818357A0
		public JConstructor(JConstructor other); // 0x00000001818358C0-0x0000000181835950
		public JConstructor(string name); // 0x00000001818357A0-0x00000001818358C0
	
		// Methods
		internal override int IndexOfItem(JToken item); // 0x00000001818352A0-0x00000001818352F0
		internal override bool DeepEquals(JToken node); // 0x0000000181835080-0x0000000181835250
		internal override JToken CloneToken(); // 0x0000000181834FD0-0x0000000181835080
		public override void WriteTo(JsonWriter writer, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ JsonConverter[] converters); // 0x00000001818354F0-0x0000000181835700
		internal override int GetDeepHashCode(); // 0x0000000181835250-0x00000001818352A0
		public static JConstructor Load(JsonReader reader, JsonLoadSettings settings); // 0x00000001818352F0-0x00000001818354F0
	}
}
