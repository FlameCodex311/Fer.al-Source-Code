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
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal static class MiscellaneousUtils // TypeDefIndex: 8043
	{
		// Methods
		public static bool ValueEquals(object objA, object objB); // 0x0000000180C2C680-0x0000000180C2C9D0
		public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message); // 0x0000000180C2C390-0x0000000180C2C460
		public static int ByteArrayCompare(byte[] a1, byte[] a2); // 0x0000000180C2C2E0-0x0000000180C2C390
		public static string GetPrefix(string qualifiedName); // 0x0000000180C2C550-0x0000000180C2C5E0
		public static string GetLocalName(string qualifiedName); // 0x0000000180C2C4E0-0x0000000180C2C550
		public static void GetQualifiedNameParts(string qualifiedName, out string prefix, out string localName); // 0x0000000180C2C5E0-0x0000000180C2C680
		internal static string FormatValueForPrint(object value); // 0x0000000180C2C460-0x0000000180C2C4E0
	}
}
