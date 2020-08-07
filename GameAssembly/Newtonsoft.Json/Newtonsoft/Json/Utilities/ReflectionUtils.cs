/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001801CDDD0-0x00000001801CDE00
	internal static class ReflectionUtils // TypeDefIndex: 8044
	{
		// Fields
		public static readonly Type[] EmptyTypes; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 8045
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<ConstructorInfo, bool> <>9__10_0; // 0x08
			public static Func<MemberInfo, string> <>9__29_0; // 0x10
			public static Func<ParameterInfo, Type> <>9__37_0; // 0x18
			public static Func<FieldInfo, bool> <>9__39_0; // 0x20
	
			// Constructors
			static <>c(); // 0x00000001820D5040-0x00000001820D50A0
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <GetDefaultConstructor>b__10_0(ConstructorInfo c); // 0x00000001820D4CF0-0x00000001820D4D50
			internal string <GetFieldsAndProperties>b__29_0(MemberInfo m); // 0x00000001806D97C0-0x00000001806D97F0
			internal Type <GetMemberInfoFromType>b__37_0(ParameterInfo p); // 0x00000001806D97C0-0x00000001806D97F0
			internal bool <GetChildPrivateFields>b__39_0(FieldInfo f); // 0x00000001820D4CD0-0x00000001820D4CF0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass42_0 // TypeDefIndex: 8046
		{
			// Fields
			public PropertyInfo subTypeProperty; // 0x10
	
			// Constructors
			public <>c__DisplayClass42_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <GetChildPrivateProperties>b__0(PropertyInfo p); // 0x00000001820D4D50-0x00000001820D4DC0
			internal bool <GetChildPrivateProperties>b__1(PropertyInfo p); // 0x00000001820D4DC0-0x00000001820D4E90
			internal bool <GetChildPrivateProperties>b__2(PropertyInfo p); // 0x00000001820D4E90-0x00000001820D5040
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass43_0 // TypeDefIndex: 8047
		{
			// Constructors
			public <>c__DisplayClass43_0(); // 0x0000000180373240-0x0000000180373250
		}
	
		// Constructors
		static ReflectionUtils(); // 0x0000000180C32130-0x0000000180C321A0
	
		// Methods
		public static bool IsPublic(PropertyInfo property); // 0x0000000180C31A70-0x0000000180C31B00
		public static Type GetObjectType(object v); // 0x0000000180C306F0-0x0000000180C30700
		public static string GetTypeName(Type t, FormatterAssemblyStyle assemblyFormat, SerializationBinder binder); // 0x0000000180C30C50-0x0000000180C30E70
		private static string RemoveAssemblyDetails(string fullyQualifiedTypeName); // 0x0000000180C31B90-0x0000000180C31D10
		public static bool HasDefaultConstructor(Type t, bool nonPublic); // 0x0000000180C30E70-0x0000000180C30F10
		public static ConstructorInfo GetDefaultConstructor(Type t); // 0x0000000180C2F080-0x0000000180C2F0E0
		public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic); // 0x0000000180C2EF50-0x0000000180C2F080
		public static bool IsNullable(Type t); // 0x0000000180C31790-0x0000000180C31810
		public static bool IsNullableType(Type t); // 0x0000000180C316E0-0x0000000180C31790
		public static Type EnsureNotNullableType(Type t); // 0x0000000180C2E010-0x0000000180C2E080
		public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition); // 0x0000000180C31500-0x0000000180C31560
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition); // 0x0000000180C30F10-0x0000000180C30F80
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType); // 0x0000000180C30F80-0x0000000180C31190
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition); // 0x0000000180C31280-0x0000000180C313E0
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType); // 0x0000000180C313E0-0x0000000180C31500
		private static bool InheritsGenericDefinitionInternal(Type currentType, Type genericClassDefinition, out Type implementingType); // 0x0000000180C31190-0x0000000180C31280
		public static Type GetCollectionItemType(Type type); // 0x0000000180C2ECB0-0x0000000180C2EF50
		public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType); // 0x0000000180C2F380-0x0000000180C2F620
		public static Type GetMemberUnderlyingType(MemberInfo member); // 0x0000000180C2FFF0-0x0000000180C303A0
		public static bool IsIndexedProperty(MemberInfo member); // 0x0000000180C315D0-0x0000000180C316E0
		public static bool IsIndexedProperty(PropertyInfo property); // 0x0000000180C31560-0x0000000180C315D0
		public static object GetMemberValue(MemberInfo member, object target); // 0x0000000180C303A0-0x0000000180C306F0
		public static void SetMemberValue(MemberInfo member, object target, object value); // 0x0000000180C31D20-0x0000000180C31FC0
		public static bool CanReadMemberValue(MemberInfo member, bool nonPublic); // 0x0000000180C2DCE0-0x0000000180C2DE70
		public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly); // 0x0000000180C2DE70-0x0000000180C2E010
		public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr); // 0x0000000180C2F620-0x0000000180C2FB20
		private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr); // 0x0000000180C31810-0x0000000180C31A70
		public static T GetAttribute<T>(object attributeProvider)
			where T : Attribute;
		public static T GetAttribute<T>(object attributeProvider, bool inherit)
			where T : Attribute;
		public static T[] GetAttributes<T>(object attributeProvider, bool inherit)
			where T : Attribute;
		public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit); // 0x0000000180C2E140-0x0000000180C2E750
		public static void SplitFullyQualifiedTypeName(string fullyQualifiedTypeName, out string typeName, out string assemblyName); // 0x0000000180C31FC0-0x0000000180C32130
		private static int? GetAssemblyDelimiterIndex(string fullyQualifiedTypeName); // 0x0000000180C2E080-0x0000000180C2E140
		public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo); // 0x0000000180C2FD70-0x0000000180C2FFF0
		public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr); // 0x0000000180C2FB20-0x0000000180C2FD70
		private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type targetType, BindingFlags bindingAttr); // 0x0000000180C2E7E0-0x0000000180C2E990
		public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr); // 0x0000000180C30700-0x0000000180C30C50
		private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type targetType, BindingFlags bindingAttr); // 0x0000000180C2E990-0x0000000180C2ECB0
		public static object GetDefaultValue(Type type); // 0x0000000180C2F0E0-0x0000000180C2F380
	
		// Extension methods
		public static bool IsVirtual(this PropertyInfo propertyInfo); // 0x0000000180C31B00-0x0000000180C31B90
		public static MethodInfo GetBaseDefinition(this PropertyInfo propertyInfo); // 0x0000000180C2E750-0x0000000180C2E7E0
		public static BindingFlags RemoveFlag(this BindingFlags bindingAttr, BindingFlags flag); // 0x0000000180C31D10-0x0000000180C31D20
	}
}
