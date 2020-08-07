/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	public static class ReflectionTools // TypeDefIndex: 7050
	{
		// Nested types
		[Flags] // 0x00000001801CDAD0-0x00000001801CDAE0
		public enum BindingFlags // TypeDefIndex: 7051
		{
			IgnoreCase = 1,
			DeclaredOnly = 2,
			Instance = 4,
			Static = 8,
			Public = 16,
			NonPublic = 32,
			FlattenHierarchy = 64
		}
	
		// Methods
		public static bool IsValueType(Type type); // 0x00000001806D78A0-0x00000001806D78C0
		public static bool IsEnum(Type type); // 0x0000000181460940-0x0000000181460960
		public static Type GetUnderlyingEnumType(Type enumType); // 0x0000000181460550-0x00000001814605D0
		public static bool IsClass(Type type); // 0x0000000181460900-0x0000000181460920
		public static bool IsPrimitive(Type type); // 0x0000000181460980-0x00000001814609A0
		public static bool IsArray(Type type); // 0x00000001806D7520-0x00000001806D7540
		public static bool DoesTypeImplement(Type type, Type baseOrInterfaceType); // 0x00000001813E33C0-0x00000001813E33F0
		public static bool IsGenericType(Type type); // 0x0000000181460960-0x0000000181460980
		public static Type[] GetGenericArguments(Type type); // 0x00000001814603E0-0x0000000181460400
		public static IEnumerable<FieldInfo> GetFields(Type type); // 0x00000001814603D0-0x00000001814603E0
		public static IEnumerable<FieldInfo> GetFields(Type type, BindingFlags bindingFlags); // 0x00000001814603B0-0x00000001814603D0
		public static IEnumerable<PropertyInfo> GetProperties(Type type); // 0x0000000181460440-0x0000000181460450
		public static IEnumerable<PropertyInfo> GetProperties(Type type, BindingFlags bindingFlags); // 0x0000000181460450-0x0000000181460470
		public static IEnumerable<MethodInfo> GetMethods(Type type); // 0x0000000181460410-0x0000000181460420
		public static IEnumerable<MethodInfo> GetMethods(Type type, BindingFlags bindingFlags); // 0x0000000181460420-0x0000000181460440
		public static bool IsDefined(Type type, Type attributeType, bool inherit); // 0x0000000181460920-0x0000000181460940
		public static T GetAttribute<T>(Type type, bool inherit)
			where T : Attribute;
		internal static bool IsAssemblyLoaded(string assemblyName, bool useShortName, bool ignoreCase); // 0x00000001814605D0-0x0000000181460900
		internal static Type GetTypeInUnityEditorAssembly(string classPath, bool ignoreCase = false /* Metadata: 0x007667A7 */); // 0x0000000181460540-0x0000000181460550
		internal static Type GetTypeInUnityBuildAssembly(string classPath, bool ignoreCase = false /* Metadata: 0x007667A8 */); // 0x0000000181460530-0x0000000181460540
		private static Type QAAFzCNodXgjvQxNteeqEOzuZhvV(string param_0000f3dc, bool param_0000f3dd, bool param_0000f3de = false /* Metadata: 0x007667A9 */); // 0x00000001814609A0-0x0000000181460AE0
		internal static Type GetTypeInAssembly(string classPath, string assemblyName, bool ignoreCase = false /* Metadata: 0x007667AA */); // 0x0000000181460470-0x0000000181460530
		public static TRet GetPrivateField<T, TRet>(T obj, string name);
		public static TRet GetPrivateProperty<T, TRet>(T obj, string name);
		public static void SetPrivateField<T>(T obj, string name, object value);
		public static void SetPrivateProperty<T>(T obj, string name, object value);
		public static TRet CallPrivateMethod<T, TRet>(T obj, string name, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ object[] param);
		public static MethodInfo GetMethodInfo(Delegate @delegate); // 0x0000000181460400-0x0000000181460410
	}
}
