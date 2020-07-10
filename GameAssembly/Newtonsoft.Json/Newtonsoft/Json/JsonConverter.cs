﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public abstract class JsonConverter // TypeDefIndex: 7810
	{
		// Properties
		public virtual bool CanRead { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public virtual bool CanWrite { get; } // 0x00000001803C29F0-0x00000001803C2A00 
	
		// Constructors
		protected JsonConverter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public abstract void WriteJson(JsonWriter writer, object value, JsonSerializer serializer);
		public abstract object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);
		public abstract bool CanConvert(Type objectType);
	}
}