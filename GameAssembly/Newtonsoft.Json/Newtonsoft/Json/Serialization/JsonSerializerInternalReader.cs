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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal class JsonSerializerInternalReader : JsonSerializerInternalBase // TypeDefIndex: 7935
	{
		// Nested types
		internal enum PropertyPresence // TypeDefIndex: 7936
		{
			None = 0,
			Null = 1,
			Value = 2
		}
	
		internal class CreatorPropertyContext // TypeDefIndex: 7937
		{
			// Fields
			public string Name; // 0x10
			public JsonProperty Property; // 0x18
			public JsonProperty ConstructorProperty; // 0x20
			public PropertyPresence? Presence; // 0x28
			public object Value; // 0x30
			public bool Used; // 0x38
	
			// Constructors
			public CreatorPropertyContext(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass36_0 // TypeDefIndex: 7938
		{
			// Fields
			public JsonProperty property; // 0x10
	
			// Constructors
			public <>c__DisplayClass36_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <CreateObjectUsingCreatorWithParameters>b__1(CreatorPropertyContext p); // 0x000000018059CF90-0x000000018059CFC0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 7939
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<JsonProperty, string> <>9__36_0; // 0x08
			public static Func<JsonProperty, string> <>9__36_2; // 0x10
			public static Func<JsonProperty, JsonProperty> <>9__41_0; // 0x18
			public static Func<JsonProperty, PropertyPresence> <>9__41_1; // 0x20
	
			// Constructors
			static <>c(); // 0x000000018059D140-0x000000018059D1A0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal string <CreateObjectUsingCreatorWithParameters>b__36_0(JsonProperty p); // 0x00000001804EAB40-0x00000001804EAB60
			internal string <CreateObjectUsingCreatorWithParameters>b__36_2(JsonProperty p); // 0x00000001804EAB40-0x00000001804EAB60
			internal JsonProperty <PopulateObject>b__41_0(JsonProperty m); // 0x00000001804DE840-0x00000001804DE850
			internal PropertyPresence <PopulateObject>b__41_1(JsonProperty m); // 0x000000018035FCC0-0x000000018035FCD0
		}
	
		// Constructors
		public JsonSerializerInternalReader(JsonSerializer serializer); // 0x00000001804EB6E0-0x00000001804EB760
	
		// Methods
		public void Populate(JsonReader reader, object target); // 0x00000001804F46D0-0x00000001804F4C10
		private JsonContract GetContractSafe(Type type); // 0x00000001804F1610-0x00000001804F1690
		public object Deserialize(JsonReader reader, Type objectType, bool checkAdditionalContent); // 0x00000001804F07C0-0x00000001804F0D20
		private JsonSerializerProxy GetInternalSerializer(); // 0x00000001804F1800-0x00000001804F1870
		private JToken CreateJToken(JsonReader reader, JsonContract contract); // 0x00000001804ECC00-0x00000001804ECE60
		private JToken CreateJObject(JsonReader reader); // 0x00000001804EC930-0x00000001804ECC00
		private object CreateValueInternal(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue); // 0x00000001804EFFE0-0x00000001804F04A0
		private static bool CoerceEmptyStringToNull(Type objectType, JsonContract contract, string s); // 0x00000001804EBFE0-0x00000001804EC0D0
		internal string GetExpectedDescription(JsonContract contract); // 0x00000001804F1730-0x00000001804F1800
		private JsonConverter GetConverter(JsonContract contract, JsonConverter memberConverter, JsonContainerContract containerContract, JsonProperty containerProperty); // 0x00000001804F1690-0x00000001804F1730
		private object CreateObject(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue); // 0x00000001804EF390-0x00000001804EFFE0
		private bool ReadMetadataPropertiesToken(JTokenReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id); // 0x00000001804F4F60-0x00000001804F55E0
		private bool ReadMetadataProperties(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, object existingValue, out object newValue, out string id); // 0x00000001804F55E0-0x00000001804F5C20
		private void ResolveTypeName(JsonReader reader, ref Type objectType, ref JsonContract contract, JsonProperty member, JsonContainerContract containerContract, JsonProperty containerMember, string qualifiedTypeName); // 0x00000001804F6620-0x00000001804F6A80
		private JsonArrayContract EnsureArrayContract(JsonReader reader, Type objectType, JsonContract contract); // 0x00000001804F1150-0x00000001804F12F0
		private object CreateList(JsonReader reader, Type objectType, JsonContract contract, JsonProperty member, object existingValue, string id); // 0x00000001804ECE60-0x00000001804ED710
		private bool HasNoDefinedType(JsonContract contract); // 0x00000001804F1970-0x00000001804F1A00
		private object EnsureType(JsonReader reader, object value, CultureInfo culture, JsonContract contract, Type targetType); // 0x00000001804F12F0-0x00000001804F1610
		private bool SetPropertyValue(JsonProperty property, JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target); // 0x00000001804F6CF0-0x00000001804F73D0
		private bool CalculatePropertyDetails(JsonProperty property, ref JsonConverter propertyConverter, JsonContainerContract containerContract, JsonProperty containerProperty, JsonReader reader, object target, out bool useExistingValue, out object currentValue, out JsonContract propertyContract, out bool gottenCurrentValue); // 0x00000001804EBA60-0x00000001804EBEF0
		private void AddReference(JsonReader reader, string id, object value); // 0x00000001804EB830-0x00000001804EBA60
		private bool HasFlag(DefaultValueHandling value, DefaultValueHandling flag); // 0x00000001804F1960-0x00000001804F1970
		private bool ShouldSetPropertyValue(JsonProperty property, object value); // 0x00000001804F7580-0x00000001804F76D0
		private IList CreateNewList(JsonReader reader, JsonArrayContract contract, out bool createdFromNonDefaultCreator); // 0x00000001804ED9C0-0x00000001804EDD10
		private IDictionary CreateNewDictionary(JsonReader reader, JsonDictionaryContract contract, out bool createdFromNonDefaultCreator); // 0x00000001804ED710-0x00000001804ED9C0
		private void OnDeserializing(JsonReader reader, JsonContract contract, object value); // 0x00000001804F1BB0-0x00000001804F1D60
		private void OnDeserialized(JsonReader reader, JsonContract contract, object value); // 0x00000001804F1A00-0x00000001804F1BB0
		private object PopulateDictionary(IDictionary dictionary, JsonReader reader, JsonDictionaryContract contract, JsonProperty containerProperty, string id); // 0x00000001804F1D60-0x00000001804F2940
		private object PopulateMultidimensionalArray(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id); // 0x00000001804F3080-0x00000001804F3950
		private void ThrowUnexpectedEndException(JsonReader reader, JsonContract contract, object currentObject, string message); // 0x00000001804F76D0-0x00000001804F7840
		private object PopulateList(IList list, JsonReader reader, JsonArrayContract contract, JsonProperty containerProperty, string id); // 0x00000001804F2940-0x00000001804F3080
		private object CreateISerializable(JsonReader reader, JsonISerializableContract contract, JsonProperty member, string id); // 0x00000001804EC2A0-0x00000001804EC930
		internal object CreateISerializableItem(JToken token, Type type, JsonISerializableContract contract, JsonProperty member); // 0x00000001804EC0D0-0x00000001804EC2A0
		private object CreateObjectUsingCreatorWithParameters(JsonReader reader, JsonObjectContract contract, JsonProperty containerProperty, ObjectConstructor<object> creator, string id); // 0x00000001804EDF90-0x00000001804EF390
		private object DeserializeConvertable(JsonConverter converter, JsonReader reader, Type objectType, object existingValue); // 0x00000001804F04A0-0x00000001804F07C0
		private List<CreatorPropertyContext> ResolvePropertyAndCreatorValues(JsonObjectContract contract, JsonProperty containerProperty, JsonReader reader, Type objectType); // 0x00000001804F5C20-0x00000001804F6620
		private bool ReadForType(JsonReader reader, JsonContract contract, bool hasConverter); // 0x00000001804F4CD0-0x00000001804F4F60
		public object CreateNewObject(JsonReader reader, JsonObjectContract objectContract, JsonProperty containerMember, JsonProperty containerProperty, string id, out bool createdFromNonDefaultCreator); // 0x00000001804EDD10-0x00000001804EDF90
		private object PopulateObject(object newObject, JsonReader reader, JsonObjectContract contract, JsonProperty member, string id); // 0x00000001804F3950-0x00000001804F46D0
		private bool ShouldDeserialize(JsonReader reader, JsonProperty property, object target); // 0x00000001804F73D0-0x00000001804F7580
		private bool CheckPropertyName(JsonReader reader, string memberName); // 0x00000001804EBEF0-0x00000001804EBFE0
		private void SetExtensionData(JsonObjectContract contract, JsonProperty member, JsonReader reader, string memberName, object o); // 0x00000001804F6A80-0x00000001804F6BD0
		private object ReadExtensionDataValue(JsonObjectContract contract, JsonProperty member, JsonReader reader); // 0x00000001804F4C10-0x00000001804F4CD0
		private void EndProcessProperty(object newObject, JsonReader reader, JsonObjectContract contract, int initialDepth, JsonProperty property, PropertyPresence presence, bool setDefaultValue); // 0x00000001804F0D20-0x00000001804F1150
		private void SetPropertyPresence(JsonReader reader, JsonProperty property, Dictionary<JsonProperty, PropertyPresence> requiredProperties); // 0x00000001804F6BD0-0x00000001804F6CF0
		private void HandleError(JsonReader reader, bool readPastError, int initialDepth); // 0x00000001804F1870-0x00000001804F1960
	}
}
