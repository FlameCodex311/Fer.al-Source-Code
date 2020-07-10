/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal class JsonSerializerInternalWriter : JsonSerializerInternalBase // TypeDefIndex: 7940
	{
		// Fields
		private Type _rootType; // 0x38
		private int _rootLevel; // 0x40
		private readonly List<object> _serializeStack; // 0x48
	
		// Constructors
		public JsonSerializerInternalWriter(JsonSerializer serializer); // 0x0000000180592030-0x00000001805920A0
	
		// Methods
		public void Serialize(JsonWriter jsonWriter, object value, Type objectType); // 0x0000000180590730-0x0000000180590A10
		private JsonSerializerProxy GetInternalSerializer(); // 0x000000018058BF50-0x000000018058C000
		private JsonContract GetContractSafe(object value); // 0x000000018058BEC0-0x000000018058BF50
		private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x000000018058FE50-0x0000000180590110
		private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x00000001805901D0-0x0000000180590730
		private bool? ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x000000018058CC80-0x000000018058CD30
		private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x0000000180590CD0-0x0000000180590EE0
		private bool ShouldWriteProperty(object memberValue, JsonProperty property); // 0x0000000180590BC0-0x0000000180590CD0
		private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x000000018058BAB0-0x000000018058BEC0
		private void WriteReference(JsonWriter writer, object value); // 0x00000001805917C0-0x00000001805919A0
		private string GetReference(JsonWriter writer, object value); // 0x000000018058C5A0-0x000000018058C730
		internal static bool TryConvertToString(object value, Type type, out string s); // 0x0000000180591090-0x00000001805912F0
		private void SerializeString(JsonWriter writer, object value, JsonStringContract contract); // 0x0000000180590110-0x00000001805901D0
		private void OnSerializing(JsonWriter writer, JsonContract contract, object value); // 0x000000018058CAF0-0x000000018058CC80
		private void OnSerialized(JsonWriter writer, JsonContract contract, object value); // 0x000000018058C960-0x000000018058CAF0
		private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x000000018058F4C0-0x000000018058FE50
		private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue); // 0x000000018058B2D0-0x000000018058BAB0
		private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x00000001805912F0-0x0000000180591610
		private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value); // 0x0000000180591610-0x00000001805917C0
		private void WriteTypeProperty(JsonWriter writer, Type type); // 0x0000000180591DC0-0x0000000180592030
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag); // 0x00000001804F1960-0x00000001804F1970
		private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag); // 0x00000001804F1960-0x00000001804F1970
		private bool HasFlag(TypeNameHandling value, TypeNameHandling flag); // 0x00000001804F1960-0x00000001804F1970
		private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x000000018058CD30-0x000000018058D140
		private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x000000018058E230-0x000000018058EB40
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x000000018058EF80-0x000000018058F4C0
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices); // 0x000000018058EB40-0x000000018058EF80
		private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x00000001805919A0-0x0000000180591DC0
		private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x000000018058DAB0-0x000000018058E230
		private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x0000000180590EE0-0x0000000180591090
		private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x000000018058D140-0x000000018058DAB0
		private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape); // 0x000000018058C000-0x000000018058C5A0
		private void HandleError(JsonWriter writer, int initialDepth); // 0x000000018058C730-0x000000018058C7B0
		private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target); // 0x0000000180590A10-0x0000000180590BC0
		private bool IsSpecified(JsonWriter writer, JsonProperty property, object target); // 0x000000018058C7B0-0x000000018058C960
	}
}
