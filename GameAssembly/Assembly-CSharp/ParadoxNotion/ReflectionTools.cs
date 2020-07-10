/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion
{
	public static class ReflectionTools // TypeDefIndex: 14683
	{
		// Fields
		public const BindingFlags FLAGS_ALL = BindingFlags.Default | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy; // Metadata: 0x00784718
		public const BindingFlags FLAGS_ALL_DECLARED = BindingFlags.Default | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic; // Metadata: 0x0078471C
		private static Assembly[] _loadedAssemblies; // 0x00
		private static Dictionary<string, Type> typeMap; // 0x08
		private static Type[] _allTypes; // 0x10
		private static Dictionary<Type, Type[]> _subTypesMap; // 0x18
		private static object[] _tempArgs; // 0x20
		public static readonly Dictionary<string, string> op_FriendlyNamesLong; // 0x28
		public static readonly Dictionary<string, string> op_FriendlyNamesShort; // 0x30
		public static readonly Dictionary<string, string> op_CSharpAliases; // 0x38
		public const string METHOD_SPECIAL_NAME_GET = "get_"; // Metadata: 0x00784720
		public const string METHOD_SPECIAL_NAME_SET = "set_"; // Metadata: 0x00784728
		public const string METHOD_SPECIAL_NAME_ADD = "add_"; // Metadata: 0x00784730
		public const string METHOD_SPECIAL_NAME_REMOVE = "remove_"; // Metadata: 0x00784738
		public const string METHOD_SPECIAL_NAME_OP = "op_"; // Metadata: 0x00784743
		private static Dictionary<MethodBase, string> cacheSignatures; // 0x40
		private static Dictionary<Type, ConstructorInfo[]> _typeConstructors; // 0x48
		private static Dictionary<Type, MethodInfo[]> _typeMethods; // 0x50
		private static Dictionary<Type, FieldInfo[]> _typeFields; // 0x58
		private static Dictionary<Type, PropertyInfo[]> _typeProperties; // 0x60
		private static Dictionary<Type, EventInfo[]> _typeEvents; // 0x68
		private static Dictionary<Type, object[]> _typeAttributes; // 0x70
		private static Dictionary<MemberInfo, object[]> _memberAttributes; // 0x78
		private static Dictionary<Type, MethodInfo[]> _typeExtensions; // 0x80
	
		// Properties
		private static Assembly[] loadedAssemblies { get; } // 0x000000018138A530-0x000000018138A610 
	
		// Nested types
		public enum MethodType // TypeDefIndex: 14684
		{
			Normal = 0,
			PropertyAccessor = 1,
			Event = 2,
			Operator = 3
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass11_0 // TypeDefIndex: 14685
		{
			// Fields
			public string typeName; // 0x10
			public Func<string, bool> <>9__0; // 0x18
	
			// Constructors
			public <>c__DisplayClass11_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <TryResolveDeserializeFromAttribute>b__0(string n); // 0x0000000180FF6910-0x0000000180FF6930
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass14_0 // TypeDefIndex: 14686
		{
			// Fields
			public bool includeObsolete; // 0x10
			public Func<Type, bool> <>9__2; // 0x18
	
			// Constructors
			public <>c__DisplayClass14_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <GetAllTypes>b__2(Type t); // 0x000000018138A780-0x000000018138A800
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 14687
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<Type, string> <>9__14_0; // 0x08
			public static Func<Type, string> <>9__14_1; // 0x10
			public static Func<ParameterInfo, Type> <>9__83_0; // 0x18
			public static Func<ParameterInfo, Type> <>9__90_0; // 0x20
			public static Func<ConstructorInfo, bool> <>9__105_0; // 0x28
	
			// Constructors
			static <>c(); // 0x000000018138A800-0x000000018138A860
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal string <GetAllTypes>b__14_0(Type t); // 0x000000018138A690-0x000000018138A6F0
			internal string <GetAllTypes>b__14_1(Type t); // 0x000000018138A6F0-0x000000018138A720
			internal Type <RTCreateDelegate>b__83_0(ParameterInfo p); // 0x0000000180DF2B50-0x0000000180DF2B80
			internal Type <GetBaseDefinition>b__90_0(ParameterInfo p); // 0x0000000180DF2B50-0x0000000180DF2B80
			internal bool <IsAllowedByGenericArgument>b__105_0(ConstructorInfo info); // 0x000000018138A720-0x000000018138A780
		}
	
		// Constructors
		static ReflectionTools(); // 0x0000000181389A70-0x000000018138A530
	
		// Methods
		public static Type GetType(string typeFullName); // 0x00000001813860F0-0x0000000181386150
		public static Type GetType(string typeFullName, Type fallbackAssignable); // 0x0000000181386150-0x00000001813861C0
		public static Type GetType(string typeFullName, bool fallbackNoNamespace = false /* Metadata: 0x00784714 */, Type fallbackAssignable = null); // 0x0000000181385AD0-0x00000001813860F0
		private static Type GetTypeDirect(string typeFullName); // 0x0000000181385900-0x0000000181385AD0
		private static Type TryResolveGenericType(string typeFullName, bool fallbackNoNamespace = false /* Metadata: 0x00784715 */, Type fallbackAssignable = null); // 0x0000000181389290-0x0000000181389810
		private static Type TryResolveDeserializeFromAttribute(string typeName); // 0x0000000181389100-0x0000000181389290
		private static Type TryResolveWithoutNamespace(string typeName, Type fallbackAssignable = null); // 0x0000000181389810-0x0000000181389A70
		public static Type[] GetAllTypes(bool includeObsolete); // 0x0000000181384550-0x0000000181384960
		public static Type[] GetImplementationsOf(Type baseType); // 0x0000000181385560-0x00000001813857E0
		public static object[] SingleTempArgsArray(object arg); // 0x0000000181389030-0x0000000181389100
		public static Type[] RTGetEmptyTypes(); // 0x0000000181387970-0x00000001813879D0
		public static Delegate ConvertDelegate(Delegate originalDelegate, Type targetDelegateType); // 0x0000000181383920-0x0000000181383960
		public static bool CanConvert(Type fromType, Type toType, out UnaryExpression exp); // 0x0000000181383870-0x0000000181383920
	
		// Extension methods
		public static MethodType GetMethodSpecialType(this MethodBase method); // 0x00000001813857E0-0x0000000181385900
		public static string FriendlyName(this Type t, bool compileSafe = false /* Metadata: 0x00784716 */); // 0x0000000181383AC0-0x0000000181383EF0
		public static string FriendlyName(this MemberInfo info); // 0x0000000181383EF0-0x0000000181384090
		public static string FriendlyName(this MethodBase method); // 0x0000000181383A60-0x0000000181383AC0
		public static string FriendlyName(this MethodBase method, out MethodType specialNameType); // 0x0000000181384090-0x00000001813843F0
		public static string SignatureName(this MethodBase method); // 0x0000000181388B20-0x0000000181389030
		public static Type RTReflectedOrDeclaredType(this MemberInfo member); // 0x0000000181388980-0x0000000181388A30
		public static bool RTIsAssignableFrom(this Type type, Type other); // 0x0000000180DB9800-0x0000000180DB9830
		public static bool RTIsAssignableTo(this Type type, Type other); // 0x00000001813887C0-0x0000000181388840
		public static bool RTIsAbstract(this Type type); // 0x0000000180A428B0-0x0000000180A428D0
		public static bool RTIsValueType(this Type type); // 0x000000018060B510-0x000000018060B530
		public static bool RTIsArray(this Type type); // 0x0000000180A51AD0-0x0000000180A51AF0
		public static bool RTIsInterface(this Type type); // 0x0000000180DF2A70-0x0000000180DF2A90
		public static bool RTIsSubclassOf(this Type type, Type other); // 0x0000000181388920-0x0000000181388950
		public static bool RTIsGenericParameter(this Type type); // 0x00000001813888F0-0x0000000181388920
		public static bool RTIsGenericType(this Type type); // 0x0000000180DF2A40-0x0000000180DF2A70
		public static MethodInfo RTGetGetMethod(this PropertyInfo prop); // 0x000000018060B000-0x000000018060B020
		public static MethodInfo RTGetSetMethod(this PropertyInfo prop); // 0x00000001813887A0-0x00000001813887C0
		public static MethodInfo RTGetDelegateMethodInfo(this Delegate del); // 0x0000000181387680-0x00000001813876A0
		public static Type RTMakeGenericType(this Type type, params /* 0x00000001800B36B0-0x00000001800B36C0 */ Type[] typeArgs); // 0x0000000181388950-0x0000000181388980
		public static Type[] RTGetGenericArguments(this Type type); // 0x000000018060AFD0-0x000000018060B000
		public static Type RTGetElementType(this Type type); // 0x00000001813878E0-0x0000000181387970
		public static bool RTIsByRef(this Type type); // 0x0000000181388840-0x00000001813888C0
		public static object CreateObject(this Type type); // 0x00000001813839F0-0x0000000181383A60
		public static object CreateObjectUninitialized(this Type type); // 0x0000000181383960-0x00000001813839F0
		public static ConstructorInfo RTGetDefaultConstructor(this Type type); // 0x0000000181387580-0x0000000181387680
		public static ConstructorInfo RTGetConstructor(this Type type, Type[] paramTypes); // 0x0000000181387280-0x0000000181387460
		public static MethodInfo RTGetMethod(this Type type, string name); // 0x0000000181388240-0x0000000181388350
		public static MethodInfo RTGetMethod(this Type type, string name, Type[] paramTypes); // 0x0000000181388030-0x0000000181388240
		public static FieldInfo RTGetField(this Type type, string name); // 0x0000000181387D00-0x0000000181387F10
		public static PropertyInfo RTGetProperty(this Type type, string name); // 0x0000000181388590-0x00000001813887A0
		public static EventInfo RTGetEvent(this Type type, string name); // 0x00000001813879D0-0x0000000181387BE0
		public static ConstructorInfo[] RTGetConstructors(this Type type); // 0x0000000181387460-0x0000000181387580
		public static MethodInfo[] RTGetMethods(this Type type); // 0x0000000181388350-0x0000000181388470
		public static FieldInfo[] RTGetFields(this Type type); // 0x0000000181387F10-0x0000000181388030
		public static PropertyInfo[] RTGetProperties(this Type type); // 0x0000000181388470-0x0000000181388590
		public static EventInfo[] RTGetEvents(this Type type); // 0x0000000181387BE0-0x0000000181387D00
		public static bool RTIsDefined<T>(this Type type, bool inherited)
			where T : Attribute;
		public static bool RTIsDefined(this Type type, Type attributeType, bool inherited); // 0x00000001813888C0-0x00000001813888F0
		public static bool RTIsDefined<T>(this MemberInfo member, bool inherited)
			where T : Attribute;
		public static bool RTIsDefined(this MemberInfo member, Type attributeType, bool inherited); // 0x00000001813888C0-0x00000001813888F0
		public static T RTGetAttribute<T>(this Type type, bool inherited)
			where T : Attribute;
		public static T RTGetAttribute<T>(this MemberInfo member, bool inherited)
			where T : Attribute;
		public static T[] RTGetAttributesRecursive<T>(this Type type)
			where T : Attribute;
		public static ParameterInfo[] RTGetDelegateTypeParameters(this Type delegateType); // 0x00000001813876A0-0x00000001813878E0
		public static T RTCreateDelegate<T>(this MethodInfo method, object instance);
		public static Delegate RTCreateDelegate(this MethodInfo method, Type type, object instance); // 0x0000000181387080-0x0000000181387280
		public static bool IsReadOnly(this FieldInfo field); // 0x0000000181386FE0-0x0000000181387020
		public static bool IsConstant(this FieldInfo field); // 0x0000000181386680-0x0000000181386700
		public static bool IsStatic(this EventInfo info); // 0x0000000181387020-0x0000000181387080
		public static bool IsParams(this ParameterInfo parameter, ParameterInfo[] parameters); // 0x0000000181386D90-0x0000000181386E60
		public static bool IsObsolete(this MemberInfo member, bool inherited = true /* Metadata: 0x00784717 */); // 0x0000000181386910-0x0000000181386D90
		public static PropertyInfo GetBaseDefinition(this PropertyInfo propertyInfo); // 0x0000000181384960-0x0000000181384BC0
		public static FieldInfo GetBaseDefinition(this FieldInfo fieldInfo); // 0x0000000181384BC0-0x0000000181384C60
		public static MethodInfo[] GetExtensionMethods(this Type targetType); // 0x0000000181384E60-0x0000000181385260
		public static bool IsExtensionMethod(this MethodInfo method); // 0x0000000181386870-0x00000001813868D0
		public static bool IsPropertyAccessor(this MethodInfo method); // 0x0000000181386E60-0x0000000181386FE0
		public static bool IsIndexerProperty(this PropertyInfo property); // 0x00000001813868D0-0x0000000181386910
		public static bool IsAutoProperty(this PropertyInfo property); // 0x0000000181386570-0x0000000181386680
		public static PropertyInfo GetAccessorProperty(this MethodInfo method); // 0x00000001813843F0-0x0000000181384550
		public static bool IsEnumerableCollection(this Type type); // 0x0000000181386700-0x0000000181386870
		public static Type GetEnumerableElementType(this Type type); // 0x0000000181384C60-0x0000000181384E60
		public static Type GetFirstGenericParameterConstraintType(this Type type); // 0x00000001813853C0-0x0000000181385560
		public static Type GetFirstGenericParameterConstraintType(this MethodInfo method); // 0x0000000181385260-0x00000001813853C0
		public static bool CanBeMadeGenericWith(this Type def, Type type); // 0x0000000181383740-0x0000000181383870
		public static bool CanBeMadeGenericWith(this MethodInfo def, Type type); // 0x0000000181383640-0x0000000181383740
		public static bool IsAllowedByGenericArgument(this Type type, Type genericArgument); // 0x00000001813861C0-0x0000000181386570
		public static Array Resize(this Array array, int newSize); // 0x0000000181388A30-0x0000000181388B20
	}
}
