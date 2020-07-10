/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class CoreListExtensions // TypeDefIndex: 13404
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <FastReverse>d__14<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 13405
	{
		// Fields
		private int <>1__state;
		private T <>2__current;
		private int <>l__initialThreadId;
		private IList<T> items;
		public IList<T> <>3__items;
		private int <i>5__2;

		// Properties
		T IEnumerator<T>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; }

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <FastReverse>d__14(int <>1__state);

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		IEnumerator<T> IEnumerable<T>.GetEnumerator();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		IEnumerator IEnumerable.GetEnumerator();
	}

	// Extension methods
	public static T SafeFind<T>(this List<T> inList, Func<T, bool> inFunc);
	public static bool IsNullOrEmpty<T>(this List<T> inList);
	public static bool AddIfAbsent<T>(this List<T> inList, T inValue);
	public static T GetExistingEntryOrNull<T>(this List<T> inList, T inValue)
		where T : class;
	public static T GetRandom<T>(this List<T> inList);
	public static T RemoveRandomOrDefault<T>(this List<T> inList);
	public static T RemoveRandom<T>(this List<T> inList);
	private static T RemoveRandom<T>(this List<T> inList, bool isErrorTolerant);
	public static void AddRange<T>(this List<T> input, params /* 0x00000001800B36B0-0x00000001800B36C0 */ T[] values);
	public static List<T> GetWhenTrue<T>(this List<T> inList, Func<T, bool> inFunc);
	public static T GetLastItem<T>(this List<T> inList);
	public static bool IndexInRange<T>(this List<T> inList, int inIndex);
	public static void Shuffle<T>(this List<T> inList);
	public static void Shuffle<T>(this List<T> inList, ref UnityEngine.Random.State randomState);
	[IteratorStateMachine] // 0x000000018013EFA0-0x000000018013F010
	public static IEnumerable<T> FastReverse<T>(this IList<T> items);
	public static bool InRange(this IList list, int inIndex); // 0x0000000181312BE0-0x0000000181312CA0
	public static void MoveElement(this IList list, int fromIndex, int toIndex); // 0x0000000181312CA0-0x0000000181312E90
}

