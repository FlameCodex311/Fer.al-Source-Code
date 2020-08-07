/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils
{
	public static class EnumTools // TypeDefIndex: 7040
	{
		// Methods
		public static string GetName<TEnum>(TEnum value)
			where TEnum : struct, IComparable, IFormattable;
		public static bool ConvertByName<TEnumFrom, TEnumTo>(TEnumFrom convertFrom, out TEnumTo value)
			where TEnumFrom : struct, IFormattable, IComparable
			where TEnumTo : struct, IFormattable, IComparable;
		public static int[] GetIntValues(Type enumType); // 0x00000001813E7C90-0x00000001813E7CF0
		public static bool IsEnum(Type type); // 0x00000001813E7D00-0x00000001813E7D10
		public static Type GetUnderlyingType(Type type); // 0x00000001813E7CF0-0x00000001813E7D00
		public static bool IsValidUnderlyingType(Type underlyingType); // 0x00000001813E7D10-0x00000001813E8010
	}
}
