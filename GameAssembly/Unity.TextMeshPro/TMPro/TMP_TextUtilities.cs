/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	public static class TMP_TextUtilities // TypeDefIndex: 8873
	{
		// Fields
		private static Vector3[] m_rectWorldCorners; // 0x00
		private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; // Metadata: 0x007438A7
		private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; // Metadata: 0x0074392B
	
		// Nested types
		private struct LineSegment // TypeDefIndex: 8874
		{
			// Fields
			public Vector3 Point1; // 0x00
			public Vector3 Point2; // 0x0C
	
			// Constructors
			public LineSegment(Vector3 p1, Vector3 p2); // 0x000000018001F360-0x000000018001F3C0
		}
	
		// Constructors
		static TMP_TextUtilities(); // 0x0000000181887690-0x00000001818876E0
	
		// Methods
		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera); // 0x0000000181886440-0x0000000181886650
		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor); // 0x0000000181886650-0x0000000181886920
		public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera); // 0x00000001818845E0-0x0000000181884930
		public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly); // 0x0000000181883AA0-0x0000000181884080
		public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera); // 0x0000000181886D80-0x0000000181886FE0
		public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly); // 0x0000000181881D50-0x00000001818820F0
		public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly); // 0x0000000181884080-0x00000001818845E0
		public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera); // 0x0000000181882C00-0x0000000181883AA0
		public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera); // 0x00000001818856B0-0x0000000181886440
		public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera); // 0x00000001818820F0-0x0000000181882380
		public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera); // 0x0000000181882380-0x0000000181882C00
		public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera); // 0x0000000181884930-0x00000001818856B0
		private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d); // 0x0000000181886FE0-0x0000000181887270
		public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint); // 0x0000000181887270-0x00000001818874C0
		private static bool IntersectLinePlane(LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint); // 0x0000000181886AE0-0x0000000181886D80
		public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point); // 0x0000000181881A50-0x0000000181881D50
		public static char ToLowerFast(char c); // 0x00000001818875D0-0x0000000181887630
		public static char ToUpperFast(char c); // 0x0000000181887630-0x0000000181887690
		public static int GetSimpleHashCode(string s); // 0x00000001818816C0-0x0000000181881720
		public static uint GetSimpleHashCodeLowercase(string s); // 0x0000000181886920-0x00000001818869D0
		public static int HexToInt(char hex); // 0x00000001818869D0-0x0000000181886AE0
		public static int StringHexToInt(string s); // 0x00000001818874C0-0x00000001818875D0
	}
}
