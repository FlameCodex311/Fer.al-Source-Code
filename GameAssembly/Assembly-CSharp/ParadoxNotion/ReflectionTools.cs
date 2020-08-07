/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion
{
	public static class ReflectionTools // TypeDefIndex: 15828
	{
		// Fields
		public const BindingFlags FLAGS_ALL = BindingFlags.Default | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy; // Metadata: 0x007BB5A4
		public const BindingFlags FLAGS_ALL_DECLARED = BindingFlags.Default | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic; // Metadata: 0x007BB5A8
		private static Assembly[] _loadedAssemblies; // 0x00
		private static Type[] _allTypes; // 0x08
		private static object[] _tempArgs; // 0x10
		private static Dictionary<string, Type> _typesMap; // 0x18
		private static Dictionary<Type, Type[]> _subTypesMap; // 0x20
		private static Dictionary<MethodBase, MethodType> _methodSpecialType; // 0x28
		private static Dictionary<Type, string> _typeFriendlyName; // 0x30
		private static Dictionary<Type, string> _typeFriendlyNameCompileSafe; // 0x38
		private static Dictionary<MethodBase, string> _methodSignatures; // 0x40
		private static Dictionary<Type, ConstructorInfo[]> _typeConstructors; // 0x48
		private static Dictionary<Type, MethodInfo[]> _typeMethods; // 0x50
		private static Dictionary<Type, FieldInfo[]> _typeFields; // 0x58
		private static Dictionary<Type, PropertyInfo[]> _typeProperties; // 0x60
		private static Dictionary<Type, EventInfo[]> _typeEvents; // 0x68
		private static Dictionary<Type, object[]> _typeAttributes; // 0x70
		private static Dictionary<MemberInfo, object[]> _memberAttributes; // 0x78
		private static Dictionary<MemberInfo, bool> _obsoleteCache; // 0x80
		private static Dictionary<Type, MethodInfo[]> _typeExtensions; // 0x88
		private static Dictionary<Type, Type[]> _genericArgsTypeCache; // 0x90
		private static Dictionary<MethodInfo, Type[]> _genericArgsMathodCache; // 0x98
		public static readonly Dictionary<string, string> op_FriendlyNamesLong; // 0xA0
		public static readonly Dictionary<string, string> op_FriendlyNamesShort; // 0xA8
		public static readonly Dictionary<string, string> op_CSharpAliases; // 0xB0
		public const string METHOD_SPECIAL_NAME_GET = "get_"; // Metadata: 0x007BB5AC
		public const string METHOD_SPECIAL_NAME_SET = "set_"; // Metadata: 0x007BB5B4
		public const string METHOD_SPECIAL_NAME_ADD = "add_"; // Metadata: 0x007BB5BC
		public const string METHOD_SPECIAL_NAME_REMOVE = "remove_"; // Metadata: 0x007BB5C4
		public const string METHOD_SPECIAL_NAME_OP = "op_"; // Metadata: 0x007BB5CF
	
		// Properties
		private static Assembly[] loadedAssemblies { get; } // 0x00000001806D9560-0x00000001806D9640 
	
		// Nested types
		public enum MethodType // TypeDefIndex: 15829
		{
			Normal = 0,
			PropertyAccessor = 1,
			Event = 2,
			Operator = 3
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass32_0 // TypeDefIndex: 15830
		{
			// Fields
			public bool includeObsolete; // 0x10
			public Func<Type, bool> <>9__2; // 0x18
	
			// Constructors
			public <>c__DisplayClass32_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <GetAllTypes>b__2(Type t); // 0x00000001806D9920-0x00000001806D99A0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 15831
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<Type, string> <>9__32_0; // 0x08
			public static Func<Type, string> <>9__32_1; // 0x10
			public static Func<ParameterInfo, Type> <>9__99_0; // 0x18
			public static Func<ParameterInfo, Type> <>9__107_0; // 0x20
			public static Func<ConstructorInfo, bool> <>9__122_0; // 0x28
	
			// Constructors
			static <>c(); // 0x00000001806D9AC0-0x00000001806D9B20
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal string <GetAllTypes>b__32_0(Type t); // 0x00000001806D9730-0x00000001806D9760
			internal string <GetAllTypes>b__32_1(Type t); // 0x00000001806D9760-0x00000001806D97C0
			internal Type <RTCreateDelegate>b__99_0(ParameterInfo p); // 0x00000001806D97C0-0x00000001806D97F0
			internal Type <GetBaseDefinition>b__107_0(ParameterInfo p); // 0x00000001806D97C0-0x00000001806D97F0
			internal bool <IsAllowedByGenericArgument>b__122_0(ConstructorInfo info); // 0x00000001806D97F0-0x00000001806D9850
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <RTGetAttributesRecursive>d__96<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 15832
			where T : Attribute
		{
			// Fields
			private int <>1__state;
			private T <>2__current;
			private int <>l__initialThreadId;
			private Type type;
			public Type <>3__type;
			private Type <current>5__2;
	
			// Properties
			T IEnumerator<T>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <RTGetAttributesRecursive>d__96(int <>1__state);
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator<T> IEnumerable<T>.GetEnumerator();
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			IEnumerator IEnumerable.GetEnumerator();
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass126_0<T, TResult> // TypeDefIndex: 15833
		{
			// Fields
			public FieldInfo info;
	
			// Constructors
			public <>c__DisplayClass126_0();
	
			// Methods
			internal TResult <GetFieldGetter>b__0(T instance);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass127_0<T, TValue> // TypeDefIndex: 15834
		{
			// Fields
			public FieldInfo info;
	
			// Constructors
			public <>c__DisplayClass127_0();
	
			// Methods
			internal void <GetFieldSetter>b__0(T instance, TValue value);
		}
	
		// Constructors
		static ReflectionTools(); // 0x00000001806D8970-0x00000001806D9560
	
		// Methods
		public static void FlushMem(); // 0x00000001806D1100-0x00000001806D14D0
		public static Type GetType(string typeFullName); // 0x00000001806D41B0-0x00000001806D4210
		public static Type GetType(string typeFullName, Type fallbackAssignable); // 0x00000001806D4210-0x00000001806D4280
		public static Type GetType(string typeFullName, bool fallbackNoNamespace = false /* Metadata: 0x007BB59F */, Type fallbackAssignable = null); // 0x00000001806D3C30-0x00000001806D41B0
		private static Type GetTypeDirect(string typeFullName); // 0x00000001806D3A70-0x00000001806D3C30
		private static Type TryResolveGenericType(string typeFullName, bool fallbackNoNamespace = false /* Metadata: 0x007BB5A0 */, Type fallbackAssignable = null); // 0x00000001806D81E0-0x00000001806D8720
		private static Type TryResolveDeserializeFromAttribute(string typeName); // 0x00000001806D8070-0x00000001806D81E0
		private static Type TryResolveWithoutNamespace(string typeName, Type fallbackAssignable = null); // 0x00000001806D8720-0x00000001806D8970
		public static Type[] GetAllTypes(bool includeObsolete); // 0x00000001806D23D0-0x00000001806D27D0
		public static Type[] GetImplementationsOf(Type baseType); // 0x00000001806D3460-0x00000001806D36D0
		public static object[] SingleTempArgsArray(object arg); // 0x00000001806D7FA0-0x00000001806D8070
		public static string FriendlyTypeName(string fullName); // 0x00000001806D2020-0x00000001806D2130
		public static Type[] RTGetEmptyTypes(); // 0x00000001806D61F0-0x00000001806D6250
		private static bool MemberResolvedFromDeserializeAttribute(MemberInfo member, string targetName); // 0x00000001806D50F0-0x00000001806D5180
		public static Delegate ConvertDelegate(Delegate originalDelegate, Type targetDelegateType); // 0x00000001806D0960-0x00000001806D09A0
		public static bool CanConvert(Type fromType, Type toType, out UnaryExpression exp); // 0x00000001806D08B0-0x00000001806D0960
		public static void DigFields(object root, Predicate<FieldInfo> move, Action<object> push, Action<object> pop); // 0x00000001806D0AA0-0x00000001806D1100
		public static Func<T, TResult> GetFieldGetter<T, TResult>(FieldInfo info);
		public static Action<T, TValue> GetFieldSetter<T, TValue>(FieldInfo info);
	
		// Extension methods
		public static MethodType GetMethodSpecialType(this MethodBase method); // 0x00000001806D36D0-0x00000001806D39C0
		public static string FriendlyName(this Type t, bool compileSafe = false /* Metadata: 0x007BB5A1 */); // 0x00000001806D1530-0x00000001806D1B20
		public static string FriendlyName(this MemberInfo info); // 0x00000001806D1B20-0x00000001806D1CC0
		public static string FriendlyName(this MethodBase method); // 0x00000001806D14D0-0x00000001806D1530
		public static string FriendlyName(this MethodBase method, out MethodType specialNameType); // 0x00000001806D1CC0-0x00000001806D2020
		public static string SignatureName(this MethodBase method); // 0x00000001806D7A90-0x00000001806D7FA0
		public static Type RTReflectedOrDeclaredType(this MemberInfo member); // 0x00000001806D78F0-0x00000001806D79A0
		public static bool RTIsAssignableFrom(this Type type, Type other); // 0x00000001806D7540-0x00000001806D7570
		public static bool RTIsAssignableTo(this Type type, Type other); // 0x00000001806D7570-0x00000001806D75F0
		public static bool RTIsAbstract(this Type type); // 0x00000001806D7500-0x00000001806D7520
		public static bool RTIsValueType(this Type type); // 0x00000001806D78A0-0x00000001806D78C0
		public static bool RTIsArray(this Type type); // 0x00000001806D7520-0x00000001806D7540
		public static bool RTIsInterface(this Type type); // 0x00000001806D7850-0x00000001806D7870
		public static bool RTIsSubclassOf(this Type type, Type other); // 0x00000001806D7870-0x00000001806D78A0
		public static bool RTIsGenericParameter(this Type type); // 0x00000001806D77F0-0x00000001806D7820
		public static bool RTIsGenericType(this Type type); // 0x00000001806D7820-0x00000001806D7850
		public static MethodInfo RTGetGetMethod(this PropertyInfo prop); // 0x00000001806D6CE0-0x00000001806D6D00
		public static MethodInfo RTGetSetMethod(this PropertyInfo prop); // 0x00000001806D74E0-0x00000001806D7500
		public static MethodInfo RTGetDelegateMethodInfo(this Delegate del); // 0x00000001806D5F00-0x00000001806D5F20
		public static Type RTMakeGenericType(this Type type, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ Type[] typeArgs); // 0x00000001806D78C0-0x00000001806D78F0
		public static Type[] RTGetGenericArguments(this Type type); // 0x00000001806D6BA0-0x00000001806D6CE0
		public static Type[] RTGetGenericArguments(this MethodInfo method); // 0x00000001806D6A60-0x00000001806D6BA0
		public static Type RTGetElementType(this Type type); // 0x00000001806D6170-0x00000001806D61F0
		public static bool RTIsByRef(this Type type); // 0x00000001806D75F0-0x00000001806D7670
		public static object CreateObject(this Type type); // 0x00000001806D0A30-0x00000001806D0AA0
		public static object CreateObjectUninitialized(this Type type); // 0x00000001806D09A0-0x00000001806D0A30
		public static ConstructorInfo RTGetDefaultConstructor(this Type type); // 0x00000001806D5E00-0x00000001806D5F00
		public static ConstructorInfo RTGetConstructor(this Type type, Type[] paramTypes); // 0x00000001806D5B10-0x00000001806D5CE0
		public static MethodInfo RTGetMethod(this Type type, string name); // 0x00000001806D7040-0x00000001806D7170
		public static MethodInfo RTGetMethod(this Type type, string name, Type[] paramTypes, Type returnType = null, Type[] genericArgumentTypes = null); // 0x00000001806D6D00-0x00000001806D7040
		public static FieldInfo RTGetField(this Type type, string name, bool includePrivateBase = false /* Metadata: 0x007BB5A2 */); // 0x00000001806D67B0-0x00000001806D6940
		public static PropertyInfo RTGetProperty(this Type type, string name); // 0x00000001806D73B0-0x00000001806D74E0
		public static MemberInfo RTGetFieldOrProp(this Type type, string name); // 0x00000001806D65A0-0x00000001806D67B0
		public static EventInfo RTGetEvent(this Type type, string name); // 0x00000001806D6250-0x00000001806D6480
		public static ConstructorInfo[] RTGetConstructors(this Type type); // 0x00000001806D5CE0-0x00000001806D5E00
		public static MethodInfo[] RTGetMethods(this Type type); // 0x00000001806D7170-0x00000001806D7290
		public static FieldInfo[] RTGetFields(this Type type); // 0x00000001806D6940-0x00000001806D6A60
		public static PropertyInfo[] RTGetProperties(this Type type); // 0x00000001806D7290-0x00000001806D73B0
		public static EventInfo[] RTGetEvents(this Type type); // 0x00000001806D6480-0x00000001806D65A0
		public static object[] RTGetAllAttributes(this Type type); // 0x00000001806D5390-0x00000001806D54A0
		public static bool RTIsDefined<T>(this Type type, bool inherited)
			where T : Attribute;
		public static bool RTIsDefined(this Type type, Type attributeType, bool inherited); // 0x00000001806D7670-0x00000001806D7730
		public static T RTGetAttribute<T>(this Type type, bool inherited)
			where T : Attribute;
		public static Attribute RTGetAttribute(this Type type, Type attributeType, bool inherited); // 0x00000001806D5860-0x00000001806D5B10
		public static object[] RTGetAllAttributes(this MemberInfo member); // 0x00000001806D54A0-0x00000001806D55B0
		public static bool RTIsDefined<T>(this MemberInfo member, bool inherited)
			where T : Attribute;
		public static bool RTIsDefined(this MemberInfo member, Type attributeType, bool inherited); // 0x00000001806D7730-0x00000001806D77F0
		public static T RTGetAttribute<T>(this MemberInfo member, bool inherited)
			where T : Attribute;
		public static Attribute RTGetAttribute(this MemberInfo member, Type attributeType, bool inherited); // 0x00000001806D55B0-0x00000001806D5860
		[IteratorStateMachine] // 0x000000018023EC40-0x000000018023ECB0
		public static IEnumerable<T> RTGetAttributesRecursive<T>(this Type type)
			where T : Attribute;
		public static ParameterInfo[] RTGetDelegateTypeParameters(this Type delegateType); // 0x00000001806D5F20-0x00000001806D6170
		public static T RTCreateDelegate<T>(this MethodInfo method, object instance)
			where T : Delegate;
		public static Delegate RTCreateDelegate(this MethodInfo method, Type type, object instance); // 0x00000001806D5180-0x00000001806D5390
		public static bool IsReadOnly(this FieldInfo field); // 0x00000001806D4FF0-0x00000001806D5030
		public static bool IsConstant(this FieldInfo field); // 0x00000001806D4730-0x00000001806D47B0
		public static bool IsStatic(this EventInfo info); // 0x00000001806D5030-0x00000001806D5090
		public static bool IsStatic(this PropertyInfo info); // 0x00000001806D5090-0x00000001806D50F0
		public static bool IsParams(this ParameterInfo parameter, ParameterInfo[] parameters); // 0x00000001806D4EC0-0x00000001806D4F90
		public static bool IsObsolete(this MemberInfo member, bool inherited = true /* Metadata: 0x007BB5A3 */); // 0x00000001806D49C0-0x00000001806D4EC0
		public static PropertyInfo GetBaseDefinition(this PropertyInfo propertyInfo); // 0x00000001806D27D0-0x00000001806D2A30
		public static FieldInfo GetBaseDefinition(this FieldInfo fieldInfo); // 0x00000001806D2A30-0x00000001806D2AD0
		public static MethodInfo[] GetExtensionMethods(this Type targetType); // 0x00000001806D2D70-0x00000001806D3160
		public static bool IsExtensionMethod(this MethodInfo method); // 0x00000001806D4920-0x00000001806D4980
		public static bool IsPropertyAccessor(this MethodInfo method); // 0x00000001806D4F90-0x00000001806D4FF0
		public static bool IsIndexerProperty(this PropertyInfo property); // 0x00000001806D4980-0x00000001806D49C0
		public static bool IsAutoProperty(this PropertyInfo property); // 0x00000001806D4620-0x00000001806D4730
		public static PropertyInfo GetAccessorProperty(this MethodInfo method); // 0x00000001806D2130-0x00000001806D23D0
		public static bool IsEnumerableCollection(this Type type); // 0x00000001806D47B0-0x00000001806D4920
		public static Type GetEnumerableElementType(this Type type); // 0x00000001806D2AD0-0x00000001806D2D70
		public static Type GetSingleGenericArgument(this Type type); // 0x00000001806D39C0-0x00000001806D3A70
		public static Type GetFirstGenericParameterConstraintType(this Type type); // 0x00000001806D32C0-0x00000001806D3460
		public static Type GetFirstGenericParameterConstraintType(this MethodInfo method); // 0x00000001806D3160-0x00000001806D32C0
		public static bool CanBeMadeGenericWith(this Type def, Type type); // 0x00000001806D0790-0x00000001806D08B0
		public static bool CanBeMadeGenericWith(this MethodInfo def, Type type); // 0x00000001806D06B0-0x00000001806D0790
		public static bool IsAllowedByGenericArgument(this Type type, Type genericArgument); // 0x00000001806D4280-0x00000001806D4620
		public static Array Resize(this Array array, int newSize); // 0x00000001806D79A0-0x00000001806D7A90
	}
}
