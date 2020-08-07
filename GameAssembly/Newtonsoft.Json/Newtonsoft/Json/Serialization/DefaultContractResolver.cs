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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class DefaultContractResolver : IContractResolver // TypeDefIndex: 8071
	{
		// Fields
		private static readonly IContractResolver _instance; // 0x00
		private static readonly JsonConverter[] BuiltInConverters; // 0x08
		private static readonly object TypeContractCacheLock; // 0x10
		private static readonly DefaultContractResolverState _sharedState; // 0x18
		private readonly DefaultContractResolverState _instanceState; // 0x10
		private readonly bool _sharedCache; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private BindingFlags <DefaultMembersSearchFlags>k__BackingField; // 0x1C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <SerializeCompilerGeneratedMembers>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IgnoreSerializableInterface>k__BackingField; // 0x21
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IgnoreSerializableAttribute>k__BackingField; // 0x22
	
		// Properties
		internal static IContractResolver Instance { get; } // 0x0000000180E8A6D0-0x0000000180E8A730 
		public bool DynamicCodeGeneration { get; } // 0x0000000180E8A680-0x0000000180E8A6D0 
		[Obsolete] // 0x000000018026FC30-0x000000018026FC60
		public BindingFlags DefaultMembersSearchFlags { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001803FB770-0x00000001803FB780 0x000000018042D0F0-0x000000018042D100
		public bool SerializeCompilerGeneratedMembers { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001803FA090-0x00000001803FA0A0 
		public bool IgnoreSerializableInterface { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x00000001804F2E80-0x00000001804F2E90 
		public bool IgnoreSerializableAttribute { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001806DBF30-0x00000001806DBF40 0x0000000180A4E490-0x0000000180A4E4A0
	
		// Nested types
		internal class EnumerableDictionaryWrapper<TEnumeratorKey, TEnumeratorValue> // TypeDefIndex: 8072
		{
			// Nested types
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class <GetEnumerator>d__2 // TypeDefIndex: 8073
			{
			}
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 8074
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
			static <>c(); // 0x0000000180E9DB00-0x0000000180E9DB60
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <GetSerializableMembers>b__30_0(MemberInfo m); // 0x0000000180E9D2D0-0x0000000180E9D330
			internal bool <GetSerializableMembers>b__30_1(MemberInfo m); // 0x0000000180E9D330-0x0000000180E9D390
			internal IEnumerable<MemberInfo> <GetExtensionDataMemberForType>b__33_0(Type baseType); // 0x0000000180E9CD90-0x0000000180E9CE50
			internal bool <GetExtensionDataMemberForType>b__33_1(MemberInfo m); // 0x0000000180E9CE50-0x0000000180E9D2D0
			internal bool <GetAttributeConstructor>b__36_0(ConstructorInfo c); // 0x0000000180E9CD00-0x0000000180E9CD90
			internal int <CreateProperties>b__60_0(JsonProperty p); // 0x0000000180E9CCB0-0x0000000180E9CD00
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass34_0 // TypeDefIndex: 8075
		{
			// Fields
			public Func<object, object> getExtensionDataDictionary; // 0x10
			public MemberInfo member; // 0x18
	
			// Constructors
			public <>c__DisplayClass34_0(); // 0x0000000180373240-0x0000000180373250
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass34_1 // TypeDefIndex: 8076
		{
			// Fields
			public Action<object, object> setExtensionDataDictionary; // 0x10
			public Func<object> createExtensionDataDictionary; // 0x18
			public MethodCall<object, object> setExtensionDataDictionaryValue; // 0x20
			public <>c__DisplayClass34_0 CS$<>8__locals1; // 0x28
	
			// Constructors
			public <>c__DisplayClass34_1(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <SetExtensionDataDelegates>b__0(object o, string key, object value); // 0x0000000180E9D390-0x0000000180E9D600
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass34_2 // TypeDefIndex: 8077
		{
			// Fields
			public ObjectConstructor<object> createEnumerableWrapper; // 0x10
			public <>c__DisplayClass34_0 CS$<>8__locals2; // 0x18
	
			// Constructors
			public <>c__DisplayClass34_2(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal IEnumerable<KeyValuePair<object, object>> <SetExtensionDataDelegates>b__1(object o); // 0x0000000180E9D600-0x0000000180E9D740
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass64_0 // TypeDefIndex: 8078
		{
			// Fields
			public MethodCall<object, object> shouldSerializeCall; // 0x10
	
			// Constructors
			public <>c__DisplayClass64_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <CreateShouldSerializeTest>b__0(object o); // 0x0000000180E9D740-0x0000000180E9D7E0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass65_0 // TypeDefIndex: 8079
		{
			// Fields
			public Func<object, object> specifiedPropertyGet; // 0x10
	
			// Constructors
			public <>c__DisplayClass65_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <SetIsSpecifiedActions>b__0(object o); // 0x0000000180E9D7E0-0x0000000180E9D870
		}
	
		// Constructors
		public DefaultContractResolver(); // 0x0000000180E8A5D0-0x0000000180E8A680
		[Obsolete] // 0x000000018026FAA0-0x000000018026FAD0
		public DefaultContractResolver(bool shareCache); // 0x0000000180E8A510-0x0000000180E8A5D0
		static DefaultContractResolver(); // 0x0000000180E8A260-0x0000000180E8A510
	
		// Methods
		internal DefaultContractResolverState GetState(); // 0x0000000180E87F50-0x0000000180E87FC0
		public virtual JsonContract ResolveContract(Type type); // 0x0000000180E88EA0-0x0000000180E890E0
		protected virtual List<MemberInfo> GetSerializableMembers(Type objectType); // 0x0000000180E87820-0x0000000180E87F50
		private bool ShouldSerializeEntityMember(MemberInfo memberInfo); // 0x0000000180E8A140-0x0000000180E8A260
		protected virtual JsonObjectContract CreateObjectContract(Type objectType); // 0x0000000180E85670-0x0000000180E85C00
		private MemberInfo GetExtensionDataMemberForType(Type type); // 0x0000000180E875B0-0x0000000180E87760
		private static void SetExtensionDataDelegates(JsonObjectContract contract, MemberInfo member); // 0x0000000180E890E0-0x0000000180E89990
		private ConstructorInfo GetAttributeConstructor(Type objectType); // 0x0000000180E867F0-0x0000000180E86BC0
		private ConstructorInfo GetParameterizedConstructor(Type objectType); // 0x0000000180E87760-0x0000000180E87800
		protected virtual IList<JsonProperty> CreateConstructorParameters(ConstructorInfo constructor, JsonPropertyCollection memberProperties); // 0x0000000180E84820-0x0000000180E84A10
		protected virtual JsonProperty CreatePropertyFromConstructorParameter(JsonProperty matchingMemberProperty, ParameterInfo parameterInfo); // 0x0000000180E860C0-0x0000000180E86370
		protected virtual JsonConverter ResolveContractConverter(Type objectType); // 0x0000000180E88E40-0x0000000180E88EA0
		private Func<object> GetDefaultCreator(Type createdType); // 0x0000000180E87510-0x0000000180E875B0
		private void InitializeContract(JsonContract contract); // 0x0000000180E87FC0-0x0000000180E88250
		private void ResolveCallbackMethods(JsonContract contract, Type t); // 0x0000000180E88BE0-0x0000000180E88E40
		private void GetCallbackMethodsForType(Type type, out List<SerializationCallback> onSerializing, out List<SerializationCallback> onSerialized, out List<SerializationCallback> onDeserializing, out List<SerializationCallback> onDeserialized, out List<SerializationErrorCallback> onError); // 0x0000000180E86BC0-0x0000000180E87270
		private static bool ShouldSkipDeserialized(Type t); // 0x0000000180380950-0x0000000180380960
		private static bool ShouldSkipSerializing(Type t); // 0x0000000180380950-0x0000000180380960
		private List<Type> GetClassHierarchyForType(Type type); // 0x0000000180E87270-0x0000000180E87350
		protected virtual JsonDictionaryContract CreateDictionaryContract(Type objectType); // 0x0000000180E84E60-0x0000000180E852F0
		protected virtual JsonArrayContract CreateArrayContract(Type objectType); // 0x0000000180E844F0-0x0000000180E84820
		protected virtual JsonPrimitiveContract CreatePrimitiveContract(Type objectType); // 0x0000000180E85C00-0x0000000180E85D30
		protected virtual JsonLinqContract CreateLinqContract(Type objectType); // 0x0000000180E85500-0x0000000180E85580
		protected virtual JsonISerializableContract CreateISerializableContract(Type objectType); // 0x0000000180E852F0-0x0000000180E85500
		protected virtual JsonStringContract CreateStringContract(Type objectType); // 0x0000000180E86780-0x0000000180E867F0
		protected virtual JsonContract CreateContract(Type objectType); // 0x0000000180E84A10-0x0000000180E84E60
		internal static bool IsJsonPrimitiveType(Type t); // 0x0000000180E883E0-0x0000000180E88450
		internal static bool IsIConvertible(Type t); // 0x0000000180E88250-0x0000000180E883E0
		internal static bool CanConvertToString(Type type); // 0x0000000180E842C0-0x0000000180E844F0
		private static bool IsValidCallback(MethodInfo method, ParameterInfo[] parameters, Type attributeType, MethodInfo currentCallback, ref Type prevAttributeType); // 0x0000000180E88450-0x0000000180E88BE0
		internal static string GetClrTypeFullName(Type type); // 0x0000000180E87350-0x0000000180E87510
		protected virtual IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization); // 0x0000000180E85D30-0x0000000180E860C0
		protected virtual IValueProvider CreateMemberValueProvider(MemberInfo member); // 0x0000000180E85580-0x0000000180E85670
		protected virtual JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization); // 0x0000000180E86370-0x0000000180E86570
		private void SetPropertySettingsFromAttributes(JsonProperty property, object attributeProvider, string name, Type declaringType, MemberSerialization memberSerialization, out bool allowNonPublicAccess); // 0x0000000180E89C50-0x0000000180E8A140
		private Predicate<object> CreateShouldSerializeTest(MemberInfo member); // 0x0000000180E86570-0x0000000180E86780
		private void SetIsSpecifiedActions(JsonProperty property, MemberInfo member, bool allowNonPublicAccess); // 0x0000000180E89990-0x0000000180E89C50
		protected virtual string ResolvePropertyName(string propertyName); // 0x00000001804EC160-0x00000001804EC170
		protected virtual string ResolveDictionaryKey(string dictionaryKey); // 0x0000000180E87800-0x0000000180E87820
		public string GetResolvedPropertyName(string propertyName); // 0x0000000180E87800-0x0000000180E87820
	}
}
