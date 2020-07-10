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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Converters
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class IsoDateTimeConverter : DateTimeConverterBase // TypeDefIndex: 8022
	{
		// Fields
		private DateTimeStyles _dateTimeStyles; // 0x10
		private string _dateTimeFormat; // 0x18
		private CultureInfo _culture; // 0x20
	
		// Properties
		public CultureInfo Culture { get; } // 0x000000018068B5C0-0x000000018068B620 
	
		// Constructors
		public IsoDateTimeConverter(); // 0x000000018068B5B0-0x000000018068B5C0
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer); // 0x000000018068B340-0x000000018068B5B0
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer); // 0x000000018068AD70-0x000000018068B340
	}
}
