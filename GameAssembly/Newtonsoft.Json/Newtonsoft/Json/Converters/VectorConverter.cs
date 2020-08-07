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
using UnityEngine;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Converters
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class VectorConverter : JsonConverter // TypeDefIndex: 8186
	{
		// Fields
		private static readonly Type V2; // 0x00
		private static readonly Type V3; // 0x08
		private static readonly Type V4; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <EnableVector2>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <EnableVector3>k__BackingField; // 0x11
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <EnableVector4>k__BackingField; // 0x12
	
		// Properties
		public bool EnableVector2 { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803FD450-0x00000001803FD460 0x00000001803FD630-0x00000001803FD640
		public bool EnableVector3 { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180400120-0x0000000180400130 0x0000000180400130-0x0000000180400140
		public bool EnableVector4 { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018041B680-0x000000018041B690 0x000000018041B750-0x000000018041B760
	
		// Constructors
		public VectorConverter(); // 0x0000000180C77370-0x0000000180C77390
		static VectorConverter(); // 0x0000000180C772C0-0x0000000180C77370
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer); // 0x0000000180C76E10-0x0000000180C77140
		private static void WriteVector(JsonWriter writer, float x, float y, float? z, float? w); // 0x0000000180C77140-0x0000000180C772C0
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer); // 0x0000000180C769D0-0x0000000180C76E10
		public override bool CanConvert(Type objectType); // 0x0000000180C765E0-0x0000000180C766D0
		private static Vector2 PopulateVector2(JsonReader reader); // 0x0000000180C766D0-0x0000000180C767B0
		private static Vector3 PopulateVector3(JsonReader reader); // 0x0000000180C767B0-0x0000000180C768B0
		private static Vector4 PopulateVector4(JsonReader reader); // 0x0000000180C768B0-0x0000000180C769D0
	}
}
