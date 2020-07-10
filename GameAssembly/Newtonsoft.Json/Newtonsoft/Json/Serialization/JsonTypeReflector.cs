/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;
using Newtonsoft.Json.Utilities;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal static class JsonTypeReflector // TypeDefIndex: 7943
	{
		// Fields
		private static bool? _dynamicCodeGeneration; // 0x00
		private static bool? _fullyTrusted; // 0x02
		private static readonly ThreadSafeStore<Type, Func<object[], JsonConverter>> JsonConverterCreatorCache; // 0x08
		private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache; // 0x10
		private static ReflectionObject _metadataTypeAttributeReflectionObject; // 0x18
	
		// Properties
		public static bool DynamicCodeGeneration { get; } // 0x0000000180593460-0x00000001805936C0 
		public static bool FullyTrusted { get; } // 0x00000001805936C0-0x0000000180593840 
		public static ReflectionDelegateFactory ReflectionDelegateFactory { get; } // 0x0000000180593840-0x0000000180593940 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass18_0 // TypeDefIndex: 7944
		{
			// Fields
			public Type converterType; // 0x10
			public Func<object> defaultConstructor; // 0x18
	
			// Constructors
			public <>c__DisplayClass18_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal JsonConverter <GetJsonConverterCreator>b__0(object[] parameters); // 0x000000018059CBB0-0x000000018059CF90
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 7945
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<object, Type> <>9__18_1; // 0x08
	
			// Constructors
			static <>c(); // 0x000000018059D1A0-0x000000018059D200
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal Type <GetJsonConverterCreator>b__18_1(object param); // 0x000000018059C990-0x000000018059C9C0
		}
	
		// Constructors
		static JsonTypeReflector(); // 0x0000000180593370-0x0000000180593460
	
		// Methods
		public static T GetCachedAttribute<T>(object attributeProvider)
			where T : Attribute;
		public static DataContractAttribute GetDataContractAttribute(Type type); // 0x0000000180592C60-0x0000000180592CE0
		public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo); // 0x0000000180592CE0-0x0000000180592F70
		public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute); // 0x0000000180593180-0x0000000180593310
		public static JsonConverter GetJsonConverter(object attributeProvider); // 0x00000001805930B0-0x0000000180593180
		public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] converterArgs); // 0x00000001805928B0-0x0000000180592960
		private static Func<object[], JsonConverter> GetJsonConverterCreator(Type converterType); // 0x0000000180592F70-0x00000001805930B0
		public static TypeConverter GetTypeConverter(Type type); // 0x0000000180593310-0x0000000180593370
		private static Type GetAssociatedMetadataType(Type type); // 0x0000000180592BE0-0x0000000180592C60
		private static Type GetAssociateMetadataTypeFromAttribute(Type type); // 0x0000000180592960-0x0000000180592BE0
		private static T GetAttribute<T>(Type type)
			where T : Attribute;
		private static T GetAttribute<T>(MemberInfo memberInfo)
			where T : Attribute;
		public static T GetAttribute<T>(object provider)
			where T : Attribute;
	}
}
