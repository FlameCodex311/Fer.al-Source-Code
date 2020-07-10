/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	public class DefaultContractResolver : IContractResolver // TypeDefIndex: 7905
	{
		// Fields
		private static readonly IContractResolver _instance; // 0x00
		private static readonly JsonConverter[] BuiltInConverters; // 0x08
		private static readonly object TypeContractCacheLock; // 0x10
		private static readonly DefaultContractResolverState _sharedState; // 0x18
		private readonly DefaultContractResolverState _instanceState; // 0x10
		private readonly bool _sharedCache; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private BindingFlags <DefaultMembersSearchFlags>k__BackingField; // 0x1C
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <SerializeCompilerGeneratedMembers>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IgnoreSerializableInterface>k__BackingField; // 0x21
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IgnoreSerializableAttribute>k__BackingField; // 0x22
	
		// Properties
		internal static IContractResolver Instance { get; } // 0x00000001804DFED0-0x00000001804DFF30 
		public bool DynamicCodeGeneration { get; } // 0x00000001804DFE80-0x00000001804DFED0 
		[Obsolete] // 0x000000018010A810-0x000000018010A840
		public BindingFlags DefaultMembersSearchFlags { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x000000018037E420-0x000000018037E430 0x000000018037E600-0x000000018037E610
		public bool SerializeCompilerGeneratedMembers { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001803C19E0-0x00000001803C19F0 
		public bool IgnoreSerializableInterface { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x00000001803C19F0-0x00000001803C1A00 
		public bool IgnoreSerializableAttribute { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001803C1A00-0x00000001803C1A10 0x00000001804DFF30-0x00000001804DFF40
	
		// Nested types
		internal class EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> // TypeDefIndex: 7906
		{
			// Nested types
			[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
			private sealed class <GetEnumerator>d__2 // TypeDefIndex: 7907
			{
			}
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 7908
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<MemberInfo, bool> <>9__30_0; // 0x08
			public static Func<MemberInfo, bool> <>9__30_1; // 0x10
			public static Func<Type, IEnumerable<MemberInfo>> <>9__33_0; // 0x18
			public static Func<MemberInfo, bool> <>9__33_1; // 0x20
			public static Func<ConstructorInfo, bool> <>9__36_0; // 0x28
			public static Func<JsonProperty, int> <>9__60_0; // 0x30
	
			// Constructors
			static <>c(); // 0x00000001804F88C0-0x00000001804F8920
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <GetSerializableMembers>b__30_0(MemberInfo m); // 0x00000001804F8040-0x00000001804F80A0
			internal bool <GetSerializableMembers>b__30_1(MemberInfo m); // 0x00000001804F80A0-0x00000001804F8100
			internal IEnumerable<MemberInfo> <GetExtensionDataMemberForType>b__33_0(Type baseType); // 0x00000001804F7AF0-0x00000001804F7BB0
			internal bool <GetExtensionDataMemberForType>b__33_1(MemberInfo m); // 0x00000001804F7BB0-0x00000001804F8040
			internal bool <GetAttributeConstructor>b__36_0(ConstructorInfo c); // 0x00000001804F7A60-0x00000001804F7AF0
			internal int <CreateProperties>b__60_0(JsonProperty p); // 0x00000001804F7A10-0x00000001804F7A60
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass34_0 // TypeDefIndex: 7909
		{
			// Fields
			public Func<object, object> getExtensionDataDictionary; // 0x10
			public MemberInfo member; // 0x18
	
			// Constructors
			public <>c__DisplayClass34_0(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass34_1 // TypeDefIndex: 7910
		{
			// Fields
			public Action<object, object> setExtensionDataDictionary; // 0x10
			public Func<object> createExtensionDataDictionary; // 0x18
			public MethodCall<object, object> setExtensionDataDictionaryValue; // 0x20
			public <>c__DisplayClass34_0 CS$<>8__locals1; // 0x28
	
			// Constructors
			public <>c__DisplayClass34_1(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <SetExtensionDataDelegates>b__0(object o, string key, object value); // 0x00000001804F8100-0x00000001804F8380
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass34_2 // TypeDefIndex: 7911
		{
			// Fields
			public ObjectConstructor<object> createEnumerableWrapper; // 0x10
			public <>c__DisplayClass34_0 CS$<>8__locals2; // 0x18
	
			// Constructors
			public <>c__DisplayClass34_2(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal IEnumerable<KeyValuePair<object, object>> <SetExtensionDataDelegates>b__1(object o); // 0x00000001804F8380-0x00000001804F84D0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass64_0 // TypeDefIndex: 7912
		{
			// Fields
			public MethodCall<object, object> shouldSerializeCall; // 0x10
	
			// Constructors
			public <>c__DisplayClass64_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <CreateShouldSerializeTest>b__0(object o); // 0x00000001804F84D0-0x00000001804F8570
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass65_0 // TypeDefIndex: 7913
		{
			// Fields
			public Func<object, object> specifiedPropertyGet; // 0x10
	
			// Constructors
			public <>c__DisplayClass65_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <SetIsSpecifiedActions>b__0(object o); // 0x00000001804F8570-0x00000001804F8600
		}
	
		// Constructors
		public DefaultContractResolver(); // 0x00000001804DFDD0-0x00000001804DFE80
		[Obsolete] // 0x000000018010A6B0-0x000000018010A6E0
		public DefaultContractResolver(bool shareCache); // 0x00000001804DFD10-0x00000001804DFDD0
		static DefaultContractResolver(); // 0x00000001804DFA40-0x00000001804DFD10
	
		// Methods
		internal DefaultContractResolverState GetState(); // 0x00000001804DD680-0x00000001804DD6F0
		public virtual JsonContract ResolveContract(Type type); // 0x00000001804DE5F0-0x00000001804DE840
		protected virtual List<MemberInfo> GetSerializableMembers(Type objectType); // 0x00000001804DCF40-0x00000001804DD680
		private bool ShouldSerializeEntityMember(MemberInfo memberInfo); // 0x00000001804DF920-0x00000001804DFA40
		protected virtual JsonObjectContract CreateObjectContract(Type objectType); // 0x00000001804DAD10-0x00000001804DB2B0
		private MemberInfo GetExtensionDataMemberForType(Type type); // 0x00000001804DCCD0-0x00000001804DCE80
		private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member); // 0x00000001804DE850-0x00000001804DF160
		private ConstructorInfo GetAttributeConstructor(Type objectType); // 0x00000001804DBEB0-0x00000001804DC2A0
		private ConstructorInfo GetParameterizedConstructor(Type objectType); // 0x00000001804DCE80-0x00000001804DCF20
		protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties); // 0x00000001804D9E70-0x00000001804DA070
		protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo); // 0x00000001804DB770-0x00000001804DBA30
		protected virtual JsonConverter ResolveContractConverter(Type objectType); // 0x00000001804DE590-0x00000001804DE5F0
		private Func<object> GetDefaultCreator(Type createdType); // 0x00000001804DCC30-0x00000001804DCCD0
		private void InitializeContract(JsonContract contract); // 0x00000001804DD6F0-0x00000001804DD980
		private void ResolveCallbackMethods(JsonContract contract, Type t); // 0x00000001804DE330-0x00000001804DE590
		private void GetCallbackMethodsForType(Type type, out List<SerializationCallback> onSerializing, out List<SerializationCallback> onSerialized, out List<SerializationCallback> onDeserializing, out List<SerializationCallback> onDeserialized, out List<SerializationErrorCallback> onError); // 0x00000001804DC2A0-0x00000001804DC960
		private static bool ShouldSkipDeserialized(Type t); // 0x00000001803C28F0-0x00000001803C2900
		private static bool ShouldSkipSerializing(Type t); // 0x00000001803C28F0-0x00000001803C2900
		private List<Type> GetClassHierarchyForType(Type type); // 0x00000001804DC960-0x00000001804DCA50
		protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType); // 0x00000001804DA4D0-0x00000001804DA980
		protected virtual JsonArrayContract CreateArrayContract(Type objectType); // 0x00000001804D9B30-0x00000001804D9E70
		protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType); // 0x00000001804DB2B0-0x00000001804DB3E0
		protected virtual JsonLinqContract CreateLinqContract(Type objectType); // 0x00000001804DABA0-0x00000001804DAC20
		protected virtual JsonISerializableContract CreateISerializableContract(Type objectType); // 0x00000001804DA980-0x00000001804DABA0
		protected virtual JsonStringContract CreateStringContract(Type objectType); // 0x00000001804DBE40-0x00000001804DBEB0
		protected virtual JsonContract CreateContract(Type objectType); // 0x00000001804DA070-0x00000001804DA4D0
		internal static bool IsJsonPrimitiveType(Type t); // 0x00000001804DDB10-0x00000001804DDB80
		internal static bool IsIConvertible(Type t); // 0x00000001804DD980-0x00000001804DDB10
		internal static bool CanConvertToString(Type type); // 0x00000001804D9900-0x00000001804D9B30
		private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType); // 0x00000001804DDB80-0x00000001804DE330
		internal static string GetClrTypeFullName(Type type); // 0x00000001804DCA50-0x00000001804DCC30
		protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization); // 0x00000001804DB3E0-0x00000001804DB770
		protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member); // 0x00000001804DAC20-0x00000001804DAD10
		protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization); // 0x00000001804DBA30-0x00000001804DBC30
		private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess); // 0x00000001804DF430-0x00000001804DF920
		private Predicate<object> CreateShouldSerializeTest(MemberInfo member); // 0x00000001804DBC30-0x00000001804DBE40
		private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess); // 0x00000001804DF160-0x00000001804DF430
		protected virtual string ResolvePropertyName(string propertyName); // 0x00000001804DE840-0x00000001804DE850
		protected virtual string ResolveDictionaryKey(string dictionaryKey); // 0x00000001804DCF20-0x00000001804DCF40
		public string GetResolvedPropertyName(string propertyName); // 0x00000001804DCF20-0x00000001804DCF40
	}
}
