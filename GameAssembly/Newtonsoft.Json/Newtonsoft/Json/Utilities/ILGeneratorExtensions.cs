/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001800B4050-0x00000001800B4080
	internal static class ILGeneratorExtensions // TypeDefIndex: 7830
	{
		// Extension methods
		public static void PushInstance(this ILGenerator generator, Type type); // 0x0000000180589DD0-0x0000000180589F00
		public static void PushArrayInstance(this ILGenerator generator, int argsIndex, int arrayIndex); // 0x0000000180589CD0-0x0000000180589DD0
		public static void BoxIfNeeded(this ILGenerator generator, Type type); // 0x0000000180589AC0-0x0000000180589BB0
		public static void UnboxIfNeeded(this ILGenerator generator, Type type); // 0x0000000180589F80-0x000000018058A070
		public static void CallMethod(this ILGenerator generator, MethodInfo methodInfo); // 0x0000000180589BB0-0x0000000180589CD0
		public static void Return(this ILGenerator generator); // 0x0000000180589F00-0x0000000180589F80
	}
}
