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

namespace Newtonsoft.Json.Converters
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class StringEnumConverter : JsonConverter // TypeDefIndex: 8185
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <CamelCaseText>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <AllowIntegerValues>k__BackingField; // 0x11
	
		// Properties
		public bool CamelCaseText { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803FD450-0x00000001803FD460 
		public bool AllowIntegerValues { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180400120-0x0000000180400130 0x0000000180400130-0x0000000180400140
	
		// Constructors
		public StringEnumConverter(); // 0x0000000180C765C0-0x0000000180C765E0
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer); // 0x0000000180C763F0-0x0000000180C765C0
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer); // 0x0000000180C76000-0x0000000180C763F0
		public override bool CanConvert(Type objectType); // 0x0000000180C75F90-0x0000000180C76000
	}
}
