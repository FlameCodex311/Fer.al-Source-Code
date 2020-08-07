/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class CoreDictionaryExtensions // TypeDefIndex: 11070
{
	// Extension methods
	public static bool IsNullOrEmpty<T, U>(this Dictionary<T, U> inDict);
	public static bool IsEqual<T, U>(this Dictionary<T, U> inDict1, Dictionary<T, U> inDict2, Func<U, U, bool> inEqualityFunc);
	public static void CopyOver<T, U>(this Dictionary<T, U> inDict1, Dictionary<T, U> inDict2);
	public static U GetExistingEntryOrNull<T, U>(this Dictionary<T, U> inDict, T inKey)
		where U : class;
	public static void ForEach<TKey, TValue>(this Dictionary<TKey, TValue> inDict, Action<TKey, TValue> inAction);
	public static void ForEachValue<TKey, TValue>(this Dictionary<TKey, TValue> inDict, Action<TValue> inAction);
}

