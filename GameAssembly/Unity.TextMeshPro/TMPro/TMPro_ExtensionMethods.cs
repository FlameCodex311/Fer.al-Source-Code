/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	public static class TMPro_ExtensionMethods // TypeDefIndex: 9042
	{
		// Extension methods
		public static string ArrayToString(this char[] chars); // 0x0000000180D42380-0x0000000180D42440
		public static string IntToString(this int[] unicodes); // 0x0000000180D42680-0x0000000180D42730
		public static string IntToString(this int[] unicodes, int start, int length); // 0x0000000180D42730-0x0000000180D42850
		public static int FindInstanceID<T>(this List<T> list, T target)
			where T : UnityEngine.Object;
		public static bool Compare(this Color32 a, Color32 b); // 0x0000000180D42640-0x0000000180D42680
		public static bool CompareRGB(this Color32 a, Color32 b); // 0x0000000180D42480-0x0000000180D424B0
		public static bool Compare(this Color a, Color b); // 0x0000000180D42540-0x0000000180D42580
		public static bool CompareRGB(this Color a, Color b); // 0x0000000180D42440-0x0000000180D42480
		public static Color32 Multiply(this Color32 c1, Color32 c2); // 0x0000000180D42850-0x0000000180D42940
		public static Color32 Tint(this Color32 c1, Color32 c2); // 0x0000000180D42850-0x0000000180D42940
		public static Color32 Tint(this Color32 c1, float tint); // 0x0000000180D42940-0x0000000180D42AC0
		public static bool Compare(this Vector3 v1, Vector3 v2, int accuracy); // 0x0000000180D424B0-0x0000000180D42540
		public static bool Compare(this Quaternion q1, Quaternion q2, int accuracy); // 0x0000000180D42580-0x0000000180D42640
	}
}
