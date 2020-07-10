/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class CoreIEnumerableExtensions // TypeDefIndex: 13402
{
	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__1<T> // TypeDefIndex: 13403
	{
		// Fields
		public static readonly <>c__1<T> <>9;
		public static Func<T, int, <>f__AnonymousType0<T, int>> <>9__1_0;

		// Constructors
		static <>c__1();
		public <>c__1();

		// Methods
		internal <>f__AnonymousType0<T, int> <ForEach>b__1_0(T obj, int index);
	}

	// Extension methods
	public static IEnumerable<T> ForEach<T>(this IEnumerable<T> inIEnumerable, Action<T> inResult);
	public static IEnumerable<T> ForEach<T>(this IEnumerable<T> inIEnumerable, Action<int, T> inResult);
	public static IEnumerable ForEach(this IEnumerable inIEnumerable, Action<object> inResult); // 0x0000000181311E00-0x0000000181311FB0
	public static IEnumerable ForEach(this IEnumerable inIEnumerable, Action<int, object> inResult); // 0x0000000181311FB0-0x0000000181312180
}

