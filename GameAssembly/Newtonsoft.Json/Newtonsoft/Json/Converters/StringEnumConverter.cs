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

namespace Newtonsoft.Json.Converters
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class StringEnumConverter : JsonConverter // TypeDefIndex: 8019
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <CamelCaseText>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <AllowIntegerValues>k__BackingField; // 0x11
	
		// Properties
		public bool CamelCaseText { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x0000000180375540-0x0000000180375550 
		public bool AllowIntegerValues { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180375550-0x0000000180375560 0x0000000180393640-0x0000000180393650
	
		// Constructors
		public StringEnumConverter(); // 0x0000000180696ED0-0x0000000180696EF0
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer); // 0x0000000180696CF0-0x0000000180696ED0
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer); // 0x00000001806968F0-0x0000000180696CF0
		public override bool CanConvert(Type objectType); // 0x0000000180696880-0x00000001806968F0
	}
}
