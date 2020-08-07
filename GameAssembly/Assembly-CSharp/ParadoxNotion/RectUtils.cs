/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion
{
	public static class RectUtils // TypeDefIndex: 15844
	{
		// Methods
		public static Rect GetBoundRect(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ Rect[] rects); // 0x00000001806CFB80-0x00000001806CFDA0
		public static Rect GetBoundRect(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ Vector2[] positions); // 0x00000001806CF9A0-0x00000001806CFB80
	
		// Extension methods
		public static bool Encapsulates(this Rect a, Rect b); // 0x00000001806CF660-0x00000001806CF710
		public static Rect ExpandBy(this Rect rect, float margin); // 0x00000001806CF8D0-0x00000001806CF9A0
		public static Rect ExpandBy(this Rect rect, float xMargin, float yMargin); // 0x00000001806CF710-0x00000001806CF7F0
		public static Rect ExpandBy(this Rect rect, float left, float top, float right, float bottom); // 0x00000001806CF7F0-0x00000001806CF8D0
		public static Rect TransformSpace(this Rect rect, Rect oldContainer, Rect newContainer); // 0x00000001806CFDA0-0x00000001806D0020
		public static Vector2 TransformSpace(this Vector2 vector, Rect oldContainer, Rect newContainer); // 0x00000001806D0020-0x00000001806D0170
	}
}
