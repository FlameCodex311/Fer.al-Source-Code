/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001801CDDD0-0x00000001801CDE00
	internal static class TypeExtensions // TypeDefIndex: 8050
	{
		// Extension methods
		public static MemberTypes MemberType(this MemberInfo memberInfo); // 0x0000000181159980-0x00000001811599B0
		public static bool ContainsGenericParameters(this Type type); // 0x00000001820D4A20-0x00000001820D4A50
		public static bool IsInterface(this Type type); // 0x00000001806D7850-0x00000001806D7870
		public static bool IsGenericType(this Type type); // 0x00000001806D7820-0x00000001806D7850
		public static bool IsGenericTypeDefinition(this Type type); // 0x00000001820D4CA0-0x00000001820D4CD0
		public static Type BaseType(this Type type); // 0x00000001814E2850-0x00000001814E2880
		public static bool IsEnum(this Type type); // 0x0000000180DF7310-0x0000000180DF7340
		public static bool IsClass(this Type type); // 0x0000000181460900-0x0000000181460920
		public static bool IsSealed(this Type type); // 0x00000001814E28E0-0x00000001814E2900
		public static bool IsAbstract(this Type type); // 0x00000001806D7500-0x00000001806D7520
		public static bool IsValueType(this Type type); // 0x00000001806D78A0-0x00000001806D78C0
		public static bool AssignableToTypeName(this Type type, string fullTypeName, out Type match); // 0x00000001820D48D0-0x00000001820D4A20
		public static bool AssignableToTypeName(this Type type, string fullTypeName); // 0x00000001820D47A0-0x00000001820D48D0
		public static bool ImplementInterface(this Type type, Type interfaceType); // 0x00000001820D4A50-0x00000001820D4CA0
	}
}
