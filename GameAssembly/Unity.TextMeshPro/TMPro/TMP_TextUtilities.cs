/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	public static class TMP_TextUtilities // TypeDefIndex: 9035
	{
		// Fields
		private static Vector3[] m_rectWorldCorners; // 0x00
		private const string k_lookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-"; // Metadata: 0x0077856D
		private const string k_lookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-"; // Metadata: 0x007785F1
	
		// Nested types
		private struct LineSegment // TypeDefIndex: 9036
		{
			// Fields
			public Vector3 Point1; // 0x00
			public Vector3 Point2; // 0x0C
	
			// Constructors
			public LineSegment(Vector3 p1, Vector3 p2); // 0x0000000180071E90-0x0000000180071EC0
		}
	
		// Constructors
		static TMP_TextUtilities(); // 0x0000000180D3FBE0-0x0000000180D3FC30
	
		// Methods
		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera); // 0x0000000180D3E9B0-0x0000000180D3EBC0
		public static int GetCursorIndexFromPosition(TMP_Text textComponent, Vector3 position, Camera camera, out CaretPosition cursor); // 0x0000000180D3EBC0-0x0000000180D3EE90
		public static int FindNearestLine(TMP_Text text, Vector3 position, Camera camera); // 0x0000000180D3CB50-0x0000000180D3CE90
		public static int FindNearestCharacterOnLine(TMP_Text text, Vector3 position, int line, Camera camera, bool visibleOnly); // 0x0000000180D3C030-0x0000000180D3C600
		public static bool IsIntersectingRectTransform(RectTransform rectTransform, Vector3 position, Camera camera); // 0x0000000180D3F2F0-0x0000000180D3F530
		public static int FindIntersectingCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly); // 0x0000000180D3A2F0-0x0000000180D3A680
		public static int FindNearestCharacter(TMP_Text text, Vector3 position, Camera camera, bool visibleOnly); // 0x0000000180D3C600-0x0000000180D3CB50
		public static int FindIntersectingWord(TMP_Text text, Vector3 position, Camera camera); // 0x0000000180D3B190-0x0000000180D3C030
		public static int FindNearestWord(TMP_Text text, Vector3 position, Camera camera); // 0x0000000180D3DC10-0x0000000180D3E9B0
		public static int FindIntersectingLine(TMP_Text text, Vector3 position, Camera camera); // 0x0000000180D3A680-0x0000000180D3A900
		public static int FindIntersectingLink(TMP_Text text, Vector3 position, Camera camera); // 0x0000000180D3A900-0x0000000180D3B190
		public static int FindNearestLink(TMP_Text text, Vector3 position, Camera camera); // 0x0000000180D3CE90-0x0000000180D3DC10
		private static bool PointIntersectRectangle(Vector3 m, Vector3 a, Vector3 b, Vector3 c, Vector3 d); // 0x0000000180D3F530-0x0000000180D3F7C0
		public static bool ScreenPointToWorldPointInRectangle(Transform transform, Vector2 screenPoint, Camera cam, out Vector3 worldPoint); // 0x0000000180D3F7C0-0x0000000180D3FA10
		private static bool IntersectLinePlane(LineSegment line, Vector3 point, Vector3 normal, out Vector3 intersectingPoint); // 0x0000000180D3F050-0x0000000180D3F2F0
		public static float DistanceToLine(Vector3 a, Vector3 b, Vector3 point); // 0x0000000180D39FF0-0x0000000180D3A2F0
		public static char ToLowerFast(char c); // 0x0000000180D3FB20-0x0000000180D3FB80
		public static char ToUpperFast(char c); // 0x0000000180D3FB80-0x0000000180D3FBE0
		public static int GetSimpleHashCode(string s); // 0x0000000180D39C60-0x0000000180D39CC0
		public static uint GetSimpleHashCodeLowercase(string s); // 0x0000000180D3EE90-0x0000000180D3EF40
		public static int HexToInt(char hex); // 0x0000000180D3EF40-0x0000000180D3F050
		public static int StringHexToInt(string s); // 0x0000000180D3FA10-0x0000000180D3FB20
	}
}
