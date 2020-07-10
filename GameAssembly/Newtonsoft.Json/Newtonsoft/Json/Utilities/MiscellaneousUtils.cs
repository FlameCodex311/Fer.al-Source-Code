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
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal static class MiscellaneousUtils // TypeDefIndex: 7877
	{
		// Methods
		public static bool ValueEquals(object objA, object objB); // 0x0000000180594500-0x0000000180594850
		public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message); // 0x0000000180594210-0x00000001805942E0
		public static int ByteArrayCompare(byte[] a1, byte[] a2); // 0x0000000180594150-0x0000000180594210
		public static string GetPrefix(string qualifiedName); // 0x00000001805943D0-0x0000000180594460
		public static string GetLocalName(string qualifiedName); // 0x0000000180594360-0x00000001805943D0
		public static void GetQualifiedNameParts(string qualifiedName, out string prefix, out string localName); // 0x0000000180594460-0x0000000180594500
		internal static string FormatValueForPrint(object value); // 0x00000001805942E0-0x0000000180594360
	}
}
