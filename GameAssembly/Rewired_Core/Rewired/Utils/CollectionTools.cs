/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils
{
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal static class CollectionTools // TypeDefIndex: 7039
	{
		// Methods
		public static Dictionary<TValue, TKey> CreateInverseDictionary<TKey, TValue>(Dictionary<TKey, TValue> dict);
		public static TReturn GetDictionaryValueSafe<TReturn>(Dictionary<string, object> dictionary, string key);
		public static TReturn GetDictionaryValueSafe<TReturn>(Dictionary<string, object> dictionary, string key, out bool success);
		public static TValue GetDictionaryValueSafe<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key);
		public static TValue GetDictionaryValueSafe<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key, out bool success);
		public static bool GetDictionaryValueSafe<TReturn>(Dictionary<string, object> dictionary, string key, ref TReturn value);
		public static bool GetDictionaryValueSafe(Dictionary<string, object> dictionary, string key, Type type, ref object value); // 0x00000001813E5250-0x00000001813E5310
		public static bool GetDictionaryValueSafe_float(Dictionary<string, object> dictionary, string key, ref float value); // 0x00000001813E4FA0-0x00000001813E5120
		public static bool GetDictionaryValueSafe_int(Dictionary<string, object> dictionary, string key, ref int value); // 0x00000001813E5120-0x00000001813E5250
		public static void AddValueSafe(Dictionary<string, object> data, string key, object value); // 0x00000001813E4E20-0x00000001813E4FA0
		public static T GetValue<T>(IEnumerable<T> enumerable, int index);
		public static T GetValue<T>(IEnumerable enumerable, int index);
	}
}
