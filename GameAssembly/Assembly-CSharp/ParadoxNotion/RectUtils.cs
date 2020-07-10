/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion
{
	public static class RectUtils // TypeDefIndex: 14695
	{
		// Methods
		public static Rect GetBoundRect(params /* 0x00000001800B36B0-0x00000001800B36C0 */ Rect[] rects); // 0x0000000181382B00-0x0000000181382D30
		public static Rect GetBoundRect(params /* 0x00000001800B36B0-0x00000001800B36C0 */ Vector2[] positions); // 0x0000000181382910-0x0000000181382B00
	
		// Extension methods
		public static bool Encapsulates(this Rect a, Rect b); // 0x00000001813825D0-0x0000000181382680
		public static Rect ExpandBy(this Rect rect, float margin); // 0x0000000181382840-0x0000000181382910
		public static Rect ExpandBy(this Rect rect, float xMargin, float yMargin); // 0x0000000181382680-0x0000000181382760
		public static Rect ExpandBy(this Rect rect, float left, float top, float right, float bottom); // 0x0000000181382760-0x0000000181382840
		public static Rect TransformSpace(this Rect rect, Rect oldContainer, Rect newContainer); // 0x0000000181382D30-0x0000000181382FB0
		public static Vector2 TransformSpace(this Vector2 vector, Rect oldContainer, Rect newContainer); // 0x0000000181382FB0-0x0000000181383100
	}
}
