/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Converters
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class IsoDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 8188
	{
		// Fields
		private DateTimeStyles _dateTimeStyles; // 0x10
		private string _dateTimeFormat; // 0x18
		private CultureInfo _culture; // 0x20
	
		// Properties
		public CultureInfo Culture { get; } // 0x0000000180C629D0-0x0000000180C62A30 
	
		// Constructors
		public IsoDateTimeConverter(); // 0x0000000180C629C0-0x0000000180C629D0
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer); // 0x0000000180C62750-0x0000000180C629C0
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer); // 0x0000000180C62190-0x0000000180C62750
	}
}
