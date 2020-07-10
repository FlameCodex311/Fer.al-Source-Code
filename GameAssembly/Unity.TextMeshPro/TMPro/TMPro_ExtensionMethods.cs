/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	public static class TMPro_ExtensionMethods // TypeDefIndex: 8880
	{
		// Extension methods
		public static string ArrayToString(this char[] chars); // 0x000000018188A030-0x000000018188A100
		public static string IntToString(this int[] unicodes); // 0x000000018188A340-0x000000018188A400
		public static string IntToString(this int[] unicodes, int start, int length); // 0x000000018188A400-0x000000018188A530
		public static int FindInstanceID<T>(this List<T> list, T target)
			where T : UnityEngine.Object;
		public static bool Compare(this Color32 a, Color32 b); // 0x000000018188A300-0x000000018188A340
		public static bool CompareRGB(this Color32 a, Color32 b); // 0x000000018188A140-0x000000018188A170
		public static bool Compare(this Color a, Color b); // 0x000000018188A200-0x000000018188A240
		public static bool CompareRGB(this Color a, Color b); // 0x000000018188A100-0x000000018188A140
		public static Color32 Multiply(this Color32 c1, Color32 c2); // 0x000000018188A530-0x000000018188A620
		public static Color32 Tint(this Color32 c1, Color32 c2); // 0x000000018188A530-0x000000018188A620
		public static Color32 Tint(this Color32 c1, float tint); // 0x000000018188A620-0x000000018188A7A0
		public static bool Compare(this Vector3 v1, Vector3 v2, int accuracy); // 0x000000018188A170-0x000000018188A200
		public static bool Compare(this Quaternion q1, Quaternion q2, int accuracy); // 0x000000018188A240-0x000000018188A300
	}
}
