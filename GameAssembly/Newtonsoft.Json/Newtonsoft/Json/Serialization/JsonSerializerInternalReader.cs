/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal class JsonSerializerInternalReader : JsonSerializerInternalBase // TypeDefIndex: 8101
	{
		// Nested types
		internal enum PropertyPresence // TypeDefIndex: 8102
		{
			None = 0,
			Null = 1,
			Value = 2
		}
	
		internal class CreatorPropertyContext // TypeDefIndex: 8103
		{
			// Fields
			public string Name; // 0x10
			public JsonProperty Property; // 0x18
			public JsonProperty ConstructorProperty; // 0x20
			public PropertyPresence? Presence; // 0x28
			public object Value; // 0x30
			public bool Used; // 0x38
	
			// Constructors
			public CreatorPropertyContext(); // 0x0000000180373240-0x0000000180373250
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass36_0 // TypeDefIndex: 8104
		{
			// Fields
			public JsonProperty property; // 0x10
	
			// Constructors
			public <>c__DisplayClass36_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <CreateObjectUsingCreatorWithParameters>b__1(CreatorPropertyContext p); // 0x0000000180C351B0-0x0000000180C351D0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 8105
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<JsonProperty, string> <>9__36_0; // 0x08
			public static Func<JsonProperty, string> <>9__36_2; // 0x10
			public static Func<JsonProperty, JsonProperty> <>9__41_0; // 0x18
			public static Func<JsonProperty, PropertyPresence> <>9__41_1; // 0x20
	
			// Constructors
			static <>c(); // 0x0000000180C35350-0x0000000180C353B0
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal string <CreateObjectUsingCreatorWithParameters>b__36_0(JsonProperty p); // 0x0000000180C34BD0-0x0000000180C34BF0
			internal string <CreateObjectUsingCreatorWithParameters>b__36_2(JsonProperty p); // 0x0000000180C34BD0-0x0000000180C34BF0
			internal JsonProperty <PopulateObject>b__41_0(JsonProperty m); // 0x00000001804EC160-0x00000001804EC170
			internal PropertyPresence <PopulateObject>b__41_1(JsonProperty m); // 0x000000018037DDC0-0x000000018037DDD0
		}
	
		// Constructors
		public JsonSerializerInternalReader(JsonSerializer serializer); // 0x0000000180E90DD0-0x0000000180E90E50
	
		// Methods
		public void Populate(JsonReader reader, object target); // 0x0000000180E99AB0-0x0000000180E99FE0
		private JsonContract GetContractSafe(Type type); // 0x0000000180E96AB0-0x0000000180E96B30
		public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent); // 0x0000000180E95CA0-0x0000000180E961E0
		private JsonSerializerProxy GetInternalSerializer(); // 0x0000000180E96CA0-0x0000000180E96D10
		private JToken CreateJToken(JsonReader reader, JsonContract contract); // 0x0000000180E92260-0x0000000180E92480
		private JToken CreateJObject(JsonReader reader); // 0x0000000180E91FD0-0x0000000180E92260
		private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue); // 0x0000000180E954E0-0x0000000180E95990
		private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s); // 0x0000000180E916C0-0x0000000180E917B0
		internal string GetExpectedDescription(JsonContract contract); // 0x0000000180E96BD0-0x0000000180E96CA0
		private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x0000000180E96B30-0x0000000180E96BD0
		private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue); // 0x0000000180E948D0-0x0000000180E954E0
		private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id); // 0x0000000180E9A310-0x0000000180E9A970
		private bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id); // 0x0000000180E9A970-0x0000000180E9AF90
		private void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName); // 0x0000000180E9B960-0x0000000180E9BDB0
		private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract); // 0x0000000180E965F0-0x0000000180E96790
		private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id); // 0x0000000180E92480-0x0000000180E92D00
		private bool HasNoDefinedType(JsonContract contract); // 0x0000000180E96E00-0x0000000180E96E90
		private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType); // 0x0000000180E96790-0x0000000180E96AB0
		private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target); // 0x0000000180E9C020-0x0000000180E9C6E0
		private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue); // 0x0000000180E91150-0x0000000180E915D0
		private void AddReference(JsonReader reader, string id, object value); // 0x0000000180E90F20-0x0000000180E91150
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag); // 0x0000000180C24C30-0x0000000180C24C40
		private bool ShouldSetPropertyValue(JsonProperty property, object value); // 0x0000000180E9C890-0x0000000180E9C9D0
		private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator); // 0x0000000180E92FA0-0x0000000180E932E0
		private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator); // 0x0000000180E92D00-0x0000000180E92FA0
		private void OnDeserializing(JsonReader reader, JsonContract contract, object value); // 0x0000000180E97030-0x0000000180E971D0
		private void OnDeserialized(JsonReader reader, JsonContract contract, object value); // 0x0000000180E96E90-0x0000000180E97030
		private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id); // 0x0000000180E971D0-0x0000000180E97D80
		private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id); // 0x0000000180E984B0-0x0000000180E98D60
		private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message); // 0x0000000180E9C9D0-0x0000000180E9CB30
		private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id); // 0x0000000180E97D80-0x0000000180E984B0
		private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id); // 0x0000000180E91970-0x0000000180E91FD0
		internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member); // 0x0000000180E917B0-0x0000000180E91970
		private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id); // 0x0000000180E93550-0x0000000180E948D0
		private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue); // 0x0000000180E95990-0x0000000180E95CA0
		private List<CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType); // 0x0000000180E9AF90-0x0000000180E9B960
		private bool ReadForType(JsonReader reader, JsonContract contract, bool hasConverter); // 0x0000000180E9A0A0-0x0000000180E9A310
		public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator); // 0x0000000180E932E0-0x0000000180E93550
		private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id); // 0x0000000180E98D60-0x0000000180E99AB0
		private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target); // 0x0000000180E9C6E0-0x0000000180E9C890
		private bool CheckPropertyName(JsonReader reader, string memberName); // 0x0000000180E915D0-0x0000000180E916C0
		private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o); // 0x0000000180E9BDB0-0x0000000180E9BF00
		private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader); // 0x0000000180E99FE0-0x0000000180E9A0A0
		private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, PropertyPresence presence, bool setDefaultValue); // 0x0000000180E961E0-0x0000000180E965F0
		private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, PropertyPresence> requiredProperties); // 0x0000000180E9BF00-0x0000000180E9C020
		private void HandleError(JsonReader reader, bool readPastError, int initialDepth); // 0x0000000180E96D10-0x0000000180E96E00
	}
}
