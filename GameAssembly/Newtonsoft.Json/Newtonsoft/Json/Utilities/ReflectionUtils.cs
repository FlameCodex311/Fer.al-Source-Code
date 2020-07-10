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

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001800B4050-0x00000001800B4080
	internal static class ReflectionUtils // TypeDefIndex: 7878
	{
		// Fields
		public static readonly Type[] EmptyTypes; // 0x00
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 7879
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<ConstructorInfo, bool> <>9__10_0; // 0x08
			public static Func<MemberInfo, string> <>9__29_0; // 0x10
			public static Func<ParameterInfo, Type> <>9__37_0; // 0x18
			public static Func<FieldInfo, bool> <>9__39_0; // 0x20
	
			// Constructors
			static <>c(); // 0x0000000180DF2E80-0x0000000180DF2EE0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <GetDefaultConstructor>b__10_0(ConstructorInfo c); // 0x0000000180DF2AF0-0x0000000180DF2B50
			internal string <GetFieldsAndProperties>b__29_0(MemberInfo m); // 0x0000000180DF2B50-0x0000000180DF2B80
			internal Type <GetMemberInfoFromType>b__37_0(ParameterInfo p); // 0x0000000180DF2B50-0x0000000180DF2B80
			internal bool <GetChildPrivateFields>b__39_0(FieldInfo f); // 0x0000000180DF2AC0-0x0000000180DF2AF0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass42_0 // TypeDefIndex: 7880
		{
			// Fields
			public PropertyInfo subTypeProperty; // 0x10
	
			// Constructors
			public <>c__DisplayClass42_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <GetChildPrivateProperties>b__0(PropertyInfo p); // 0x0000000180DF2B80-0x0000000180DF2BF0
			internal bool <GetChildPrivateProperties>b__1(PropertyInfo p); // 0x0000000180DF2BF0-0x0000000180DF2CC0
			internal bool <GetChildPrivateProperties>b__2(PropertyInfo p); // 0x0000000180DF2CC0-0x0000000180DF2E80
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass43_0 // TypeDefIndex: 7881
		{
			// Constructors
			public <>c__DisplayClass43_0(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		// Constructors
		static ReflectionUtils(); // 0x0000000180599F20-0x0000000180599F90
	
		// Methods
		public static bool IsPublic(PropertyInfo property); // 0x0000000180599840-0x00000001805998D0
		public static Type GetObjectType(object v); // 0x00000001805985C0-0x00000001805985D0
		public static string GetTypeName(Type t, FormatterAssemblyStyle assemblyFormat, SerializationBinder binder); // 0x0000000180598B40-0x0000000180598C00
		private static string RemoveAssemblyDetails(string fullyQualifiedTypeName); // 0x0000000180599960-0x0000000180599AF0
		public static bool HasDefaultConstructor(Type t, bool nonPublic); // 0x0000000180598C00-0x0000000180598CA0
		public static ConstructorInfo GetDefaultConstructor(Type t); // 0x0000000180596FB0-0x0000000180597010
		public static ConstructorInfo GetDefaultConstructor(Type t, bool nonPublic); // 0x0000000180596E80-0x0000000180596FB0
		public static bool IsNullable(Type t); // 0x0000000180599550-0x00000001805995D0
		public static bool IsNullableType(Type t); // 0x0000000180599490-0x0000000180599550
		public static Type EnsureNotNullableType(Type t); // 0x0000000180595F20-0x0000000180595F90
		public static bool IsGenericDefinition(Type type, Type genericInterfaceDefinition); // 0x00000001805992B0-0x0000000180599310
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition); // 0x0000000180598CA0-0x0000000180598D10
		public static bool ImplementsGenericDefinition(Type type, Type genericInterfaceDefinition, out Type implementingType); // 0x0000000180598D10-0x0000000180598F30
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition); // 0x0000000180599030-0x0000000180599190
		public static bool InheritsGenericDefinition(Type type, Type genericClassDefinition, out Type implementingType); // 0x0000000180599190-0x00000001805992B0
		private static bool InheritsGenericDefinitionInternal(Type currentType, Type genericClassDefinition, out Type implementingType); // 0x0000000180598F30-0x0000000180599030
		public static Type GetCollectionItemType(Type type); // 0x0000000180596BD0-0x0000000180596E80
		public static void GetDictionaryKeyValueTypes(Type dictionaryType, out Type keyType, out Type valueType); // 0x00000001805972B0-0x0000000180597560
		public static Type GetMemberUnderlyingType(MemberInfo member); // 0x0000000180597EB0-0x0000000180598260
		public static bool IsIndexedProperty(MemberInfo member); // 0x0000000180599380-0x0000000180599490
		public static bool IsIndexedProperty(PropertyInfo property); // 0x0000000180599310-0x0000000180599380
		public static object GetMemberValue(MemberInfo member, object target); // 0x0000000180598260-0x00000001805985C0
		public static void SetMemberValue(MemberInfo member, object target, object value); // 0x0000000180599B00-0x0000000180599DB0
		public static bool CanReadMemberValue(MemberInfo member, bool nonPublic); // 0x0000000180595BD0-0x0000000180595D70
		public static bool CanSetMemberValue(MemberInfo member, bool nonPublic, bool canSetReadOnly); // 0x0000000180595D70-0x0000000180595F20
		public static List<MemberInfo> GetFieldsAndProperties(Type type, BindingFlags bindingAttr); // 0x0000000180597560-0x0000000180597B30
		private static bool IsOverridenGenericMember(MemberInfo memberInfo, BindingFlags bindingAttr); // 0x00000001805995D0-0x0000000180599840
		public static T GetAttribute<T>(object attributeProvider)
			where T : Attribute;
		public static T GetAttribute<T>(object attributeProvider, bool inherit)
			where T : Attribute;
		public static T[] GetAttributes<T>(object attributeProvider, bool inherit)
			where T : Attribute;
		public static Attribute[] GetAttributes(object attributeProvider, Type attributeType, bool inherit); // 0x0000000180596050-0x0000000180596660
		public static void SplitFullyQualifiedTypeName(string fullyQualifiedTypeName, out string typeName, out string assemblyName); // 0x0000000180599DB0-0x0000000180599F20
		private static int? GetAssemblyDelimiterIndex(string fullyQualifiedTypeName); // 0x0000000180595F90-0x0000000180596050
		public static MemberInfo GetMemberInfoFromType(Type targetType, MemberInfo memberInfo); // 0x0000000180597C20-0x0000000180597EB0
		public static IEnumerable<FieldInfo> GetFields(Type targetType, BindingFlags bindingAttr); // 0x0000000180597B30-0x0000000180597C20
		private static void GetChildPrivateFields(IList<MemberInfo> initialFields, Type targetType, BindingFlags bindingAttr); // 0x00000001805966F0-0x00000001805968A0
		public static IEnumerable<PropertyInfo> GetProperties(Type targetType, BindingFlags bindingAttr); // 0x00000001805985D0-0x0000000180598B40
		private static void GetChildPrivateProperties(IList<PropertyInfo> initialProperties, Type targetType, BindingFlags bindingAttr); // 0x00000001805968A0-0x0000000180596BD0
		public static object GetDefaultValue(Type type); // 0x0000000180597010-0x00000001805972B0
	
		// Extension methods
		public static bool IsVirtual(this PropertyInfo propertyInfo); // 0x00000001805998D0-0x0000000180599960
		public static MethodInfo GetBaseDefinition(this PropertyInfo propertyInfo); // 0x0000000180596660-0x00000001805966F0
		public static BindingFlags RemoveFlag(this BindingFlags bindingAttr, BindingFlags flag); // 0x0000000180599AF0-0x0000000180599B00
	}
}
