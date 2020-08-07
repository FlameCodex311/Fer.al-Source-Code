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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Serialization
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal static class JsonTypeReflector // TypeDefIndex: 8109
	{
		// Fields
		private static bool? _dynamicCodeGeneration; // 0x00
		private static bool? _fullyTrusted; // 0x02
		private static readonly ThreadSafeStore<Type, Func<object[], JsonConverter>> JsonConverterCreatorCache; // 0x08
		private static readonly ThreadSafeStore<Type, Type> AssociatedMetadataTypesCache; // 0x10
		private static ReflectionObject _metadataTypeAttributeReflectionObject; // 0x18
	
		// Properties
		public static bool DynamicCodeGeneration { get; } // 0x0000000180C2B610-0x0000000180C2B870 
		public static bool FullyTrusted { get; } // 0x0000000180C2B870-0x0000000180C2B9F0 
		public static ReflectionDelegateFactory ReflectionDelegateFactory { get; } // 0x0000000180C2B9F0-0x0000000180C2BAF0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass18_0 // TypeDefIndex: 8110
		{
			// Fields
			public Type converterType; // 0x10
			public Func<object> defaultConstructor; // 0x18
	
			// Constructors
			public <>c__DisplayClass18_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal JsonConverter <GetJsonConverterCreator>b__0(object[] parameters); // 0x0000000180C34DD0-0x0000000180C351B0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 8111
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<object, Type> <>9__18_1; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180C353B0-0x0000000180C44930
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal Type <GetJsonConverterCreator>b__18_1(object param); // 0x0000000180C34BF0-0x0000000180C34C10
		}
	
		// Constructors
		static JsonTypeReflector(); // 0x0000000180C2B520-0x0000000180C2B610
	
		// Methods
		public static T GetCachedAttribute<T>(object attributeProvider)
			where T : Attribute;
		public static DataContractAttribute GetDataContractAttribute(Type type); // 0x0000000180C2AE20-0x0000000180C2AEA0
		public static DataMemberAttribute GetDataMemberAttribute(MemberInfo memberInfo); // 0x0000000180C2AEA0-0x0000000180C2B130
		public static MemberSerialization GetObjectMemberSerialization(Type objectType, bool ignoreSerializableAttribute); // 0x0000000180C2B330-0x0000000180C2B4C0
		public static JsonConverter GetJsonConverter(object attributeProvider); // 0x0000000180C2B260-0x0000000180C2B330
		public static JsonConverter CreateJsonConverterInstance(Type converterType, object[] converterArgs); // 0x0000000180C2AA90-0x0000000180C2AB30
		private static Func<object[], JsonConverter> GetJsonConverterCreator(Type converterType); // 0x0000000180C2B130-0x0000000180C2B260
		public static TypeConverter GetTypeConverter(Type type); // 0x0000000180C2B4C0-0x0000000180C2B520
		private static Type GetAssociatedMetadataType(Type type); // 0x0000000180C2ADA0-0x0000000180C2AE20
		private static Type GetAssociateMetadataTypeFromAttribute(Type type); // 0x0000000180C2AB30-0x0000000180C2ADA0
		private static T GetAttribute<T>(Type type)
			where T : Attribute;
		private static T GetAttribute<T>(MemberInfo memberInfo)
			where T : Attribute;
		public static T GetAttribute<T>(object provider)
			where T : Attribute;
	}
}
