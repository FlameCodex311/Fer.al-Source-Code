/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Interfaces;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils
{
	public static class ArrayTools // TypeDefIndex: 7037
	{
		// Methods
		public static int[] ConvertToIntArray(Array array); // 0x000000018108E3D0-0x000000018108E6B0
		public static T[] DeepClone<T>(T[] array)
			where T : class, IDeepCloneable;
		public static T[] ShallowCopy<T>(T[] array);
		public static void ShallowCopy<T>(T[] sourceArray, T[] targetArray);
		public static void ShallowCopy(int[] sourceArray, int[] targetArray); // 0x000000018108F740-0x000000018108F7C0
		public static void ShallowCopy(float[] sourceArray, float[] targetArray); // 0x000000018108F7C0-0x000000018108F840
		public static void ShallowCopy(bool[] sourceArray, bool[] targetArray); // 0x000000018108F680-0x000000018108F740
		public static byte[] CopyRange(byte[] inArray, int startPos, int length); // 0x000000018108E7D0-0x000000018108E8D0
		public static int[] CopyRange(int[] inArray, int startPos, int length); // 0x000000018108E8D0-0x000000018108E9F0
		public static float[] CopyRange(float[] inArray, int startPos, int length); // 0x000000018108E6B0-0x000000018108E7D0
		public static string[] CopyRange(string[] inArray, int startPos, int length); // 0x000000018108E9F0-0x000000018108EB40
		public static byte[] Combine(byte[] inArray1, byte[] inArray2); // 0x000000018108D870-0x000000018108DAC0
		public static int[] Combine(int[] inArray1, int[] inArray2); // 0x000000018108E020-0x000000018108E2A0
		public static float[] Combine(float[] inArray1, float[] inArray2); // 0x000000018108DAC0-0x000000018108DD10
		public static string[] Combine(string[] inArray1, string[] inArray2); // 0x000000018108DD10-0x000000018108E020
		public static T[] ParseArray<T>(string line);
		public static T[] SortAscending<T>(T[] array, out int[] sortedIndices)
			where T : IComparable<T>;
		public static T[] SortDescending<T>(T[] array, out int[] sortedIndices, bool ascending = true /* Metadata: 0x00766756 */)
			where T : IComparable<T>;
		public static int Add<T>(ref T[] array, T item);
		public static int AddIfUnique<T>(ref T[] array, T item);
		public static int Insert<T>(ref T[] array, int index, T item);
		public static bool RemoveAt<T>(ref T[] array, int index);
		public static bool Remove<T>(ref T[] array, T item);
		public static void Combine<T>(ref T[] array1, T[] array2);
		public static T[] Add<T>(T[] array, T item);
		public static T[] AddIfUnique<T>(T[] array, T item);
		public static T[] Insert<T>(T[] array, int index, T item);
		public static T[] RemoveAt<T>(T[] array, int index);
		public static T[] Remove<T>(T[] array, T item);
		public static T[] Combine<T>(T[] array1, T[] array2);
		public static int IndexOf<T>(T[] array, T item);
		public static bool Contains<T>(T[] array, T item);
		public static T Find<T>(T[] array, Predicate<T> predicate);
		public static bool SubArray<T>(ref T[] array, int startIndex);
		public static bool SubArray<T>(ref T[] array, int startIndex, int count);
		public static void Expand<T>(ref T[] array, int length);
		public static void Trim(string[] array); // 0x00000001810901C0-0x00000001810902A0
		public static RaycastHit[] SortNearToFar(RaycastHit[] hits); // 0x000000018108F840-0x000000018108FD90
		public static void MoveEntryUp<T>(T[] array, int index);
		public static void MoveEntryDown<T>(T[] array, int index);
		public static void Compact<T>(ref T[] array)
			where T : class;
		public static int IndexOf(int[] array, int value); // 0x000000018108ED40-0x000000018108EDC0
		public static int IndexOf(float[] array, float value); // 0x000000018108EF10-0x000000018108EFA0
		public static int IndexOf(short[] array, short value); // 0x000000018108EBC0-0x000000018108EC80
		public static int IndexOf(ushort[] array, ushort value); // 0x000000018108EDC0-0x000000018108EE50
		public static int IndexOf(uint[] array, uint value); // 0x000000018108EB40-0x000000018108EBC0
		public static int IndexOf(double[] array, double value); // 0x000000018108F070-0x000000018108F0F0
		public static int IndexOf(bool[] array, bool value); // 0x000000018108EE50-0x000000018108EF10
		public static int IndexOf(string[] array, string value); // 0x000000018108EC80-0x000000018108ED40
		public static int IndexOf(string[] array, string value, StringComparison stringComparison); // 0x000000018108EFA0-0x000000018108F070
		public static void Fill<T>(T[] array, T value);
		public static void Fill<T>(T[] array, T value, int startIndex);
		public static void Fill<T>(T[] array, T value, int startIndex, int length);
		public static void Populate<T>(T[] array, int startIndex, int length, Func<T> instantiator);
		public static void Populate<T>(T[] array, int startIndex, int length)
			where T : class, new();
		public static void Populate<T>(T[] array)
			where T : class, new();
		public static void Populate<T>(T[] array, Func<T> instantiator);
		public static int Count<T>(T[] array, Predicate<T> predicate);
		public static bool IsEqual(byte[] a1, byte[] a2); // 0x000000018108F0F0-0x000000018108F1A0
		public static bool Contains(string[] array, string item, bool ignoreCase); // 0x000000018108E2A0-0x000000018108E3D0
		public static int AddIfUnique(ref string[] array, string item, bool ignoreCase); // 0x000000018108D6D0-0x000000018108D870
		public static void RemoveDuplicates(ref string[] array, bool ignoreCase); // 0x000000018108F1A0-0x000000018108F3F0
		public static bool Remove(ref string[] array, string item, bool ignoreCase); // 0x000000018108F3F0-0x000000018108F680
		public static string[] ToLowerStripSpaces(string[] array); // 0x000000018108FFF0-0x00000001810901C0
		public static int ToBitmask(bool[] array, int startIndex, int count = 32 /* Metadata: 0x00766757 */); // 0x000000018108FD90-0x000000018108FFF0
		public static bool IsNullOrEmpty<T>(T[] array);
	}
}
