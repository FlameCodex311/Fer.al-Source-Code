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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal class JsonSerializerInternalWriter : JsonSerializerInternalBase // TypeDefIndex: 8106
	{
		// Fields
		private Type _rootType; // 0x38
		private int _rootLevel; // 0x40
		private readonly List<object> _serializeStack; // 0x48
	
		// Constructors
		public JsonSerializerInternalWriter(JsonSerializer serializer); // 0x0000000180C2A240-0x0000000180C2A2B0
	
		// Methods
		public void Serialize(JsonWriter jsonWriter, object value, Type objectType); // 0x0000000180C28A50-0x0000000180C28D20
		private JsonSerializerProxy GetInternalSerializer(); // 0x0000000180C243E0-0x0000000180C24490
		private JsonContract GetContractSafe(object value); // 0x0000000180C24350-0x0000000180C243E0
		private void SerializePrimitive(JsonWriter writer, object value, JsonPrimitiveContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x0000000180C281A0-0x0000000180C28450
		private void SerializeValue(JsonWriter writer, object value, JsonContract valueContract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x0000000180C28500-0x0000000180C28A50
		private bool? ResolveIsReference(JsonContract contract, JsonProperty property, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x0000000180C250F0-0x0000000180C251A0
		private bool ShouldWriteReference(object value, JsonProperty property, JsonContract valueContract, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x0000000180C28FD0-0x0000000180C291E0
		private bool ShouldWriteProperty(object memberValue, JsonProperty property); // 0x0000000180C28ED0-0x0000000180C28FD0
		private bool CheckForCircularReference(JsonWriter writer, object value, JsonProperty property, JsonContract contract, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x0000000180C23F60-0x0000000180C24350
		private void WriteReference(JsonWriter writer, object value); // 0x0000000180C29A90-0x0000000180C29C70
		private string GetReference(JsonWriter writer, object value); // 0x0000000180C24A20-0x0000000180C24BB0
		internal static bool TryConvertToString(object value, Type type, out string s); // 0x0000000180C29380-0x0000000180C295E0
		private void SerializeString(JsonWriter writer, object value, JsonStringContract contract); // 0x0000000180C28450-0x0000000180C28500
		private void OnSerializing(JsonWriter writer, JsonContract contract, object value); // 0x0000000180C24F70-0x0000000180C250F0
		private void OnSerialized(JsonWriter writer, JsonContract contract, object value); // 0x0000000180C24DF0-0x0000000180C24F70
		private void SerializeObject(JsonWriter writer, object value, JsonObjectContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x0000000180C27840-0x0000000180C281A0
		private bool CalculatePropertyValues(JsonWriter writer, object value, JsonContainerContract contract, JsonProperty member, JsonProperty property, out JsonContract memberContract, out object memberValue); // 0x0000000180C237B0-0x0000000180C23F60
		private void WriteObjectStart(JsonWriter writer, object value, JsonContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x0000000180C295E0-0x0000000180C298F0
		private void WriteReferenceIdProperty(JsonWriter writer, Type type, object value); // 0x0000000180C298F0-0x0000000180C29A90
		private void WriteTypeProperty(JsonWriter writer, Type type); // 0x0000000180C2A070-0x0000000180C2A240
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag); // 0x0000000180C24C30-0x0000000180C24C40
		private bool HasFlag(PreserveReferencesHandling value, PreserveReferencesHandling flag); // 0x0000000180C24C30-0x0000000180C24C40
		private bool HasFlag(TypeNameHandling value, TypeNameHandling flag); // 0x0000000180C24C30-0x0000000180C24C40
		private void SerializeConvertable(JsonWriter writer, JsonConverter converter, object value, JsonContract contract, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x0000000180C251A0-0x0000000180C255A0
		private void SerializeList(JsonWriter writer, IEnumerable values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x0000000180C26620-0x0000000180C26F00
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x0000000180C27330-0x0000000180C27840
		private void SerializeMultidimensionalArray(JsonWriter writer, Array values, JsonArrayContract contract, JsonProperty member, int initialDepth, int[] indices); // 0x0000000180C26F00-0x0000000180C27330
		private bool WriteStartArray(JsonWriter writer, object values, JsonArrayContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x0000000180C29C70-0x0000000180C2A070
		private void SerializeISerializable(JsonWriter writer, ISerializable value, JsonISerializableContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x0000000180C25ED0-0x0000000180C26620
		private bool ShouldWriteType(TypeNameHandling typeNameHandlingFlag, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x0000000180C291E0-0x0000000180C29380
		private void SerializeDictionary(JsonWriter writer, IDictionary values, JsonDictionaryContract contract, JsonProperty member, JsonContainerContract collectionContract, JsonProperty containerProperty); // 0x0000000180C255A0-0x0000000180C25ED0
		private string GetPropertyName(JsonWriter writer, object name, JsonContract contract, out bool escape); // 0x0000000180C24490-0x0000000180C24A20
		private void HandleError(JsonWriter writer, int initialDepth); // 0x0000000180C24BB0-0x0000000180C24C30
		private bool ShouldSerialize(JsonWriter writer, JsonProperty property, object target); // 0x0000000180C28D20-0x0000000180C28ED0
		private bool IsSpecified(JsonWriter writer, JsonProperty property, object target); // 0x0000000180C24C40-0x0000000180C24DF0
	}
}
