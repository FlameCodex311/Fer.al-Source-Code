/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001800B4050-0x00000001800B4080
	internal static class TypeExtensions // TypeDefIndex: 7884
	{
		// Extension methods
		public static MemberTypes MemberType(this MemberInfo memberInfo); // 0x0000000180DF2A90-0x0000000180DF2AC0
		public static bool ContainsGenericParameters(this Type type); // 0x0000000180DF2790-0x0000000180DF27C0
		public static bool IsInterface(this Type type); // 0x0000000180DF2A70-0x0000000180DF2A90
		public static bool IsGenericType(this Type type); // 0x0000000180DF2A40-0x0000000180DF2A70
		public static bool IsGenericTypeDefinition(this Type type); // 0x0000000180DF2A10-0x0000000180DF2A40
		public static Type BaseType(this Type type); // 0x0000000180A42820-0x0000000180A42850
		public static bool IsEnum(this Type type); // 0x000000018060B3E0-0x000000018060B410
		public static bool IsClass(this Type type); // 0x0000000180A51E40-0x0000000180A51E60
		public static bool IsSealed(this Type type); // 0x0000000180A428D0-0x0000000180A428F0
		public static bool IsAbstract(this Type type); // 0x0000000180A428B0-0x0000000180A428D0
		public static bool IsValueType(this Type type); // 0x000000018060B510-0x000000018060B530
		public static bool AssignableToTypeName(this Type type, string fullTypeName, out Type match); // 0x0000000180DF2640-0x0000000180DF2790
		public static bool AssignableToTypeName(this Type type, string fullTypeName); // 0x0000000180DF2510-0x0000000180DF2640
		public static bool ImplementInterface(this Type type, Type interfaceType); // 0x0000000180DF27C0-0x0000000180DF2A10
	}
}
