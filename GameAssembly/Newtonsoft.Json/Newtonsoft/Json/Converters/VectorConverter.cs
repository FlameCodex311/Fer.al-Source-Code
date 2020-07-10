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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Converters
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class VectorConverter : JsonConverter // TypeDefIndex: 8020
	{
		// Fields
		private static readonly Type V2; // 0x00
		private static readonly Type V3; // 0x08
		private static readonly Type V4; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <EnableVector2>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <EnableVector3>k__BackingField; // 0x11
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <EnableVector4>k__BackingField; // 0x12
	
		// Properties
		public bool EnableVector2 { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180375540-0x0000000180375550 0x00000001803930B0-0x00000001803930C0
		public bool EnableVector3 { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x0000000180375550-0x0000000180375560 0x0000000180393640-0x0000000180393650
		public bool EnableVector4 { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018036CB60-0x000000018036CB70 0x000000018036CC30-0x000000018036CC40
	
		// Constructors
		public VectorConverter(); // 0x0000000180697CB0-0x0000000180697CD0
		static VectorConverter(); // 0x0000000180697C00-0x0000000180697CB0
	
		// Methods
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer); // 0x0000000180697750-0x0000000180697A80
		private static void WriteVector(JsonWriter writer, float x, float y, float? z, float? w); // 0x0000000180697A80-0x0000000180697C00
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer); // 0x0000000180697300-0x0000000180697750
		public override bool CanConvert(Type objectType); // 0x0000000180696EF0-0x0000000180696FE0
		private static Vector2 PopulateVector2(JsonReader reader); // 0x0000000180696FE0-0x00000001806970D0
		private static Vector3 PopulateVector3(JsonReader reader); // 0x00000001806970D0-0x00000001806971D0
		private static Vector4 PopulateVector4(JsonReader reader); // 0x00000001806971D0-0x0000000180697300
	}
}
